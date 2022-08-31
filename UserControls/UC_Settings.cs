/// UC_Settings.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Settings : UserControl
    {
        private readonly editorMainWindow mainWindow;
        public UC_Settings(editorMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            // Event handling resize
            mainWindow.ResizeEvent += HandleResizeEvent;
        }

        #region Resizing

        public void HandleResizeEvent(object sender, EventArgs e)
        {
            AdjustWindowSizeToScale();
        }

        private void AdjustWindowSizeToScale()
        {
            foreach (Control c in Controls)
            {
                c.Font = new Font(Configuration.defaultEditorFontFamily,
                                 c.Font.Size * Configuration.currentAppScale.Width, FontStyle.Bold);
            }
        }

        #endregion
    }
}
