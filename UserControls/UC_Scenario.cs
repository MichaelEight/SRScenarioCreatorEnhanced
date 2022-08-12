using System;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Scenario : UserControl
    {
        private editorMainWindow mainWindow;
        public UC_Scenario(editorMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            checkBox1.Checked = Globals.isSettingsActive;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*Code to unlock all tabs by checking checkbox
             * Globals.isSettingsActive = true;
            Globals.isTheatersActive = true;
            Globals.isRegionsActive = true;
            Globals.isResourcesActive = true;
            Globals.isWMActive = true;
            Globals.isOrbatActive = true;
            mainWindow.updateTabButtonsStatus();*/
        }
    }
}
// CODE TO USE TO UPDATE BTNs STATUS
/*
 * Globals.isSettingsActive = checkBox1.Checked;
            main.updateTabButtonsStatus();
*/