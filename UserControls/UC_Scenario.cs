using System;
using System.Windows.Forms;

// TODO
// If you want -- make 'required' labels disappear when data is correct

/// ***File controlling behaviour of 'Scenario' Tab***
/// This tab provides info about file used in a specific scenario - names and what files will be edited
/// Tab content is reseted on tab switch, so all data MUST be saved in a separate class
/// ON LOAD tab loads data from that class and fills modified components
/// BASIC REQUIREMENTS are needed to safely unlock other tabs without files errors
/// - e.g. if no file is selected and user tries to modify it

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Scenario : UserControl
    {
        private editorMainWindow mainWindow;
        public UC_Scenario(editorMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            // TODO
            // Here load scenario data, saved during editing
            // -- When switching tabs, data on them resets, so we need to save it elsewhere

            activateOtherTabsIfPossible();
        }

        // Minimum required to allow to activate other tabs
        private void activateOtherTabsIfPossible()
        {
            // Basic requirements to allow unlocking tabs and other components
            if(areBasicRequirementsMet())
            {
                // Unlock Settings Tab and Export Button -- basic unlock
                Globals.isSettingsActive = true;
                exportScenarioButton.Enabled = true;

                // Unlock Theaters and Regions tabs
                Globals.isTheatersActive = checkModifyCVP.Checked;
                Globals.isRegionsActive = checkModifyCVP.Checked;

                // Unlock Resources and WM tabs
                Globals.isResourcesActive = checkModifyWM.Checked;
                Globals.isWMActive = checkModifyWM.Checked;

                // Unlock Orbat tab
                Globals.isOrbatActive = checkModifyOOB.Checked;
            }
            else // Disable them, if requirements are no longer met
            {
                exportScenarioButton.Enabled = false;

                Globals.isSettingsActive = false;
                Globals.isTheatersActive = false;
                Globals.isRegionsActive = false;
                Globals.isResourcesActive = false;
                Globals.isWMActive = false;
                Globals.isOrbatActive = false;
            }

            mainWindow.updateTabButtonsStatus();
        }

        // Checks if all required comboboxes / checkboxes are non-empty and it is safe to proceed
        private bool areBasicRequirementsMet()
        {
            if (string.IsNullOrEmpty(comboScenarioName.Text)) return false;
            if (string.IsNullOrEmpty(comboCacheName.Text) && checkCacheName.Checked == false) return false;
            if (string.IsNullOrEmpty(comboMapName.Text)) return false;
            if (string.IsNullOrEmpty(comboOOF.Text) && checkOOF.Checked == false) return false;
            if (string.IsNullOrEmpty(comboCVP.Text)) return false;
            if (string.IsNullOrEmpty(comboWM.Text)) return false;

            if(!checkNoneditDefault.Checked) // if default not selected
            {
                if (string.IsNullOrEmpty(comboUnit.Text)) return false;
                if (string.IsNullOrEmpty(comboPPLX.Text)) return false;
                if (string.IsNullOrEmpty(comboTTRX.Text)) return false;
                if (string.IsNullOrEmpty(comboTERX.Text)) return false;
                if (string.IsNullOrEmpty(comboNewsItems.Text)) return false;
                if (string.IsNullOrEmpty(comboProfile.Text)) return false;
            }

            return true;
        }

        // 'Maps' Checks
        private void checkNewMap_CheckedChanged(object sender, EventArgs e)
        {
            // Create new map: either copy-paste default map and empty it or copy-paste hard-coded content
        }

        private void checkOOF_CheckedChanged(object sender, EventArgs e)
        {
            comboOOF.Enabled = !checkOOF.Checked;

            if (checkOOF.Checked)
            {
                comboOOF.Text = comboMapName.Text;
            }
        }

        // 'Modify' Checks
        private void checkModifyCVP_CheckedChanged(object sender, EventArgs e)
        {
            activateOtherTabsIfPossible();
        }

        private void checkModifyWM_CheckedChanged(object sender, EventArgs e)
        {
            activateOtherTabsIfPossible();
        }

        private void checkModifyOOB_CheckedChanged(object sender, EventArgs e)
        {
            activateOtherTabsIfPossible();
        }

        // 'General' Checks
        private void checkCacheName_CheckedChanged(object sender, EventArgs e)
        {
            comboCacheName.Enabled = !checkCacheName.Checked;
            
            if(checkCacheName.Checked)
            {
                comboCacheName.Text = comboScenarioName.Text;
            }

            activateOtherTabsIfPossible();
        }

        // 'Non-editable' Checks
        private void checkNoneditDefault_CheckedChanged(object sender, EventArgs e)
        {
            activateOtherTabsIfPossible();
            comboUnit.Enabled = !checkNoneditDefault.Checked;
            comboPPLX.Enabled = !checkNoneditDefault.Checked;
            comboTTRX.Enabled = !checkNoneditDefault.Checked;
            comboTERX.Enabled = !checkNoneditDefault.Checked;
            comboNewsItems.Enabled = !checkNoneditDefault.Checked;
            comboProfile.Enabled = !checkNoneditDefault.Checked;
        }

        private void comboScenarioName_TextUpdate(object sender, EventArgs e)
        {
            // Update Cache name if it should be the same
            if (checkCacheName.Checked)
            {
                comboCacheName.Text = comboScenarioName.Text;
            }
        }

        private void comboMapName_TextUpdate(object sender, EventArgs e)
        {
            // Update OOF name if it should be the same
            if (checkOOF.Checked)
            {
                comboOOF.Text = comboMapName.Text;
            }
        }

        // Force check basic requirements by moving mouse
        private void UC_Scenario_MouseMove(object sender, MouseEventArgs e)
        {
            activateOtherTabsIfPossible();
        }
    }
}