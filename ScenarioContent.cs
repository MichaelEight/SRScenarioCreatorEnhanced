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
        public string tempExportLocation;
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

        #region exportingTools
        // Clears file from all text (uses universal tempExportLocation!)
        private void clearFile(string fileLocation)
        {
            File.WriteAllText(fileLocation, ""); // Reset content of file
        }
        
        // Appends text to file (uses universal tempExportLocation!)
        private void writeToFile(string textToWrite)
        {
            if (!string.IsNullOrEmpty(tempExportLocation))
                File.AppendAllText(tempExportLocation, textToWrite);
            else
            {
                throw new Exception("Empty tempExportLocation");
            }
        }

        #endregion
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
            tempExportLocation = baseExportLocation + $"\\{scenarioName}.scenario";

            clearFile(tempExportLocation);

            writeToFile($"// SCENARIO DEFINITION - {scenarioName}\n");
            writeToFile($"// Created using Enhanced Scenario Creator V{editorVersion} - {DateTime.Now.ToString()}\n");
            writeToFile($"// ifset key: 0x01: Load CVP; 0x02: Load Rest of Source; 0x03: Load all; 0x04: Load Cache\n");
            writeToFile($"\n");
            
            writeToFile($"#ifset 0x01\n");
            writeToFile($"#include \"{CVPName}.CVP\", \"MAPS\\\"\n");
            writeToFile($"#include \"{CVPName}.REGIONINCL\", \"MAPS\\\"\n");
            writeToFile($"#include \"{ProfileName}.PRF\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#endifset\n");
            writeToFile($"\n");
            
            writeToFile($"#ifset 0x02\n");
            writeToFile($"#include \"{UnitName}.UNIT\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#include \"{PPLXName}.PPLX\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#include \"{TTRXName}.TTRX\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#include \"{TERXName}.TERX\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#include \"{WMName}.WMData\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#include \"{NewsItemsName}.NEWSIMTES\", \"MAPS\\DATA\\\"\n");
            writeToFile($"#include \"AllSourceLoad.INI\", \"INI\\\"\n");
            writeToFile($"#endifset\n");
            writeToFile($"\n");
            
            writeToFile($"#ifset 0x02\n");
            writeToFile($"&&MAP\n");
            writeToFile($"mapfile \"{scenarioName}\"\n");
            writeToFile($"&&MAP\n");
            writeToFile($"\n");
            
            writeToFile($"#include \"{OOFName}.OOF\", \"MAPS\\\"\n");
            writeToFile($"#include \"AllLoad.INI\", \"INI\\\"\n");
            writeToFile($"#include \"{OOBName}.OOB\", \"MAPS\\ORBATS\\\"\n");
            writeToFile($"#endifset\n");
            writeToFile($"\n");
            
            writeToFile($"#ifset 0x04\n");
            writeToFile($"&&SAV\n");
            writeToFile($"savfile \"{cacheName}\"\n");
            writeToFile($"&&END\n");
            writeToFile($"\n");
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