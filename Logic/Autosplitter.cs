using System;
using LiveSplit.Model;

namespace LiveSplit.BattleForBikiniBottom.Logic
{
    public class Autosplitter
    {
        private LiveSplitState _state;
        private TimerModel _model;
        
        private static readonly TimeSpan _splitDelay = TimeSpan.FromSeconds(0.1f);
        private DateTime _timeUntilNextSplit;

        public Autosplitter(LiveSplitState state)
        {
            _state = state;
            _model = new TimerModel() {CurrentState = _state};
        }

        public void Update()
        {
            if (!Memory.IsHooked)
                return;
            
            switch (_state.CurrentPhase)
            {
                case TimerPhase.NotRunning:
                    if (ShouldStart())
                    {
                        _model.Start();
                    }
                    break;
                case TimerPhase.Running:
                    if (DateTime.Now > _timeUntilNextSplit && ShouldSplit())
                    {
                        _model.Split();
                        _timeUntilNextSplit = DateTime.Now + _splitDelay;
                    }
                    else if (ShouldReset())
                    {
                        _model.Reset();
                        if (ShouldStart())
                        {
                            _model.Start();
                        }
                    }
                    break;
            }
        }

        private bool ShouldStart()
        {
            return Memory.LevelName.Current == "MNU3" &&
                   (Memory.GameStartNoAutosave.Old == 0 && Memory.GameStartNoAutosave.Current == 1 ||
                    Memory.GameStartWithAutosave.Old == 0 && Memory.GameStartWithAutosave.Current == 1);
        }

        private bool ShouldSplit()
        {
            Split currentSplit = AutosplitterSettings.Autosplits[_state.CurrentSplitIndex];
            
            Level oldLevel = LevelHelper.GetLevelFromString(Memory.LevelName.Old);
            Level currentLevel = LevelHelper.GetLevelFromString(Memory.LevelName.Current);
            switch (currentSplit.Type)
            {
                case SplitType.GameEnd:
                    return Memory.FuseCount.Old == 1 && Memory.FuseCount.Current == 0 &&
                           (currentLevel == Level.ChumBucketBrain || currentLevel == Level.Any);
                case SplitType.LevelTransition:
                    Level targetLevel = (Level) currentSplit.SubType;
                    return targetLevel == Level.Any
                        ? Memory.LevelName.Old != Memory.LevelName.Current
                        : oldLevel != targetLevel && currentLevel == targetLevel;
                case SplitType.LoadScreen:
                    return !Memory.IsLoading.Old && Memory.IsLoading.Current;
                case SplitType.SpatCount:
                    return Memory.SpatulaCount.Old != currentSplit.SubType &&
                           Memory.SpatulaCount.Current == currentSplit.SubType;
                case SplitType.SpatGrab:
                    return Memory.SpatulaCount.Old < Memory.SpatulaCount.Current;
            }
            return false;
        }
        
        private bool ShouldReset()
        {
            Level oldLevel = LevelHelper.GetLevelFromString(Memory.LevelName.Old);
            Level currentLevel = LevelHelper.GetLevelFromString(Memory.LevelName.Current);
            switch (AutosplitterSettings.ResetPreference)
            {
                case ResetPreference.NewGame:
                    return Memory.LevelName.Current == "MNU3" &&
                           (Memory.GameStartNoAutosave.Old == 0 && Memory.GameStartNoAutosave.Current == 1 ||
                            Memory.GameStartWithAutosave.Old == 0 && Memory.GameStartWithAutosave.Current == 1);
                case ResetPreference.MainMenu:
                    // Map.Any only appears in memory when the game is not hooked (i.e. after a crash)
                    return oldLevel != Level.Any &&
                           oldLevel != currentLevel &&
                           currentLevel == Level.MainMenu;
            }

            return false;
        }
    }
}