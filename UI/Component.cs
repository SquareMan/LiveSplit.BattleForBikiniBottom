using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.BattleForBikiniBottom.UI
{
    public class Component : LogicComponent
    {
        private LiveSplitState _state;
        private SettingsControl _settingsControl;

        public Component(LiveSplitState state)
        {
            _state = state;
            _settingsControl = new SettingsControl();
        }
        
        public override Control GetSettingsControl(LayoutMode mode)
        {
            return _settingsControl;
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
            
        }

        public override string ComponentName { get; }

        public override void Dispose()
        {
            _settingsControl.Dispose();
        }
    }
}