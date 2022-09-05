using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.Forms
{
    public partial class helpWindow : Form
    {
        // Access to main editor window
        editorMainWindow mainWindow;

        public helpWindow(editorMainWindow emw)
        {
            InitializeComponent();

            mainWindow = emw;
        }
    }
}
