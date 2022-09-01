/// UC_Settings.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.UserControls
{
    public partial class UC_Settings : UserControl
    {
        private readonly editorMainWindow mainWindow;
        private DateTime debugInputChangedTime;
        public UC_Settings(editorMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            debugInputChangedTime = DateTime.Now;
        }

        #region LoadingDataToDisplay

        public void LoadSavedDataIntoComponents()
        {
            // Copy settings data to new var to simplify syntax
            SettingsContent sc = mainWindow.currentSettings;

            // General Info
            if (DateTime.TryParse(sc.startymd, out DateTime startymd)) dateStartingDate.Value = startymd;
                else Info.errorMsg(1,"Wrong startymd date format!");
            textScenarioID.Text = sc.scenarioid;
            updateNumericalContentWithCheck(numericFastForwardDays, sc.fastFwdDays,   0);
            updateNumericalContentWithCheck(numericDefaultRegion,   sc.defaultRegion, 1000);

            // Difficulties
            updateComboContentWithCheck(comboMilitaryDiff,     sc.militaryDifficulty,  2);
            updateComboContentWithCheck(comboEconomicDiff,     sc.economicDifficulty,  2);
            updateComboContentWithCheck(comboDiplomacyDiff,    sc.diplomacyDifficulty, 2);

            // AI Settings
            updateComboContentWithCheck(comboAiStance,         sc.aistance,     0);
            updateComboContentWithCheck(comboWMDEffect,        sc.wmdEff,       1);
            updateComboContentWithCheck(comboApprovalEffect,   sc.approvalEff,  2);

            // Victory Conditions
            updateComboContentWithCheck(comboGameLength,       sc.gameLength,   0);
            updateComboContentWithCheck(comboVictoryCondition, sc.sVictoryCond, 0);
            updateNumericalContentWithCheck(numericVictoryHexX, sc.victoryHexX, 0);
            updateNumericalContentWithCheck(numericVictoryHexY, sc.victoryHexY, 0);
            updateNumericalContentWithCheck(numericVictoryTech, sc.victoryTech, 0);

            // Starting Conditions
            updateComboContentWithCheck(comboInitialFunds,     sc.initialFunds,   2);
            updateComboContentWithCheck(comboResourcesLevel,   sc.resourcesLevel, 2);

            // Graphic Options
            updateComboContentWithCheck(comboMapGui, sc.mapGui, 2);
            updateNumericalContentWithCheck(numericMapSplash, sc.mapSplash, 0);
            textMapMusic.Text = sc.mapMusic.ToString();

            // Miscellaneous
            updateNumericalContentWithCheck(numericStartingYear, sc.startYear, 0);
            textTechTreeDefault.Text = sc.techTreeDefault.ToString();
            textRegionAllies.Text    = sc.regionAllies.ToString();
            textRegionAxis.Text      = sc.regionAxis.ToString();
            textSphereNN.Text        = sc.sphereNn.ToString();

            // Scenario Options (booleans)
            checkNoCapitalMove.Checked       = sc.noCapitalMove;
            checkWMinvolve.Checked           = sc.wmInvolve;
            checkWMDuse.Checked              = sc.wmdUse;
            checkAlliedVictory.Checked       = sc.alliedVictory;
            checkDebtFree.Checked            = sc.debtFree;
            checkLimitDAReffect.Checked      = sc.limitDarEffect;
            checkLimitInScenario.Checked     = sc.limitInScenario;
            checkRestrictTechTrade.Checked   = sc.restrictTechTrade;
            checkRegionEquip.Checked         = sc.regionEquip;
            checkFastBuild.Checked           = sc.fastBuild;
            checkNoLoyPenalty.Checked        = sc.noLoyPenalty;
            checkReserveLimit.Checked        = sc.reserveLimit;
            checkGroupLoyaltyMerge.Checked   = sc.groupLoyaltyMerge;
            checkGroupResearchMerge.Checked  = sc.groupResearchMerge;
            checkLimitMAReffect.Checked      = sc.limitMarEffect;
            checkNoSphere.Checked            = sc.noSphere;
            checkCampaignGame.Checked        = sc.campaignGame;
            checkGovChoice.Checked           = sc.govChoice;
            checkRelationsEffect.Checked     = sc.relationsEffect;
            checkMissileNoLimit.Checked      = !sc.missileNoLimit; // NOTE: Inverse because of wording
        }
        private void updateComboContentWithCheck(ComboBox targetCombo, int? fileData, int defaultIndex)
        {
            if (fileData != null)
                targetCombo.SelectedIndex = Convert.ToInt32(fileData);
            else targetCombo.SelectedIndex = defaultIndex; // DEFAULT
        }
        private void updateNumericalContentWithCheck(NumericUpDown targetNumeric, int? fileData, int defaultValue)
        {
            if (fileData != null)
                targetNumeric.Value = Convert.ToDecimal(fileData);
            else targetNumeric.Value = defaultValue; // DEFAULT
        }

        #endregion

        private void SettingsInputDataChanged(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - debugInputChangedTime;

            // Disallow changes faster than 1 per second
            // NOTE: Every change generates event ; this prevents lags and overuse of CPU
            //       Loading scenario also activates multiple events at once
            if (ts.TotalMilliseconds > 1000)
            {
                // Update timer
                debugInputChangedTime = DateTime.Now;

                
            }
        }
    }
}
