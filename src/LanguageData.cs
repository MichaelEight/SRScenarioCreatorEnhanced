/// LanguageData.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

namespace SRScenarioCreatorEnhanced
{
    class LanguageData
    {
        public string languageName; // e.g. en-US, pl-PL etc.

        #region SettingsSection

        public string[] settingsSection = new string[54]; // 0 - 54

        #endregion

        public LanguageData(string langName = "DEFAULT")
        {
            languageName = langName;

            #region SettingsTab

            settingsSection[0] = "General Info";
            settingsSection[1] = "Starting Date";
            settingsSection[2] = "Scenario ID";
            settingsSection[3] = "Fast Forward Days";
            settingsSection[4] = "Default region";
            settingsSection[5] = "Difficulties";
            settingsSection[6] = "Military";
            settingsSection[7] = "Economic";
            settingsSection[8] = "Diplomacy";
            settingsSection[9] = "AI Settings";
            settingsSection[10] = "AI Stance";
            settingsSection[11] = "Nuke Penalty";
            settingsSection[12] = "Approval Effect";
            settingsSection[13] = "Victory Conditions";
            settingsSection[14] = "Game Length";
            settingsSection[15] = "Victory";
            settingsSection[16] = "Victory Hex";
            settingsSection[17] = "Victory Tech";
            settingsSection[18] = "Starting Conditions";
            settingsSection[19] = "Initial Funds";
            settingsSection[20] = "Resources Level";
            settingsSection[21] = "Graphic Options";
            settingsSection[22] = "Map GUI";
            settingsSection[23] = "Map Splash";
            settingsSection[24] = "Map Music";
            settingsSection[25] = "Miscellaneous";
            settingsSection[26] = "Starting Year";
            settingsSection[27] = "Tech Tree Default";
            settingsSection[28] = "Region Allies";
            settingsSection[29] = "Region Axis";
            settingsSection[30] = "Sphere NN";
            settingsSection[31] = "Scenario Options";
            settingsSection[32] = "Fixed Capitals";
            settingsSection[33] = "Critical UN";
            settingsSection[34] = "Allow Nukes";
            settingsSection[35] = "Allied Victory";
            settingsSection[36] = "No Starting Debt";
            settingsSection[37] = "Limit DAR Effect";
            settingsSection[38] = "Limit Regions in Scenario";
            settingsSection[39] = "Restrict Tech Trade";
            settingsSection[40] = "Region Equip";
            settingsSection[41] = "Fast Build";
            settingsSection[42] = "No Loyalty Penalty";
            settingsSection[43] = "Missile Limit";
            settingsSection[44] = "Reserve Limit";
            settingsSection[45] = "Group Loalty Merge";
            settingsSection[46] = "Group Research Merge";
            settingsSection[47] = "Limit MAR Effect";
            settingsSection[48] = "No Sphere";
            settingsSection[49] = "Campaign Game";
            settingsSection[50] = "Gov Choice";
            settingsSection[51] = "3rd Party Relations Effect";
            settingsSection[52] = "UNDO RESET";
            settingsSection[53] = "RESET SETTINGS TO DEFAULT";

            #endregion
        }

    }
}
