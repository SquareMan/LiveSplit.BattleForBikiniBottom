using System;
using System.Reflection;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.BattleForBikiniBottom.UI
{
    public class Factory : IComponentFactory
    {
        public const string AutosplitterName = "Battle for Bikini Bottom Autosplitter";
        public string UpdateName => ComponentName;
        public string XMLURL => UpdateURL + "Components/Updates.xml";
        public string UpdateURL =>
            "https://raw.githubusercontent.com/SquareMan/LiveSplit.BattleForBikiniBottom/master";
        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
        public IComponent Create(LiveSplitState state) => new Component(state);

        public string ComponentName => $"{AutosplitterName} v{Version.ToString(3)}";
        public string Description => AutosplitterName;
        public ComponentCategory Category => ComponentCategory.Control;
    }
}