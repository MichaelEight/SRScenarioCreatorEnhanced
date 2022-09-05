using System;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.Forms
{
    public partial class helpWindow : Form
    {
        // Access to main editor window
        editorMainWindow mainWindow;
        Panel mainPanel;

        public helpWindow(editorMainWindow emw, Panel mucp)
        {
            InitializeComponent();

            mainWindow = emw;
            mainPanel = mucp;

            mainWindow.TabChanged += HandleTabChanged;
        }

        private void HandleTabChanged(object sender, EventArgs e)
        {
            foreach(UserControl c in mainPanel.Controls)
            {
                MessageBox.Show(c.Name + "-" + c.Visible);
            }
        }
    }
}
