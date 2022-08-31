/// ScenarioContent.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced
{
    public class ScenarioContent
    {
        #region setupVariablesAndConstructor

        #region editorInfo

        // Current version of the editor
        private readonly string editorVersion = ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               : Assembly.GetExecutingAssembly().GetName().Version.ToString();

        // Set directory of export (default: editor's directory + "\Exported")
        private readonly string baseExportDirectory = Directory.GetCurrentDirectory() + @"\Exported";
        // Directory of SRU folder (TO AUTO/MANUAL CHANGE, TODO)
        private readonly string baseGameDirectory = @"I:\Steam Games\steamapps\common\Supreme Ruler Ultimate";
        // Return baseGameDirectory
        public string getBaseGameDirectory() { return baseGameDirectory; }
        public string getBaseExportDirectory() { return baseExportDirectory; }

        #endregion

        #region basicVars

        // General Info
        public string scenarioName;
        public string cacheName;
        public bool cacheSameNameCheck;
        public string regionInclName; // Not editable in editor, but used

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

        // Reference to Other Tabs' Content
        public SettingsContent settings;

        // DEBUG
        public string lastLoadedScenarioName; // Used as anti-loop when trying to reload tab
        public DateTime lastRescaled; // Anti-loop, allows to rescale with single tab reload

        #endregion

        #region otherTabsContentObjects

        // Create instances of classes holding data on other tabs
        // SettingsContent currentSettings; // Do not load, if functionality not ready yet

        #endregion

        // Generate default data on creation
        public ScenarioContent()
        {
            lastLoadedScenarioName = "-";
            lastRescaled = DateTime.Now;

            scenarioName = "";
            cacheName = scenarioName;
            regionInclName = scenarioName;
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
            OOBName = "DEFAULT";
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
            if (CVPModifyCheck)
            {
                exportCVPFile();
                exportRegionInclFile();
            }

            // Save .wmdata file (if modified)
            if (WMModifyCheck)
            {
                exportWMFile();
            }

            // Save .oob file (if modified)
            if (OOBModifyCheck)
            {
                exportOOBFile();
            }
        }

        // Exports data to .scenario file
        private void exportScenarioFile()
        {
            // Set file location and name
            string tempExportLocation = baseExportDirectory + $"\\{scenarioName}.scenario";

            // Reset content of file
            File.WriteAllText(tempExportLocation, "");

            // Input hard-coded scheme
            File.AppendAllLines(tempExportLocation, new string[]{

                #region scenarioInfoPart

                $"// SCENARIO DEFINITION - {scenarioName}",
                $"// Created using Enhanced Scenario Creator V{editorVersion} - {DateTime.Now}",
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
                $"#include \"{NewsItemsName}.NEWSITEMS\", \"MAPS\\DATA\\\"",
                $"#include \"AllSourceLoad.INI\", \"INI\\\"",
                $"#endifset\n",

                $"#ifset 0x02",
                $"&&MAP",
                $"mapfile \"{mapName}\"",
                $"&&MAP\n",

                $"#include \"{OOFName}.OOF\", \"MAPS\\\"",
                $"#include \"AllLoad.INI\", \"INI\\\"",
                $"#include \"{OOBName}.OOB\", \"MAPS\\ORBATS\\\"",
                string.IsNullOrEmpty(PreCacheName) ? null : $"#include \"{PreCacheName}\"", // Do not include, if empty
                $"#endifset\n",

                $"#ifset 0x04",
                $"&&SAV",
                $"savfile \"{cacheName}\"",
                $"&&END\n",

                string.IsNullOrEmpty(PostCacheName) ? null : $"#include \"{PostCacheName}\"\n", // Do not include, if empty

                $"#endifset\n",
                #endregion

                #region settingsInfoPart

                // () ? 1 : 0 converts True/False to 1/0
                $"&&GMC",
                $"startymd:               {settings.startymd}",
                $"defaultregion:          {settings.defaultRegion}",
                $"scenarioid:             {settings.scenarioid}",
                $"difficulty:             {settings.militaryDifficulty}, " +
                                        $"{settings.economicDifficulty}, " +
                                        $"{settings.diplomacyDifficulty}",
                $"resources:              {settings.resourcesLevel}",
                $"initialFunds:           {settings.initialFunds}",
                $"reservelimit:           {(settings.reserveLimit ? 1 : 0)}",
                $"aistance:               {settings.aistance}",
                $"startyear:              {settings.startYear}",
                $"techtreedefault:        {settings.techTreeDefault}",
                $"noCapitalMove:          {(settings.noCapitalMove ? 1 : 0)}",
                $"regionequip:            {(settings.regionEquip ? 1 : 0)}",
                $"limitdareffect:         {(settings.limitDarEffect ? 1 : 0)}",
                $"limitmareffect:         {(settings.limitMarEffect ? 1 : 0)}",
                $"wminvolve:              {(settings.wmInvolve ? 1 : 0)}",
                $"wmduse:                 {(settings.wmdUse ? 1 : 0)}",
                $"fastbuild:              {(settings.fastBuild ? 1 : 0)}",
                $"govchoice:              {(settings.govChoice ? 1 : 0)}",
                $"grouployaltymerge:      {(settings.groupLoyaltyMerge ? 1 : 0)}",
                $"groupresearchmerge:     {(settings.groupResearchMerge ? 1 : 0)}",
                $"relationseffect:        {(settings.relationsEffect ? 1 : 0)}",
                $"limitinscenario:        {(settings.limitInScenario ? 1 : 0)}",
                $"mapmusic:               {settings.mapMusic}",
                $"mapgui:                 {settings.mapGui}",
                $"mapsplash:              {settings.mapSplash}",
                $"campaigngame:           {(settings.campaignGame ? 1 : 0)}",
                $"victoryhex:             {settings.victoryHexX}, " +
                                        $"{settings.victoryHexY}",
                $"victorytech:            {settings.victoryTech}",
                $"regionallies:           {settings.regionAllies}",
                $"regionaxis:             {settings.regionAxis}",
                $"fastfwddays:            {settings.fastFwdDays}",
                $"svictorycond:           {settings.sVictoryCond}",
                $"gamelength:             {settings.gameLength}",
                $"missilenolimit:         {(settings.missileNoLimit ? 1 : 0)}",
                $"alliedvictory:          {(settings.alliedVictory ? 1 : 0)}",
                $"restricttechtrade:      {(settings.restrictTechTrade ? 1 : 0)}",
                $"approvaleff:            {settings.approvalEff}",
                $"wmdeff:                 {settings.wmdEff}",
                $"debtfree:               {(settings.debtFree ? 1 : 0)}",
                $"noloypenalty:           {(settings.noLoyPenalty ? 1 : 0)}",
                $"nosphere:               {(settings.noSphere ? 1 : 0)}",
                $"spherenn:               {settings.sphereNn}",
                $"scenarioid:             {settings.scenarioid}",
                $"&&END"

                #endregion

            });
        }
        private void exportRegionInclFile()
        {
            throw new NotImplementedException();
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

        #region loadingDataFromFile

        /// <summary>
        /// Load scenario file, get all lines, extract necessary data and save it to variables
        /// </summary>
        /// <param name="scenarioName">Name of .scenario file to load</param>
        public void loadDataFromScenarioFileToActiveScenario(string scenarioName)
        {
            string scenarioDir = baseGameDirectory + @"\Scenario\Custom\" + scenarioName + @".SCENARIO";

            // Check if that scenario exists
            if (File.Exists(scenarioDir))
            {
                // Load content (lines) of .scenario file and put them into List<string>
                List<string> linesFromFile = new List<string>(File.ReadAllLines(scenarioDir));

                // Eliminate empty lines
                _ = linesFromFile.RemoveAll(string.IsNullOrWhiteSpace);

                // Eliminate lines with comments, &&-tags and ifsets
                _ = linesFromFile.RemoveAll(u => u.Contains("//") || u.Contains("&&") || u.Contains("ifset"));

                // Make a list with all the lines containing "#include"
                List<string> linesContainingInclude = new List<string>();

                string[] tempArray; // array for temporary operations

                // Go through all lines
                foreach (var line in linesFromFile)
                {
                    // Split line into parts with ' " ' char
                    // NOTE: Use index 1 for includes, mapfile and savfile, because data is inside the quotes
                    // .. However index 0 for settings, because there's no ' " ' char in there
                    tempArray = line.Split('"');

                    // If it's an '#include' line
                    if (line.Contains("#include"))
                    {
                        /// EXAMPLE LINE
                        /// #include "W2020.CVP", "MAPS\"

                        if (tempArray.Length >= 2) // Check to eliminate array overflow
                        {
                            // Select content in the quotes and split file name from extension
                            tempArray = tempArray[1].Split('.');

                            if (tempArray.Length >= 2) // Check to eliminate array overflow
                            {
                                // So elements of tempArray are 0) fileName and 1) fileExtension
                                saveValueToCorrectVariable(tempArray[0], tempArray[1]);
                            }
                        }
                    }

                    // If it's a 'mapfile' or 'savfile' line
                    else if (line.Contains("mapfile") || line.Contains("savfile"))
                    {
                        /// EXAMPLE LINE
                        /// mapfile "GC2020"

                        // Fix for .SAV still appearing in comboboxes, despite forbidden words remover
                        // If there's a dot (it shouldn't be)
                        if (tempArray[1].Contains("."))
                        {
                            tempArray = tempArray[1].Split('.');

                            if (tempArray.Length >= 2) // Check to eliminate array overflow
                            {
                                if (line.Contains("mapfile"))
                                    saveValueToCorrectVariable(tempArray[0], "MAPX");
                                else // If it's not a map, it has to be cache
                                    saveValueToCorrectVariable(tempArray[0], "CACHE");
                            }
                        }
                        // If there's no dot, it's correct, continue as normal
                        else
                        {
                            if (tempArray.Length >= 2) // Check to eliminate array overflow
                            {
                                // Check what option is in line and value between quotes to saving function
                                if (tempArray[0].Contains("mapfile"))
                                    saveValueToCorrectVariable(tempArray[1], "MAPX");
                                else // If it's not a map, it has to be cache
                                    saveValueToCorrectVariable(tempArray[1], "CACHE");
                            }
                        }
                    }

                    // If it's a setting line TODO
                    else
                    {
                        /// EXAMPLE LINE
                        /// difficulty:     2, 2, 2

                    }
                }
            }
            else
            {
                // Error, file not found
                if (Configuration.enableLoadingfilesErrorMessageBoxes)
                {
                    _ = MessageBox.Show("Failed to find that .scenario file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Move value to the correct variable, found by label
        /// </summary>
        /// <param name="value">Value to be set into certain variable</param>
        /// <param name="label">Using that, find matching variable and set the value to it. Might be file extension.</param>
        private void saveValueToCorrectVariable(string value, string label)
        {
            switch (label)
            {
                case "CVP": CVPName = value; break;
                case "REGIONINCL": regionInclName = value; break;
                case "UNIT": UnitName = value; break;
                case "PPLX": PPLXName = value; break;
                case "TTRX": TTRXName = value; break;
                case "TERX": TERXName = value; break;
                case "NEWSITEMS": NewsItemsName = value; break;
                case "OOB": OOBName = value; break;
                case "PRF": ProfileName = value; break;

                case "WMData":
                case "WMDATA":
                    WMName = value; break;

                // Compatibility for original editor's bug - saving OOF as SAV
                // Possible, because .SAV is never used elsewhere
                case "SAV":
                case "OOF":
                    OOFName = value; break;

                case "MAPX": mapName = value; break;
                case "CACHE": cacheName = value; break;

                // Ignore labels (they are not used and can't be edited within this editor)
                case "INI":
                case "csv":
                    break;

                default:
                    {
                        // DEBUG Display error if label doesn't match any variable
                        if (Configuration.enableLoadingfilesErrorMessageBoxes)
                        {
                            _ = MessageBox.Show($"Error! No variable found for that label! ({label})", "Error!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }
            }
        }

        #endregion
    }
}