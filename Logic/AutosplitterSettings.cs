using System.Collections.Generic;

namespace LiveSplit.BattleForBikiniBottom.Logic
{
    public enum ResetPreference
    {
        NewGame,
        MainMenu,
        Never
    }
    
    public static class AutosplitterSettings
    {
        public static List<Split> Autosplits = new List<Split>();
        public static ResetPreference ResetPreference = ResetPreference.NewGame;
    }
}