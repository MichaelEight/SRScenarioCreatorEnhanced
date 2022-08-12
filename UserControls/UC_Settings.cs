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
