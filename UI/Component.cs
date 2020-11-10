using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.BattleForBikiniBottom.Logic;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.BattleForBikiniBottom.UI
{
    public class Component : LogicComponent
    {
        public override string ComponentName => Factory.AutosplitterName;
        
        private Autosplitter _autosplitter;
        private ComponentSettingsControl _componentSettingsControl;

        public Component(LiveSplitState state)
        {
            _autosplitter = new Autosplitter(state);
            _componentSettingsControl = new ComponentSettingsControl(state);
            
            // TODO: This is a workaround for settings form not adding controls if the autosplits are incorrectly deemed to not have changed
            // (Such as when the component is deactivated/reactivated, the static list stays the same, but the form is new. 
            AutosplitterSettings.Autosplits = new List<Split>();
        }
        
        public override Control GetSettingsControl(LayoutMode mode)
        {
            return _componentSettingsControl;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return document.CreateElement("Settings");
        }

        public override void SetSettings(XmlNode settings)
        {
            
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            Memory.Update();
            _autosplitter.Update();
        }

        

        public override void Dispose()
        {
            _componentSettingsControl.Dispose();
        }
    }
}