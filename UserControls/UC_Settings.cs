/// UC_Settings.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Settings : UserControl
    {
        private editorMainWindow mainForm;
        public UC_Settings(editorMainWindow mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
