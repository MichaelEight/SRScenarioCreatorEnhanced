/// LanguageData.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

namespace SRScenarioCreatorEnhanced
{
    class LanguageData
    {
        // TODO Settings Tab also needs to have comboboxes content translated
        // TODO Translate tab names and other buttons, settings

        public string languageName; // e.g. en-US, pl-PL etc.

        #region TextSections

        public string[] mainWindowSection = new string[10]; // 10 texts, file indexes 0-9
        public string[] scenarioSection   = new string[24]; // 24 texts
        public string[] settingsSection   = new string[54]; // 54 texts

        #endregion

        public LanguageData(string langName = "DEFAULT")
        {
            languageName = langName;
            int langIndex = 0;

            #region MainWindow

            mainWindowSection[langIndex++] = "Supreme Ruler Ultimate: Enhanced Scenario Editor";
            mainWindowSection[langIndex++] = "Scenario";
            mainWindowSection[langIndex++] = "Settings";
            mainWindowSection[langIndex++] = "Theaters";
            mainWindowSection[langIndex++] = "Regions";
            mainWindowSection[langIndex++] = "Resources";
            mainWindowSection[langIndex++] = "World Market";
            mainWindowSection[langIndex++] = "Orbat";
            mainWindowSection[langIndex++] = "Open Exported Scenario Folder";
            mainWindowSection[langIndex]   = "Export Scenario";

            #endregion

            #region ScenarioTab

            langIndex = 0;

            scenarioSection[langIndex++] = "General Information";
            scenarioSection[langIndex++] = "Scenario Name";
            scenarioSection[langIndex++] = "Cache Name";
            scenarioSection[langIndex++] = "Same as Scenario Name";
            scenarioSection[langIndex++] = "Non-editable Data Files";
            scenarioSection[langIndex++] = "Use Default Files";
            scenarioSection[langIndex++] = "UNIT";
            scenarioSection[langIndex++] = "PPLX";
            scenarioSection[langIndex++] = "TTRX";
            scenarioSection[langIndex++] = "TERX";
            scenarioSection[langIndex++] = "NEWSITEMS";
            scenarioSection[langIndex++] = "PROFILE";
            scenarioSection[langIndex++] = "Map Files";
            scenarioSection[langIndex++] = "Map Name";
            scenarioSection[langIndex++] = "OOF";
            scenarioSection[langIndex++] = "Create New Map";
            scenarioSection[langIndex++] = "Same as Map Name";
            scenarioSection[langIndex++] = "Editable Data Files";
            scenarioSection[langIndex++] = "CVP";
            scenarioSection[langIndex++] = "WMData";
            scenarioSection[langIndex++] = "OOB";
            scenarioSection[langIndex++] = "Pre-Cache";
            scenarioSection[langIndex++] = "Post Cache";
            scenarioSection[langIndex]   = "Modify";

            #endregion

            #region SettingsTab

            langIndex = 0;
            settingsSection[langIndex++] = "General Info";
            settingsSection[langIndex++] = "Starting Date";
            settingsSection[langIndex++] = "Scenario ID";
            settingsSection[langIndex++] = "Fast Forward Days";
            settingsSection[langIndex++] = "Default region";
            settingsSection[langIndex++] = "Difficulties";
            settingsSection[langIndex++] = "Military";
            settingsSection[langIndex++] = "Economic";
            settingsSection[langIndex++] = "Diplomacy";
            settingsSection[langIndex++] = "AI Settings";
            settingsSection[langIndex++] = "AI Stance";
            settingsSection[langIndex++] = "Nuke Penalty";
            settingsSection[langIndex++] = "Approval Effect";
            settingsSection[langIndex++] = "Victory Conditions";
            settingsSection[langIndex++] = "Game Length";
            settingsSection[langIndex++] = "Victory";
            settingsSection[langIndex++] = "Victory Hex";
            settingsSection[langIndex++] = "Victory Tech";
            settingsSection[langIndex++] = "Starting Conditions";
            settingsSection[langIndex++] = "Initial Funds";
            settingsSection[langIndex++] = "Resources Level";
            settingsSection[langIndex++] = "Graphic Options";
            settingsSection[langIndex++] = "Map GUI";
            settingsSection[langIndex++] = "Map Splash";
            settingsSection[langIndex++] = "Map Music";
            settingsSection[langIndex++] = "Miscellaneous";
            settingsSection[langIndex++] = "Starting Year";
            settingsSection[langIndex++] = "Tech Tree Default";
            settingsSection[langIndex++] = "Region Allies";
            settingsSection[langIndex++] = "Region Axis";
            settingsSection[langIndex++] = "Sphere NN";
            settingsSection[langIndex++] = "Scenario Options";
            settingsSection[langIndex++] = "Fixed Capitals";
            settingsSection[langIndex++] = "Critical UN";
            settingsSection[langIndex++] = "Allow Nukes";
            settingsSection[langIndex++] = "Allied Victory";
            settingsSection[langIndex++] = "No Starting Debt";
            settingsSection[langIndex++] = "Limit DAR Effect";
            settingsSection[langIndex++] = "Limit Regions in Scenario";
            settingsSection[langIndex++] = "Restrict Tech Trade";
            settingsSection[langIndex++] = "Region Equip";
            settingsSection[langIndex++] = "Fast Build";
            settingsSection[langIndex++] = "No Loyalty Penalty";
            settingsSection[langIndex++] = "Missile Limit";
            settingsSection[langIndex++] = "Reserve Limit";
            settingsSection[langIndex++] = "Group Loalty Merge";
            settingsSection[langIndex++] = "Group Research Merge";
            settingsSection[langIndex++] = "Limit MAR Effect";
            settingsSection[langIndex++] = "No Sphere";
            settingsSection[langIndex++] = "Campaign Game";
            settingsSection[langIndex++] = "Gov Choice";
            settingsSection[langIndex++] = "3rd Party Relations Effect";
            settingsSection[langIndex++] = "UNDO RESET";
            settingsSection[langIndex]   = "RESET SETTINGS TO DEFAULT";

            #endregion
        }

    }
}
