using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using LiveSplit.BattleForBikiniBottom.UI;
using LiveSplit.ComponentUtil;

namespace LiveSplit.BattleForBikiniBottom.Logic
{
    
    [StructLayout(LayoutKind.Sequential)]
    public struct WorkingSetExInformation
    {
        public IntPtr VirtualAddress;
        public WorkingSetExBlock VirtualAttributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WorkingSetExBlock
    {
        public ulong Flags;
    }
    
    public static class Memory
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool K32QueryWorkingSetEx(IntPtr hProcess,
            [In, Out] WorkingSetExInformation[] pv, int cb);
        
        public static StringWatcher LevelName { get; private set; }
        public static MemoryWatcher Loading { get; private set; }
        public static MemoryWatcher SpatCount { get; private set; }
        public static MemoryWatcher FuseCount { get; private set; }
        public static MemoryWatcher GameStartNoAutosave { get; private set; }
        public static MemoryWatcher GameStartWithAutosave { get; private set; }
        
        public static bool IsHooked { get; private set; }

        private static Process _dolphinProcess;
        private const double HookAttemptDelay = 1.0;
        private static DateTime _nextHookAttemptTime;

        /// <summary>
        /// Updates all MemoryWatchers
        /// </summary>
        public static void Update()
        {
            HookProcess();
            if (!IsHooked)
                return;

            Loading.Update(_dolphinProcess);
            SpatCount.Update(_dolphinProcess);
            LevelName.Update(_dolphinProcess);
            FuseCount.Update(_dolphinProcess);
            GameStartNoAutosave.Update(_dolphinProcess);
            GameStartWithAutosave.Update(_dolphinProcess);
        }
        
        /// <summary>
        /// Attempt to hook the game process (if not already hooked)
        /// </summary>
        private static void HookProcess()
        {
            //Unhook if the process exits
            if (_dolphinProcess != null && _dolphinProcess.HasExited)
            {
                // The game has exited and we need to clean up
                _dolphinProcess.Dispose();
                _dolphinProcess = null;
                IsHooked = false;
                return;
            }
            
            // TODO: figure out logic for unhooking when emulation is stopped but dolphin remains open.
            if (IsHooked)
            {
                return;
            }

            // Only attempt to hook process once per second.
            if (DateTime.Now < _nextHookAttemptTime)
            {
                return;
            }
            _nextHookAttemptTime = DateTime.Now.AddSeconds(HookAttemptDelay);
            
            if (_dolphinProcess == null)
            {
                _dolphinProcess = Process.GetProcessesByName("Dolphin").FirstOrDefault();
                if (_dolphinProcess == null)
                    return;
            }

            // Attempt to locate the emulated memory
            IntPtr emulatedMemoryBaseAddress = IntPtr.Zero;
            foreach (var page in _dolphinProcess.MemoryPages(true)
                .Where(i => i.RegionSize == (UIntPtr) 0x2000000 && i.Type == MemPageType.MEM_MAPPED))
            {
                WorkingSetExInformation[] wsi = {new WorkingSetExInformation{VirtualAddress = page.BaseAddress}};
                if(K32QueryWorkingSetEx(_dolphinProcess.Handle, wsi,
                    (int) Marshal.SizeOf(typeof(WorkingSetExInformation))));
                {
                    if ((wsi[0].VirtualAttributes.Flags & 0b1) == 1)
                    {
                        emulatedMemoryBaseAddress = page.BaseAddress;
                        break;
                    }
                }
            }

            if (emulatedMemoryBaseAddress != IntPtr.Zero)
            {
                IsHooked = true;
                Loading = new MemoryWatcher<byte>(emulatedMemoryBaseAddress + 0x3CB7B3);
                SpatCount = new MemoryWatcher<byte>(emulatedMemoryBaseAddress + 0x3C205F);
                LevelName = new StringWatcher(emulatedMemoryBaseAddress + 0x28060B, ReadStringType.ASCII, 4);
                FuseCount = new MemoryWatcher<byte>(emulatedMemoryBaseAddress + 0x595B15);
                GameStartNoAutosave = new MemoryWatcher<bool>(emulatedMemoryBaseAddress + 0x541E9C);
                GameStartWithAutosave = new MemoryWatcher<bool>(emulatedMemoryBaseAddress + 0x55D6C0);
            }
        }
    }
}