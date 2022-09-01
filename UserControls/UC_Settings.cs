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

        SettingsContent backupForUndo;

        public UC_Settings(editorMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            // Reset indexes, so no -1s appear
            ResetContentOfComponents();

            debugInputChangedTime = DateTime.Now;
        }

        /// <summary>
        /// Reset content of all components in tab to start over
        /// or to eliminate -1 indexes
        /// </summary>
        private void ResetContentOfComponents()
        {
            dateStartingDate.Value       = DateTime.Now;
            textScenarioID.Text          = "";
            numericFastForwardDays.Value = 0;
            numericDefaultRegion.Value   = 0;

            comboMilitaryDiff.SelectedIndex  = 0;
            comboEconomicDiff.SelectedIndex  = 0;
            comboDiplomacyDiff.SelectedIndex = 0;

            comboAiStance.SelectedIndex       = 0;
            comboWMDEffect.SelectedIndex      = 0;
            comboApprovalEffect.SelectedIndex = 0;

            comboGameLength.SelectedIndex       = 0;
            comboVictoryCondition.SelectedIndex = 0;
            numericVictoryHexX.Value            = 0;
            numericVictoryHexY.Value            = 0;
            numericVictoryTech.Value            = 0;

            comboInitialFunds.SelectedIndex   = 0;
            comboResourcesLevel.SelectedIndex = 0;

            comboMapGui.SelectedIndex = 0;
            numericMapSplash.Value    = 0;
            numericMapMusic.Value     = 0;

            numericStartingYear.Value = 0;
            textTechTreeDefault.Text  = "";
            textRegionAllies.Text     = "";
            textRegionAxis.Text       = "";
            textSphereNN.Text         = "";

            checkNoCapitalMove.Checked      = false;
            checkWMinvolve.Checked          = false;
            checkWMDuse.Checked             = false;
            checkAlliedVictory.Checked      = false;
            checkDebtFree.Checked           = false;
            checkLimitDAReffect.Checked     = false;
            checkLimitInScenario.Checked    = false;
            checkRestrictTechTrade.Checked  = false;
            checkRegionEquip.Checked        = false;
            checkFastBuild.Checked          = false;
            checkNoLoyPenalty.Checked       = false;
            checkReserveLimit.Checked       = false;
            checkGroupLoyaltyMerge.Checked  = false;
            checkGroupResearchMerge.Checked = false;
            checkLimitMAReffect.Checked     = false;
            checkNoSphere.Checked           = false;
            checkCampaignGame.Checked       = false;
            checkGovChoice.Checked          = false;
            checkRelationsEffect.Checked    = false;
            checkMissileNoLimit.Checked     = false;

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
            updateNumericalContentWithCheck(numericMapMusic, sc.mapMusic, 0);

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

        #region SavingSettingsFromTabToData

        private void SettingsInputValuesChanged(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - debugInputChangedTime;

            // Disallow changes faster than 1 per second
            // NOTE: Every change generates event ; this prevents lags and overuse of CPU
            //       Loading scenario also activates multiple events at once
            if (ts.TotalMilliseconds > 1000)
            {
                // Update timer
                debugInputChangedTime = DateTime.Now;

                SettingsContent sc = new SettingsContent();

                // General Info
                sc.startymd = dateStartingDate.Value.ToString("yyyy, MM, dd");
                sc.defaultRegion = (int)numericDefaultRegion.Value;
                sc.scenarioid = textScenarioID.Text;
                sc.fastFwdDays = (int)numericFastForwardDays.Value;
                
                // Difficulties
                sc.militaryDifficulty  = comboMilitaryDiff.SelectedIndex;
                sc.economicDifficulty  = comboEconomicDiff.SelectedIndex;
                sc.diplomacyDifficulty = comboDiplomacyDiff.SelectedIndex;

                // AI Settings
                sc.aistance    = comboAiStance.SelectedIndex;
                sc.wmdEff      = comboWMDEffect.SelectedIndex;
                sc.approvalEff = comboApprovalEffect.SelectedIndex;

                // Victory Conditions
                sc.gameLength   = comboGameLength.SelectedIndex;
                sc.sVictoryCond = comboVictoryCondition.SelectedIndex;
                sc.victoryHexX  = (int)numericVictoryHexX.Value;
                sc.victoryHexY  = (int)numericVictoryHexY.Value;
                sc.victoryTech  = (int)numericVictoryTech.Value;

                // Starting Conditions
                sc.initialFunds   = comboInitialFunds.SelectedIndex;
                sc.resourcesLevel = comboResourcesLevel.SelectedIndex;

                // Graphic Options
                sc.mapGui = comboMapGui.SelectedIndex;
                sc.mapSplash = (int)numericMapSplash.Value;
                sc.mapMusic  = (int)numericMapMusic.Value;

                // Miscellaneous
                sc.startYear        = (int)numericStartingYear.Value;

                UpdateDataWithCheck(ref sc.techTreeDefault, textTechTreeDefault);
                UpdateDataWithCheck(ref sc.regionAllies,    textRegionAllies);
                UpdateDataWithCheck(ref sc.regionAxis,      textRegionAxis);
                UpdateDataWithCheck(ref sc.sphereNn,        textSphereNN);

                // Scenario Options (booleans)
                sc.reserveLimit         = checkReserveLimit.Checked;
                sc.noCapitalMove        = checkNoCapitalMove.Checked;
                sc.regionEquip          = checkRegionEquip.Checked;
                sc.limitDarEffect       = checkLimitDAReffect.Checked;
                sc.limitMarEffect       = checkLimitMAReffect.Checked;
                sc.wmInvolve            = checkWMinvolve.Checked;
                sc.wmdUse               = checkWMDuse.Checked;
                sc.fastBuild            = checkFastBuild.Checked;
                sc.govChoice            = checkGovChoice.Checked;
                sc.groupLoyaltyMerge    = checkGroupLoyaltyMerge.Checked;
                sc.groupResearchMerge   = checkGroupResearchMerge.Checked;
                sc.relationsEffect      = checkRelationsEffect.Checked;
                sc.limitInScenario      = checkLimitInScenario.Checked;
                sc.campaignGame         = checkCampaignGame.Checked;
                sc.alliedVictory        = checkAlliedVictory.Checked;
                sc.restrictTechTrade    = checkRestrictTechTrade.Checked;
                sc.debtFree             = checkDebtFree.Checked;
                sc.noLoyPenalty         = checkNoLoyPenalty.Checked;
                sc.noSphere             = checkNoSphere.Checked;
                sc.missileNoLimit       = !checkMissileNoLimit.Checked;

                // Move data to main holder
                mainWindow.currentSettings = sc;
            }
        }

        void UpdateDataWithCheck(ref int? dataVar, TextBox sourceText)
        {
            if (Int32.TryParse(sourceText.Text, out int result))
                dataVar = result;
            else
                dataVar = null;
        }

        #endregion

        #region ResetUndoResetButtons

        private void buttonResetSettings_Click(object sender, EventArgs e)
        {
            #region CreateBackupForUndo

            SettingsContent sc = new SettingsContent();

            // General Info
            sc.startymd = dateStartingDate.Value.ToString("yyyy, MM, dd");
            sc.defaultRegion = (int)numericDefaultRegion.Value;
            sc.scenarioid = textScenarioID.Text;
            sc.fastFwdDays = (int)numericFastForwardDays.Value;

            // Difficulties
            sc.militaryDifficulty = comboMilitaryDiff.SelectedIndex;
            sc.economicDifficulty = comboEconomicDiff.SelectedIndex;
            sc.diplomacyDifficulty = comboDiplomacyDiff.SelectedIndex;

            // AI Settings
            sc.aistance = comboAiStance.SelectedIndex;
            sc.wmdEff = comboWMDEffect.SelectedIndex;
            sc.approvalEff = comboApprovalEffect.SelectedIndex;

            // Victory Conditions
            sc.gameLength = comboGameLength.SelectedIndex;
            sc.sVictoryCond = comboVictoryCondition.SelectedIndex;
            sc.victoryHexX = (int)numericVictoryHexX.Value;
            sc.victoryHexY = (int)numericVictoryHexY.Value;
            sc.victoryTech = (int)numericVictoryTech.Value;

            // Starting Conditions
            sc.initialFunds = comboInitialFunds.SelectedIndex;
            sc.resourcesLevel = comboResourcesLevel.SelectedIndex;

            // Graphic Options
            sc.mapGui = comboMapGui.SelectedIndex;
            sc.mapSplash = (int)numericMapSplash.Value;
            sc.mapMusic = (int)numericMapMusic.Value;

            // Miscellaneous
            sc.startYear = (int)numericStartingYear.Value;

            UpdateDataWithCheck(ref sc.techTreeDefault, textTechTreeDefault);
            UpdateDataWithCheck(ref sc.regionAllies, textRegionAllies);
            UpdateDataWithCheck(ref sc.regionAxis, textRegionAxis);
            UpdateDataWithCheck(ref sc.sphereNn, textSphereNN);

            // Scenario Options (booleans)
            sc.reserveLimit = checkReserveLimit.Checked;
            sc.noCapitalMove = checkNoCapitalMove.Checked;
            sc.regionEquip = checkRegionEquip.Checked;
            sc.limitDarEffect = checkLimitDAReffect.Checked;
            sc.limitMarEffect = checkLimitMAReffect.Checked;
            sc.wmInvolve = checkWMinvolve.Checked;
            sc.wmdUse = checkWMDuse.Checked;
            sc.fastBuild = checkFastBuild.Checked;
            sc.govChoice = checkGovChoice.Checked;
            sc.groupLoyaltyMerge = checkGroupLoyaltyMerge.Checked;
            sc.groupResearchMerge = checkGroupResearchMerge.Checked;
            sc.relationsEffect = checkRelationsEffect.Checked;
            sc.limitInScenario = checkLimitInScenario.Checked;
            sc.campaignGame = checkCampaignGame.Checked;
            sc.alliedVictory = checkAlliedVictory.Checked;
            sc.restrictTechTrade = checkRestrictTechTrade.Checked;
            sc.debtFree = checkDebtFree.Checked;
            sc.noLoyPenalty = checkNoLoyPenalty.Checked;
            sc.noSphere = checkNoSphere.Checked;
            sc.missileNoLimit = !checkMissileNoLimit.Checked;

            backupForUndo = sc;

            #endregion

            ResetContentOfComponents();

            buttonUndoReset.Enabled = true;
        }

        private void buttonUndoReset_Click(object sender, EventArgs e)
        {
            #region LoadBackup

            // General Info
            if (DateTime.TryParse(backupForUndo.startymd, out DateTime startymd)) dateStartingDate.Value = startymd;
            //else Info.errorMsg(1, "Wrong startymd date format!");
            textScenarioID.Text = backupForUndo.scenarioid;
            updateNumericalContentWithCheck(numericFastForwardDays, backupForUndo.fastFwdDays, 0);
            updateNumericalContentWithCheck(numericDefaultRegion, backupForUndo.defaultRegion, 1000);

            // Difficulties
            updateComboContentWithCheck(comboMilitaryDiff, backupForUndo.militaryDifficulty, 2);
            updateComboContentWithCheck(comboEconomicDiff, backupForUndo.economicDifficulty, 2);
            updateComboContentWithCheck(comboDiplomacyDiff, backupForUndo.diplomacyDifficulty, 2);

            // AI Settings
            updateComboContentWithCheck(comboAiStance, backupForUndo.aistance, 0);
            updateComboContentWithCheck(comboWMDEffect, backupForUndo.wmdEff, 1);
            updateComboContentWithCheck(comboApprovalEffect, backupForUndo.approvalEff, 2);

            // Victory Conditions
            updateComboContentWithCheck(comboGameLength, backupForUndo.gameLength, 0);
            updateComboContentWithCheck(comboVictoryCondition, backupForUndo.sVictoryCond, 0);
            updateNumericalContentWithCheck(numericVictoryHexX, backupForUndo.victoryHexX, 0);
            updateNumericalContentWithCheck(numericVictoryHexY, backupForUndo.victoryHexY, 0);
            updateNumericalContentWithCheck(numericVictoryTech, backupForUndo.victoryTech, 0);

            // Starting Conditions
            updateComboContentWithCheck(comboInitialFunds, backupForUndo.initialFunds, 2);
            updateComboContentWithCheck(comboResourcesLevel, backupForUndo.resourcesLevel, 2);

            // Graphic Options
            updateComboContentWithCheck(comboMapGui, backupForUndo.mapGui, 2);
            updateNumericalContentWithCheck(numericMapSplash, backupForUndo.mapSplash, 0);
            updateNumericalContentWithCheck(numericMapMusic, backupForUndo.mapMusic, 0);

            // Miscellaneous
            updateNumericalContentWithCheck(numericStartingYear, backupForUndo.startYear, 0);
            textTechTreeDefault.Text = backupForUndo.techTreeDefault.ToString();
            textRegionAllies.Text = backupForUndo.regionAllies.ToString();
            textRegionAxis.Text = backupForUndo.regionAxis.ToString();
            textSphereNN.Text = backupForUndo.sphereNn.ToString();

            // Scenario Options (booleans)
            checkNoCapitalMove.Checked = backupForUndo.noCapitalMove;
            checkWMinvolve.Checked = backupForUndo.wmInvolve;
            checkWMDuse.Checked = backupForUndo.wmdUse;
            checkAlliedVictory.Checked = backupForUndo.alliedVictory;
            checkDebtFree.Checked = backupForUndo.debtFree;
            checkLimitDAReffect.Checked = backupForUndo.limitDarEffect;
            checkLimitInScenario.Checked = backupForUndo.limitInScenario;
            checkRestrictTechTrade.Checked = backupForUndo.restrictTechTrade;
            checkRegionEquip.Checked = backupForUndo.regionEquip;
            checkFastBuild.Checked = backupForUndo.fastBuild;
            checkNoLoyPenalty.Checked = backupForUndo.noLoyPenalty;
            checkReserveLimit.Checked = backupForUndo.reserveLimit;
            checkGroupLoyaltyMerge.Checked = backupForUndo.groupLoyaltyMerge;
            checkGroupResearchMerge.Checked = backupForUndo.groupResearchMerge;
            checkLimitMAReffect.Checked = backupForUndo.limitMarEffect;
            checkNoSphere.Checked = backupForUndo.noSphere;
            checkCampaignGame.Checked = backupForUndo.campaignGame;
            checkGovChoice.Checked = backupForUndo.govChoice;
            checkRelationsEffect.Checked = backupForUndo.relationsEffect;
            checkMissileNoLimit.Checked = !backupForUndo.missileNoLimit; // NOTE: Inverse because of wording

            #endregion

            buttonUndoReset.Enabled = false;
        }

        #endregion
    }
}
