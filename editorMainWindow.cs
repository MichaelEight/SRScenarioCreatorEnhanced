using SRScenarioCreatorEnhanced.UserControls;
using System;
using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;

// ***NOTE***
// It took total of 10h to find a way to connect editorMainWindow form to UC instances
// Needed to disable buttons, which user won't use and to allow data transport to the whole app
// If you ever find a way to change it (passing Form as arg) to events' system -- go ahead
// - Michael '8', 2022/08/12 14:29

namespace SRScenarioCreatorEnhanced
{
    public partial class editorMainWindow : Form
    {
        public editorMainWindow()
        {
            InitializeComponent();
            UC_Scenario uc = new UC_Scenario(this);
            addUserControl(uc);
        }

        // Display new tab
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainUCPanel.Controls.Clear();
            mainUCPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tabScenarioBtn_Click(object sender, EventArgs e)
        {
            if (tabScenarioBtn.Checked) // TO EDIT, don't reload loaded UC
            {
                UC_Scenario uc = new UC_Scenario(this);
                addUserControl(uc);
            }
        }

        private void tabSettingsBtn_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);
        }

        private void tabTheatersBtn_Click(object sender, EventArgs e)
        {
            UC_Theaters uc = new UC_Theaters();
            addUserControl(uc);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            // Get assembly version
            string versionNumber = ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               : Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Display assembly version in message box
            MessageBox.Show($"Current version: {versionNumber}\n" +
                $"Contributors: Michael '8'", "About Editor", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public void updateTabButtonsStatus()
        {
            if(Globals.isSettingsActive)
            {
                tabSettingsBtn.Enabled = true;
            }
            else
            {
                tabSettingsBtn.Enabled = false;
            }
        }
    }
}
