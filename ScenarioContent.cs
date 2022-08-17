using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRScenarioCreatorEnhanced
{
    class ScenarioContent
    {
        // General Info
        public string scenarioName;
        public string cacheName;

        // Map Info
        public string mapName;
        public string OOFName;

        // Non-editable Data Info
        public string UnitName;
        public string PPLXName;
        public string TTRXName;
        public string TERXName;
        public string NewsItemsName;
        public string ProfileName;

        // Editable Data Info
        public string CVPName;
        public string WMName;
        public string OOBName;
        public string PreCacheName;
        public string PostCacheName;
    }
}
