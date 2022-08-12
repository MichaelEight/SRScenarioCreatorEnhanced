using SRScenarioCreatorEnhanced.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced
{
    public partial class editorMainWindow : Form
    {
        public editorMainWindow()
        {
            InitializeComponent();
            UC_Scenario uc = new UC_Scenario();
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
            if (tabScenarioBtn.Checked)
            {
                UC_Scenario uc = new UC_Scenario();
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
    }
}
