using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Reflection;

namespace SRScenarioCreatorEnhanced
{
    public class ScenarioContent
    {
        #region setupVariablesAndConstructor

        // Editor info
        public string baseExportLocation = Directory.GetCurrentDirectory() + "\\Exported";
        private string editorVersion = ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               : Assembly.GetExecutingAssembly().GetName().Version.ToString();

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

        #endregion

        #region exportingScenarioToFiles

        public void exportScenarioToFileAndFolder()
        {
            // Save .scenario file
            exportScenarioFile();

            // Save .cvp file (if modified)
            if(CVPModifyCheck)
            {
                exportCVPFile();
            }

            // Save .wmdata file (if modified)
            if(WMModifyCheck)
            {
                exportWMFile();
            }

            // Save .oob file (if modified)
            if(OOBModifyCheck)
            {
                exportOOBFile();
            }
        }

        // Exports data to .scenario file
        private void exportScenarioFile()
        {
            // Set file location and name
            string tempExportLocation = baseExportLocation + $"\\{scenarioName}.scenario";

            // Reset content of file
            File.WriteAllText(tempExportLocation, "");

            // Input hard-coded scheme
            File.AppendAllLines(tempExportLocation, new string[]{
                $"// SCENARIO DEFINITION - {scenarioName}",
                $"// Created using Enhanced Scenario Creator V{editorVersion} - {DateTime.Now.ToString()}",
                $"// ifset key: 0x01: Load CVP; 0x02: Load Rest of Source; 0x03: Load all; 0x04: Load Cache\n",

                $"#ifset 0x01",
                $"#include \"{CVPName}.CVP\", \"MAPS\\\"",
                $"#include \"{CVPName}.REGIONINCL\", \"MAPS\\\"",
                $"#include \"{ProfileName}.PRF\", \"MAPS\\DATA\\\"",
                $"#endifset\n",

                $"#ifset 0x02",
                $"#include \"{UnitName}.UNIT\", \"MAPS\\DATA\\\"",
                $"#include \"{PPLXName}.PPLX\", \"MAPS\\DATA\\\"",
                $"#include \"{TTRXName}.TTRX\", \"MAPS\\DATA\\\"",
                $"#include \"{TERXName}.TERX\", \"MAPS\\DATA\\\"",
                $"#include \"{WMName}.WMData\", \"MAPS\\DATA\\\"",
                $"#include \"{NewsItemsName}.NEWSIMTES\", \"MAPS\\DATA\\\"",
                $"#include \"AllSourceLoad.INI\", \"INI\\\"",
                $"#endifset\n",

                $"#ifset 0x02",
                $"&&MAP",
                $"mapfile \"{scenarioName}\"",
                $"&&MAP\n",

                $"#include \"{OOFName}.OOF\", \"MAPS\\\"",
                $"#include \"AllLoad.INI\", \"INI\\\"",
                $"#include \"{OOBName}.OOB\", \"MAPS\\ORBATS\\\"",
                $"#endifset\n",

                $"#ifset 0x04",
                $"&&SAV",
                $"savfile \"{cacheName}\"",
                $"&&END\n"
            });
        }

        private void exportOOBFile()
        {
            throw new NotImplementedException();
        }

        private void exportWMFile()
        {
            throw new NotImplementedException();
        }

        private void exportCVPFile()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}