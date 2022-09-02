using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.Forms
{
    public partial class settingsWindow : Form
    {
        editorMainWindow mainWindow;
        public settingsWindow(editorMainWindow emw)
        {
            InitializeComponent();
            mainWindow = emw;

            textGameDirectory.Text = Configuration.baseGameDirectory;

            // Set saved values to sliders
            trackWindowScale.Value = convertScaleFactorToTrackValue(Configuration.currentAppScaleFactor);
            trackFontScale.Value = convertScaleFactorToTrackValue(Configuration.currentFontScaleFactor);
            trackDebugMsgsLevel.Value = Configuration.settingsDebugLevel;
        }

        #region Converters

        private float convertTrackValueToScaleFactor(int value)
        {
            switch (value)
            {
                case 0: return 0.5f;
                case 1: return 0.75f;
                case 2: return 1.0f;

                default: return 1.0f;
            }
        }
        private int convertScaleFactorToTrackValue(float factor)
        {
            switch (factor)
            {
                case 0.5f: return 0;
                case 0.75f: return 1;
                case 1.0f: return 2;

                default: return 2;
            }
        }

        #endregion

        private void buttonApply_Click(object sender, System.EventArgs e)
        {
            #region UpdateScale

            // Update data on app scale in Configuration, if different
            if (Configuration.currentAppScaleFactor != convertTrackValueToScaleFactor(trackWindowScale.Value))
            {
                Configuration.previousAppScaleFactor = Configuration.currentAppScaleFactor;
                Configuration.currentAppScaleFactor = convertTrackValueToScaleFactor(trackWindowScale.Value);
            }
            // Update data on font scale in Configuration, if different
            if (Configuration.currentFontScaleFactor != convertTrackValueToScaleFactor(trackFontScale.Value))
            {
                Configuration.previousFontScaleFactor = Configuration.currentFontScaleFactor;
                Configuration.currentFontScaleFactor = convertTrackValueToScaleFactor(trackFontScale.Value);
            }

            // Activate scale change globally
            mainWindow.AdjustEditorSizeToScale();

            #endregion

            // Change debug level
            switch(trackDebugMsgsLevel.Value)
            {
                case 0: // None
                    Info.loadingFilesError                   = false;
                    Info.loadingDataIntoTabsError            = false;
                    Info.loadingDataFromFileError            = false;
                    Info.failedToRecogniseLabelFromfileError = false;
                    Info.fileIsAlreadyInUseError             = false;
                    break;

                case 1: // Only Necessary (DEFAULT)
                    Info.loadingFilesError                   = true;
                    Info.loadingDataIntoTabsError            = true;
                    Info.loadingDataFromFileError            = false;
                    Info.failedToRecogniseLabelFromfileError = false;
                    Info.fileIsAlreadyInUseError             = true;
                    break;

                case 2: // All
                    Info.loadingFilesError                   = true;
                    Info.loadingDataIntoTabsError            = true;
                    Info.loadingDataFromFileError            = true;
                    Info.failedToRecogniseLabelFromfileError = true;
                    Info.fileIsAlreadyInUseError             = true;
                    break;

                default:break;
            }
            // Update setting in configuration
            Configuration.settingsDebugLevel = trackDebugMsgsLevel.Value;

            mainWindow.SaveEditorSettingsToFile();
        }

        private void buttonBrowseGameFolder_Click(object sender, System.EventArgs e)
        {
            // If path selected
            if (folderBrowserGameDirectory.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserGameDirectory.SelectedPath != Configuration.baseGameDirectory)
                {
                    // Update textbox
                    textGameDirectory.Text = folderBrowserGameDirectory.SelectedPath;

                    // Update game directory
                    Configuration.baseGameDirectory = folderBrowserGameDirectory.SelectedPath;

                    // Update export directory
                    Configuration.baseExportDirectory = Configuration.baseGameDirectory + @"\Scenario\Custom";

                    mainWindow.UpdateComboListOnDirChange();
                }
            }
        }
    }
}