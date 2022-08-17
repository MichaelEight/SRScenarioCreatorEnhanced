namespace SRScenarioCreatorEnhanced
{
    public class ScenarioContent
    {
        // General Info
        public string scenarioName;
        public string cacheName;
        public bool cacheSameNameCheck;

        // Map Info
        public string mapName;
        public string OOFName;
        public bool newMapCheck;
        public bool OOFSameNameCheck;

        // Non-editable Data Info
        public string UnitName;
        public string PPLXName;
        public string TTRXName;
        public string TERXName;
        public string NewsItemsName;
        public string ProfileName;
        public bool allNonEditableDefaultCheck;

        // Editable Data Info
        public string CVPName;
        public string WMName;
        public string OOBName;
        public string PreCacheName;
        public string PostCacheName;
        public bool CVPModifyCheck;
        public bool WMModifyCheck;
        public bool OOBModifyCheck;

        // Generate default data on creation
        public ScenarioContent()
        {
            scenarioName = "";
            cacheName = scenarioName;
            cacheSameNameCheck = false;

            mapName = "";
            OOFName = mapName;
            OOFSameNameCheck = false;

            UnitName = "DEFAULT";
            PPLXName = "DEFAULT";
            TTRXName = "DEFAULT";
            TERXName = "DEFAULT";
            NewsItemsName = "DEFAULT";
            ProfileName = "DEFAULT";
            allNonEditableDefaultCheck = true; 

            CVPName = "";
            WMName = "";
            OOBName = "";
            PreCacheName = "";
            PostCacheName = "";
            CVPModifyCheck = false;
            WMModifyCheck = false;
            OOBModifyCheck = false;
        }
    }
}
