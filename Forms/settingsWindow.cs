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

            // Set current scale value to trackScale
            trackScale.Value = convertScaleFactorToTrackValue(Configuration.currentAppScaleFactor);
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

        private void applyScaleButton_Click(object sender, System.EventArgs e)
        {
            // Update data on scale in Configuration
            Configuration.previousAppScaleFactor = Configuration.currentAppScaleFactor;
            Configuration.currentAppScaleFactor = convertTrackValueToScaleFactor(trackScale.Value);

            // Activate scale change globally
            mainWindow.AdjustScaleOfAllWindows();
        }
    }
}
