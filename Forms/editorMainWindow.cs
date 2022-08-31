/// editorMainWindow.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using SRScenarioCreatorEnhanced.Forms;
using SRScenarioCreatorEnhanced.UserControls;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
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
        #region movableToolBarPanelAssets
        // Movable toolbarPanel assets
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        // Use for editing scale of main window and UCs
        public float currentEditorScale;

        public ScenarioContent currentScenario;
        public SettingsContent currentSettings;

        private UC_Scenario currentUCScenario;
        private UC_Settings currentUCSettings;
        private UC_Theaters currentUCTheaters;
        private UC_Regions currentUCRegions;
        private UC_Resources currentUCResources;
        private UC_WM currentUCWM;
        private UC_Orbat currentUCOrbat;

        public editorMainWindow()
        {
            InitializeComponent();

            // Create new instance of UC Data Holders
            currentScenario = new ScenarioContent();
            currentSettings = new SettingsContent();

            // Create new instances of UCs
            currentUCScenario = new UC_Scenario(this);
            currentUCSettings = new UC_Settings(this);
            currentUCTheaters = new UC_Theaters(this);
            currentUCRegions = new UC_Regions(this);
            currentUCResources = new UC_Resources(this);
            currentUCWM = new UC_WM(this);
            currentUCOrbat = new UC_Orbat(this);

            // Load UCs to mainUCPanel
            mainUCPanel.Controls.Add(currentUCScenario);
            mainUCPanel.Controls.Add(currentUCSettings);
            mainUCPanel.Controls.Add(currentUCTheaters);
            mainUCPanel.Controls.Add(currentUCRegions);
            mainUCPanel.Controls.Add(currentUCResources);
            mainUCPanel.Controls.Add(currentUCWM);
            mainUCPanel.Controls.Add(currentUCOrbat);

            // Load Scenario tab
            addUserControl(currentUCScenario);

            // Save original size
            currentEditorScale = Configuration.currentAppScaleFactor;
        }   

        #region generalWindowControls

        // Make window movable by grabbing toolbar
        private void toolbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // ... or titleLabel
        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // Check if status (enabled/disabled) was changed for any button
        // And update (invert) their status accordingly
        public void updateTabButtonsStatus()
        {
            if (Globals.isSettingsActive != tabSettingsBtn.Enabled) tabSettingsBtn.Enabled = !tabSettingsBtn.Enabled;
            if (Globals.isTheatersActive != tabTheatersBtn.Enabled) tabTheatersBtn.Enabled = !tabTheatersBtn.Enabled;
            if (Globals.isRegionsActive != tabRegionsBtn.Enabled) tabRegionsBtn.Enabled = !tabRegionsBtn.Enabled;
            if (Globals.isResourcesActive != tabResourcesBtn.Enabled) tabResourcesBtn.Enabled = !tabResourcesBtn.Enabled;
            if (Globals.isWMActive != tabWMBtn.Enabled) tabWMBtn.Enabled = !tabWMBtn.Enabled;
            if (Globals.isOrbatActive != tabOrbatBtn.Enabled) tabOrbatBtn.Enabled = !tabOrbatBtn.Enabled;
        }

        // Display new tab
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            
            foreach(Control c in mainUCPanel.Controls)
            {
                if (c is UserControl)
                    c.Visible = true;
                else
                    c.Visible = false;
            }

            userControl.BringToFront();
        }
        
        #endregion

        #region toolbarButtons

        // Exit button clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Info button clicked
        private void infoButton_Click(object sender, EventArgs e)
        {
            // Get assembly version
            string versionNumber = ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               : Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Display assembly version in message box
            _ = MessageBox.Show($"Current version: {versionNumber}\n" +
                $"Contributors: Michael '8', xperga", "About Editor", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsWindow sw = new settingsWindow(this);
            sw.ShowDialog();
        }

        #endregion

        #region tabsButtons

        // Tab buttons click event

        // tabScenario is public, so export button can work
        public void tabScenarioBtn_Click(object sender, EventArgs e) => addUserControl(currentUCScenario);

        private void tabSettingsBtn_Click(object sender, EventArgs e) => addUserControl(currentUCSettings);

        private void tabTheatersBtn_Click(object sender, EventArgs e) => addUserControl(currentUCTheaters);

        private void tabRegionsBtn_Click(object sender, EventArgs e) => addUserControl(currentUCRegions);

        private void tabResourcesBtn_Click(object sender, EventArgs e) => addUserControl(currentUCResources);

        private void tabWMBtn_Click(object sender, EventArgs e) => addUserControl(currentUCWM);

        private void tabOrbatBtn_Click(object sender, EventArgs e) => addUserControl(currentUCOrbat);

        #endregion

        #region Resize

        public void AdjustEditorSizeToScale()
        {
            // If size has changed
            if(currentEditorScale != Configuration.currentAppScaleFactor)
            {
                // Update saved current editor scale
                currentEditorScale = Configuration.currentAppScaleFactor;

                // Invert previous scale change and apply new ; scale = new * 1/previous
                float factor = Configuration.currentAppScaleFactor / Configuration.previousAppScaleFactor;
                SizeF fullScaleFactor = new SizeF(factor, factor);

                // Rescale window
                Scale(fullScaleFactor);

                // Change font scale of main window elements
                changeFontOfComponentsInContainer(toolbarPanel, factor);
                changeFontOfComponentsInContainer(tabsPanel, factor);

                // Change font scale of tabs content
                changeFontOfComponentsInContainer(currentUCScenario, factor);
                changeFontOfComponentsInContainer(currentUCSettings, factor);
                changeFontOfComponentsInContainer(currentUCTheaters, factor);
                changeFontOfComponentsInContainer(currentUCRegions, factor);
                changeFontOfComponentsInContainer(currentUCResources, factor);
                changeFontOfComponentsInContainer(currentUCWM, factor);
                changeFontOfComponentsInContainer(currentUCOrbat, factor);
            }
        }

        private void changeFontOfComponentsInContainer(Control component, float factor)
        {
            // Change font of every element in the window
            // Keep fontFamily and fontStyle
            foreach (Control c in component.Controls)
                c.Font = new Font(c.Font.FontFamily, c.Font.Size * factor, c.Font.Style);
        }

        #endregion
    }
}