using System;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Scenario : UserControl
    {
        public UC_Scenario()
        {
            InitializeComponent();
            checkBox1.Checked = Globals.isChecked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Globals.isChecked = checkBox1.Checked;
        }
    }
}
