namespace SRScenarioCreatorEnhanced
{
    class LanguageData
    {
        public string languageName;

        #region SettingsSection

        public string generalInfo;
        public string startingDate;
        public string scenarioID;
        public string fastForwardDays;
        public string defaultRegion;

        public string difficulties;
        public string military;
        public string economic;
        public string diplomacy;

        public string aiSettings;
        public string aiStance;
        public string nukePenalty;
        public string approvalEffect;

        public string victoryConditions;
        public string gameLength;
        public string victory;
        public string victoryHex;
        public string victoryTech;

        public string startingConditions;
        public string initialFunds;
        public string resourcesLevel;

        public string graphicOptions;
        public string mapGUI;
        public string mapSplhash;
        public string mapMusic;

        public string miscellaneous;
        public string startingYear;
        public string techTreeDefault;
        public string regionAllies;
        public string regionAxis;
        public string sphereNN;

        public string scenarioOptions;
        public string fixedCapitals;
        public string criticalUN;
        public string allowNukes;
        public string alliedVictory;
        public string noStartingDebt;
        public string limitDAR;
        public string limitRegions;
        public string restrictTech;
        public string regionEquip;
        public string fastBuild;
        public string noLoyaltyPenalty;
        public string missileLimit;
        public string reserveLimit;
        public string groupLoyalty;
        public string groupResearch;
        public string limitMAR;
        public string noSphere;
        public string campaignGame;
        public string govChoice;
        public string relationsEff;

        public string undoReset;
        public string resetSettings;

        #endregion

        LanguageData()
        {
            generalInfo = "General Info";
            startingDate = "Starting Date";
            scenarioID = "Scenario ID";
            fastForwardDays = "Fast Forward Days";
            defaultRegion = "Default region";

            difficulties = "Difficulties";
            military = "Military";
            economic = "Economic";
            diplomacy = "Diplomacy";

            aiSettings = "AI Settings";
            aiStance = "AI Stance";
            nukePenalty = "Nuke Penalty";
            approvalEffect = "Approval Effect";

            victoryConditions = "Victory Conditions";
            gameLength = "Game Length";
            victory = "Victory";
            victoryHex = "Victory Hex";
            victoryTech = "Victory Tech";

            startingConditions = "Starting Conditions";
            initialFunds = "Initial Funds";
            resourcesLevel = "Resources Level";

            graphicOptions = "Graphic Options";
            mapGUI = "Map GUI";
            mapSplhash = "Map Splash";
            mapMusic = "Map Music";

            miscellaneous = "Miscellaneous";
            startingYear = "Starting Year";
            techTreeDefault = "Tech Tree Default";
            regionAllies = "Region Allies";
            regionAxis = "Region Axis";
            sphereNN = "Sphere NN";

            scenarioOptions = "Scenario Options";
            fixedCapitals = "Fixed Capitals";
            criticalUN = "Critical UN";
            allowNukes = "Allow Nukes";
            alliedVictory = "Allied Victory";
            noStartingDebt = "No Starting Debt";
            limitDAR = "Limit DAR Effect";
            limitRegions = "Limit Regions in Scenario";
            restrictTech = "Restrict Tech Trade";
            regionEquip = "Region Equip";
            fastBuild = "Fast Build";
            noLoyaltyPenalty = "No Loyalty Penalty";
            missileLimit = "Missile Limit";
            reserveLimit = "Reserve Limit";
            groupLoyalty = "Group Loalty Merge";
            groupResearch = "Group Research Merge";
            limitMAR = "Limit MAR Effect";
            noSphere = "No Sphere";
            campaignGame = "Campaign Game";
            govChoice = "Gov Choice";
            relationsEff = "3rd Party Relations Effect";

            undoReset = "UNDO RESET";
            resetSettings = "RESET SETTINGS TO DEFAULT";
        }
    }
}
