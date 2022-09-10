/// UC_Regions.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Regions : UserControl
    {
        private readonly editorMainWindow mainForm;
        //RegionsContent rc;

        public UC_Regions(editorMainWindow mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            //rc = new RegionsContent();
            //rc.LoadDataFromFileToDataSet();

            //countryListDataGridView.DataSource = mainForm.currentRegions.countryList;
            //RefreshDataGridView();
        }

        internal void RefreshDataGridView()
        {
            countryListDataGridView.DataSource = mainForm.currentRegions.countryList;
            countryListDataGridView.Refresh();
        }
    }
}
