/// editorMainWindow.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using SRScenarioCreatorEnhanced.Forms;
using SRScenarioCreatorEnhanced.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        #region Variables

        // Use for editing scale of main window and UCs
        internal float currentEditorScale;
        internal float currentFontScale;

        // Data holders for UC Tabs
        internal ScenarioContent currentScenario;
        internal SettingsContent currentSettings;
        // ...

        // UC Tabs
        private UC_Scenario currentUCScenario;
        private UC_Settings currentUCSettings;
        private UC_Theaters currentUCTheaters;
        private UC_Regions currentUCRegions;
        private UC_Resources currentUCResources;
        private UC_WM currentUCWM;
        private UC_Orbat currentUCOrbat;

        // Language
        internal LanguageData currentLanguage;
        internal List<LanguageData> allLanguages;
        internal event EventHandler LanguageHasChanged;

        #endregion

        // Constructor
        public editorMainWindow()
        {
            InitializeComponent();

            // Language
            allLanguages = new List<LanguageData>();
            LoadLanguageDataFromFileToData();

            #region tabsAndTheirData

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

            #endregion

            // Load Scenario tab
            addUserControl(currentUCScenario);

            // Save original size
            currentEditorScale = Configuration.currentAppScaleFactor;

            // Adjust, load settings, reload -- such cycle does the job of loading settings
            // Probably because previous only then the size is saved as "previous", but tbh not sure XD ~M8, 2022/09/02 0:55
            AdjustEditorSizeToScale();
            LoadEditorSettingsFromFile();
            AdjustEditorSizeToScale();

            // Reload language to apply settings from file
            UpdateLanguageInEditor();

            UpdateComboListOnDirChange();

            currentUCScenario.ExportButtonEnabled += HandleExportButtonEnabled;
            currentUCScenario.ExportButtonDisabled += HandleExportButtonDisabled;
        }

        #region Language

        #region LoadingFromFile

        /// <summary>
        /// Load all language files from Lang\**-**.LANG
        /// Save text from them in allLanguages list (list of languages, each has own text list)
        /// </summary>
        private void LoadLanguageDataFromFileToData()
        {
            /// Directory example: Lang\en-US.LANG or Lang\pl-PL.LANG

            /// NOTE : Only Settings Tab lang data is done so far
            
            string langDir = Directory.GetCurrentDirectory() + @"\Lang";

            // Create dir if nonexistent
            if (!Directory.Exists(langDir))
            {
                Directory.CreateDirectory(langDir);
            }

            // Get list of all files
            string[] files = Directory.GetFiles(langDir);

            // Loop through them and load .lang ones
            foreach(string file in files)
            {
                if(Path.GetExtension(file) == ".LANG")
                {
                    string[] lines = File.ReadAllLines(file);
                    LanguageData tempLang = new LanguageData(); // Create temporary language var

                    // Try to load all texts, line by line
                    try
                    {
                        int lineIndex = 0;

                        LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.mainWindowSection);
                        LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.scenarioSection);
                        LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.settingsSection);

                        // TODO Unlock, when other tabs are made
                        //LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.);
                        //LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.);
                        //LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.);
                        //LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.);
                        //LoadLangSectionFromFile(lines, ref lineIndex, ref tempLang.);

                        // Remove all dir text but filename
                        tempLang.languageName = Path.GetFileNameWithoutExtension(file);

                        // Add this language to the general list
                        allLanguages.Add(tempLang);
                    }
                    catch(Exception e)
                    {
                        Debug.WriteLine(e.Message);
                        Info.errorMsg(5, $"Loading language {file}: missing lines");
                    }
                }
            }

            UpdateLanguageInEditor();
        }

        /// <summary>
        /// Load lines from file to specific section of LangData
        /// Ignore // as they're comments
        /// Load until all space in given section is taken
        /// </summary>
        private void LoadLangSectionFromFile(string[] lines, ref int lineIndex, ref string[] section)
        {
            // Go through lines in file, amount is set by length of section (array holding text)
            for (int langIndex = 0; langIndex < section.Length; ++lineIndex, ++langIndex)
            {
                // Ignore line, if it's a comment or is empty
                if (lines[lineIndex].Contains("//") || string.IsNullOrEmpty(lines[lineIndex]))
                {
                    --langIndex; // Don't count it as new lang line
                    continue;
                }

                section[langIndex] = lines[lineIndex];
            }
        }

        #endregion

        #region UpdatingLanguageInApp

        internal void UpdateLanguageInEditor()
        {
            if (Configuration.currentLanguage == "DEFAULT")
                currentLanguage = new LanguageData(); // Revert to default, hardcoded values
            
            // Loop through all loaded languages
            foreach(var language in allLanguages)
            {
                // Pick the one, which was selected in settings window
                if(language.languageName == Configuration.currentLanguage)
                {
                    currentLanguage = language;
                    break;
                }
            }

            // Send event
            if(LanguageHasChanged != null)
                LanguageHasChanged(this, EventArgs.Empty);

            // Update language in this window
            LoadCurrentLanguageToWindow();
        }

        /// <summary>
        /// Overwrites all current label texts with language data
        /// </summary>
        private void LoadCurrentLanguageToWindow()
        {
            // Start on the 1st and increment to go futher
            int langIndex = 0;

            titleLabel.Text                     = currentLanguage.mainWindowSection[langIndex++];
            tabScenarioBtn.Text                 = currentLanguage.mainWindowSection[langIndex++];
            tabSettingsBtn.Text                 = currentLanguage.mainWindowSection[langIndex++];
            tabTheatersBtn.Text                 = currentLanguage.mainWindowSection[langIndex++];
            tabRegionsBtn.Text                  = currentLanguage.mainWindowSection[langIndex++];
            tabResourcesBtn.Text                = currentLanguage.mainWindowSection[langIndex++];
            tabWMBtn.Text                       = currentLanguage.mainWindowSection[langIndex++];
            tabOrbatBtn.Text                    = currentLanguage.mainWindowSection[langIndex++];
            btnOpenExportedScenarioFolder.Text  = currentLanguage.mainWindowSection[langIndex++];
            exportScenarioButton.Text           = currentLanguage.mainWindowSection[langIndex];
        }

        #endregion

        #endregion

        #region LoadingDataIntoTabsAndComboboxes

        internal void UpdateComboListOnDirChange()
        {
            currentUCScenario.loadFileNamesToEachComponent();
        }

        /// <summary>
        /// Editor holds data in the back-end *Content files. Load that data into front-end UC_*
        /// Used by scenarioName change in UC_Scenario
        /// </summary>
        internal void LoadSavedDataIntoProperUCs()
        {
            // Move data on settings from placeholder to actual settings
            currentSettings = currentScenario.settings;
            
            // Load settings from saved data to it's UC
            currentUCSettings.LoadSavedDataIntoComponents();

            Globals.activeScenarioName = currentScenario.scenarioName;
            Globals.activeCVPFileName  = currentScenario.CVPName;
        }

        #endregion

        #region LoadingSavingEditorSettings

        private void LoadEditorSettingsFromFile()
        {
            // Load only if file exists -- stngs = settings
            if(File.Exists(Directory.GetCurrentDirectory() + @"\editor.stngs"))
            {
                List<string> lines = new List<string>(File.ReadAllLines(Directory.GetCurrentDirectory() + @"\editor.stngs"));

                lines.RemoveAll(string.IsNullOrWhiteSpace);

                // If all options are present and only them
                // HARDCODED COUNT NUMBER (!)
                if(lines.Count == 8)
                {
                    float helperFloat;
                    int helperInt;

                    Configuration.baseGameDirectory = lines[0];
                    Configuration.baseExportDirectory = lines[1];

                    if(float.TryParse(lines[2], out helperFloat)) Configuration.currentAppScaleFactor = helperFloat;
                    if(float.TryParse(lines[3], out helperFloat)) Configuration.previousAppScaleFactor = helperFloat;

                    if(float.TryParse(lines[4], out helperFloat)) Configuration.currentFontScaleFactor = helperFloat;
                    if(float.TryParse(lines[5], out helperFloat)) Configuration.previousFontScaleFactor = helperFloat;

                    if(Int32.TryParse(lines[6], out helperInt)) Configuration.settingsDebugLevel = helperInt;
                    Configuration.currentLanguage = lines[7];
                }
            }
            else // Else - generate the file
            {
                SaveEditorSettingsToFile();
            }
        }

        internal void SaveEditorSettingsToFile()
        {
            string directory = Directory.GetCurrentDirectory() + @"\editor.stngs";

            if (File.Exists(directory))
            {
                // Reset content of this file
                File.WriteAllText(directory, "");
            }

            // Input hard-coded scheme
            File.AppendAllLines(directory, new string[]{
                Configuration.baseGameDirectory,
                Configuration.baseExportDirectory,

                Configuration.currentAppScaleFactor.ToString(),
                Configuration.previousAppScaleFactor.ToString(),

                Configuration.currentFontScaleFactor.ToString(),
                Configuration.previousFontScaleFactor.ToString(),

                Configuration.settingsDebugLevel.ToString(),
                Configuration.currentLanguage
            });
        }

        #endregion

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
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            
            foreach(Control c in mainUCPanel.Controls)
            {
                if (c.Name == uc.Name)
                    c.Visible = true;
                else
                    c.Visible = false;
            }

            uc.BringToFront();
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
            aboutWindow aw = new aboutWindow();
            aw.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsWindow sw = new settingsWindow(this);
            sw.ShowDialog();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Algorithm Source: https://stackoverflow.com/a/71203963/12934099
            // Credit: Antonis
            var obj = Application.OpenForms.OfType<helpWindow>().Select(t => t).FirstOrDefault();
            if (obj != null)
            {
                obj.BringToFront();
            }
            else
            {
                obj = new helpWindow(this);
                obj.Show();
            }
        }

        #endregion

        #region tabsButtons

        // Tab buttons click event
        private void tabScenarioBtn_Click(object sender, EventArgs e) => addUserControl(currentUCScenario);

        private void tabSettingsBtn_Click(object sender, EventArgs e) => addUserControl(currentUCSettings);

        private void tabTheatersBtn_Click(object sender, EventArgs e) => addUserControl(currentUCTheaters);

        private void tabRegionsBtn_Click(object sender, EventArgs e) => addUserControl(currentUCRegions);

        private void tabResourcesBtn_Click(object sender, EventArgs e) => addUserControl(currentUCResources);

        private void tabWMBtn_Click(object sender, EventArgs e) => addUserControl(currentUCWM);

        private void tabOrbatBtn_Click(object sender, EventArgs e) => addUserControl(currentUCOrbat);

        #endregion

        #region Resize

        internal void AdjustEditorSizeToScale()
        {
            // If window size has changed
            if(currentEditorScale != Configuration.currentAppScaleFactor)
            {
                // Update saved current editor scale
                currentEditorScale = Configuration.currentAppScaleFactor;

                // Invert previous scale change and apply new ; scale = new * 1/previous
                float factor = Configuration.currentAppScaleFactor / Configuration.previousAppScaleFactor;
                SizeF fullScaleFactor = new SizeF(factor, factor);

                // Rescale window
                Scale(fullScaleFactor);
            }

            // If font size has changed
            if(currentFontScale != Configuration.currentFontScaleFactor)
            {
                // Update saved current editor scale
                currentFontScale = Configuration.currentFontScaleFactor;

                // Invert previous scale change and apply new ; scale = new * 1/previous
                float factor = Configuration.currentFontScaleFactor / Configuration.previousFontScaleFactor;

                // Change font scale of main window elements
                changeFontOfComponentsInContainer(toolbarPanel, factor);
                changeFontOfComponentsInContainer(tabsPanel, factor);
                changeFontOfComponentsInContainer(panelBottom, factor);

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

        #region Exporting
        private void HandleExportButtonEnabled(object sender, EventArgs e)
        {
            exportScenarioButton.Enabled = true;
        }
        private void HandleExportButtonDisabled(object sender, EventArgs e)
        {
            exportScenarioButton.Enabled = false;
        }

        private void exportScenarioButton_Click(object sender, EventArgs e)
        {
            // Copy settings data to scenario, prepare for export
            currentScenario.settings = currentSettings;

            currentScenario.exportScenarioToFileAndFolder();
            _ = MessageBox.Show("Scenario exported! (Well, editor tried, at least)", "Export Finished",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnOpenExportedScenarioFolder_Click(object sender, EventArgs e)
        {
            string folderPath = Configuration.baseExportDirectory;
            try
            {
                if (Directory.Exists(folderPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = folderPath,
                        FileName = "explorer.exe"
                    };

                    _ = Process.Start(startInfo);
                }
                else
                {
                    _ = MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
                }
            }
            catch (Exception err)
            {
                // Some error (exception) happened
                _ = MessageBox.Show(err.Message);
            }
        }

        #endregion
    }
}