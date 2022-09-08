/// ScenarioContent.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced
{
    public class ScenarioContent
    {
        #region setupVariablesAndConstructor

        #region editorInfo

        private string adjustedExportDirectory;

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
        public string lastLoadedScenarioName; // Used as anti-loop when trying to reload data in tab

        #endregion

        #region otherTabsContentObjects

        // Create instances of classes holding data on other tabs
        // SettingsContent currentSettings; // Do not load, if functionality not ready yet

        #endregion

        // Generate default data on creation
        public ScenarioContent()
        {
            settings = new SettingsContent();
            lastLoadedScenarioName = "-";

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
            // Check if export directory exists
            if (!Directory.Exists(Configuration.baseExportDirectory))
                Directory.CreateDirectory(Configuration.baseExportDirectory);

            try
            {
                // Save .scenario file
                exportScenarioFile();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Info.errorMsg(4, $"File already in use (bug). Retry! Exception:{e.Message}");
            }

            // Adjust export folder directory, connect it with scenario name
            adjustedExportDirectory = Configuration.baseExportDirectory + $"\\{scenarioName}\\Maps\\";

            // Check scenario folder and subfolders
            if(!Directory.Exists(adjustedExportDirectory))
                Directory.CreateDirectory(adjustedExportDirectory);

            if (!Directory.Exists(adjustedExportDirectory + @"Orbat"))
                Directory.CreateDirectory(adjustedExportDirectory + @"Orbat");

            if (!Directory.Exists(adjustedExportDirectory + @"Data"))
                Directory.CreateDirectory(adjustedExportDirectory + @"Data");
            
            // If "Create New Map" is checked
            if(newMapCheck)
            {
                string mapDir = adjustedExportDirectory + mapName + @".MAPX";
                string oofDir = adjustedExportDirectory + OOFName + @".OOF";

                if (File.Exists(mapDir))
                {
                    DialogResult dialogResult = MessageBox.Show("Map file with that name already exists in your scenario! " +
                        "If you press 'Yes', it will be overwritten! Proceed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(dialogResult == DialogResult.Yes)
                    {
                        File.Create(mapDir);
                    }
                }
                else
                {
                    File.Create(mapDir);
                }
                
                if (File.Exists(oofDir))
                {
                    DialogResult dialogResult = MessageBox.Show("OOF file with that name already exists in your scenario! " +
                        "If you press 'Yes', it will be overwritten! Proceed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(dialogResult == DialogResult.Yes)
                    {
                        File.Create(oofDir);
                    }
                }
                else
                {
                    File.Create(oofDir);
                }
            }

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
            string tempExportLocation = Configuration.baseExportDirectory + $"\\{scenarioName}.scenario";

            // If file doesn't exist
            if (!File.Exists(tempExportLocation))
            {
                // Create the file
                File.Create(tempExportLocation);
            }

            // Reset content of file
            File.WriteAllText(tempExportLocation, "");

            // Input hard-coded scheme
            File.AppendAllLines(tempExportLocation, new string[]{

                #region scenarioInfoPart

                $"// SCENARIO DEFINITION - {scenarioName}",
                $"// Created using Enhanced Scenario Creator V{Configuration.editorVersion}:{Configuration.assemblyVersion} - {DateTime.Now}",
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
                $"initialfunds:           {settings.initialFunds}",
                $"reservelimit:           {(settings.reserveLimit ? 1 : 0)}",
                $"aistance:               {settings.aistance}",
                $"startyear:              {settings.startYear}",
                $"techtreedefault:        {settings.techTreeDefault}",
                $"nocapitalmove:          {(settings.noCapitalMove ? 1 : 0)}",
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
            string scenarioDir = Configuration.baseGameDirectory + @"\Scenario\Custom\" + scenarioName + @".SCENARIO";

            // If Scenario\Custom doesn't exist, create it
            if (!Directory.Exists(Configuration.baseGameDirectory + @"\Scenario\Custom\"))
                Directory.CreateDirectory(Configuration.baseGameDirectory + @"\Scenario\Custom\");

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

                // Array used for temporary operations, to save memory
                string[] tempArray; 

                // Go through all lines
                foreach (var line in linesFromFile)
                {
                    // NOTE: Use index 1 for includes, mapfile and savfile, because data is inside the quotes
                    // .. However index 0 for settings, because there's no ' " ' char in there
                    
                    // Split line into parts with ' " ' char
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
                                saveValueToCorrectVariable(new string[] { tempArray[0] }, tempArray[1]);
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
                                    saveValueToCorrectVariable(new string[] { tempArray[0] }, "MAPX");
                                else // If it's not a map, it has to be cache
                                    saveValueToCorrectVariable(new string[] { tempArray[0] }, "CACHE");
                            }
                        }
                        // If there's no dot, it's correct, continue as normal
                        else
                        {
                            if (tempArray.Length >= 2) // Check to eliminate array overflow
                            {
                                // Check what option is in line and value between quotes to saving function
                                if (tempArray[0].Contains("mapfile"))
                                    saveValueToCorrectVariable(new string[] { tempArray[1] }, "MAPX");
                                else // If it's not a map, it has to be cache
                                    saveValueToCorrectVariable(new string[] { tempArray[1] }, "CACHE");
                            }
                        }
                    }

                    // If it's a setting line TODO
                    else
                    {
                        /// EXAMPLE LINE
                        /// difficulty:     2, 2, 2

                        // NOTE: Select element '0' because no quotes exist there

                        // Remove any kind of tabs and multispaces
                        tempArray[0] = Regex.Replace(tempArray[0].Replace("\t", ""), @"[ ]{2,}", "");
                        // Remove single spaces
                        tempArray[0] = tempArray[0].Replace(" ", "");

                        // Split by ':'
                        tempArray = tempArray[0].Split(':');

                        if (tempArray.Length >= 2) // Check to eliminate array overflow
                        {
                            string setting = tempArray[0];
                            // Split values by ','
                            string[] values = tempArray[1].Split(',');

                            // --DEBUG--
                            /*Debug.Print(setting + ":");
                            for(int i = 0; i < values.Length; i++)
                            {
                                Debug.Print(values[i]);
                            }
                            Debug.Print("-\n");*/
                            // --ENDDEBUG--

                            // Check if array is valid
                            if (values.Length >= 1 && values.Length <= 3)
                                saveValueToCorrectVariable(values,setting);
                            // ... array is invalid
                            else
                            {
                                Info.errorMsg(2,$"Too few or too much arguments for setting {setting}!");
                            }
                        }
                    }
                }
            }
            else
            {
                Info.errorMsg(0,"Failed to find that .scenario file!");
            }
        }

        /// <summary>
        /// Move value to the correct variable, found by label
        /// </summary>
        /// <param name="value">Value to be set into certain variable</param>
        /// <param name="label">Using that, find matching variable and set the value to it. Might be file extension.</param>
        private void saveValueToCorrectVariable(string[] value, string label)
        {
            int outVal1, outVal2, outVal3; // out value, used for string>>int conversion

            switch (label)
            {

                #region scenarioData

                case "CVP": CVPName = value[0]; break;
                case "REGIONINCL": regionInclName = value[0]; break;
                case "UNIT": UnitName = value[0]; break;
                case "PPLX": PPLXName = value[0]; break;
                case "TTRX": TTRXName = value[0]; break;
                case "TERX": TERXName = value[0]; break;
                case "NEWSITEMS": NewsItemsName = value[0]; break;
                case "OOB": OOBName = value[0]; break;
                case "PRF": ProfileName = value[0]; break;

                case "WMData":
                case "WMDATA":
                    WMName = value[0]; break;

                // Compatibility for original editor's bug - saving OOF as SAV
                // Possible, because .SAV is never used elsewhere
                case "SAV":
                case "OOF":
                    OOFName = value[0]; break;

                case "MAPX": mapName = value[0]; break;
                case "CACHE": cacheName = value[0]; break;

                // Ignore labels (they are not used and can't be edited within this editor)
                case "INI":
                case "csv":
                    break;

                #endregion

                #region settingsData

                // Special: Multi-param settings
                case "startymd":
                    if (value.Length >= 3)
                        settings.startymd = $"{value[0]}, {value[1]}, {value[2]}"; // Format: yyyy, MM, dd
                    break;
                case "difficulty":
                    if(value.Length >= 3)
                    {
                        if(Int32.TryParse(value[0], out outVal1)) settings.militaryDifficulty  = outVal1;
                        if(Int32.TryParse(value[1], out outVal2)) settings.economicDifficulty  = outVal2;
                        if(Int32.TryParse(value[2], out outVal3)) settings.diplomacyDifficulty = outVal3;
                    }
                    break;
                case "victoryhex":
                    if (value.Length >= 2)
                    {
                        if (Int32.TryParse(value[0], out outVal1)) settings.victoryHexX = outVal1;
                        if (Int32.TryParse(value[1], out outVal2)) settings.victoryHexY = outVal2;
                    }
                    break;
                // Special: No conversion needed
                case "scenarioid": settings.scenarioid = value[0]; break;

                // Normal cases
                case "defaultregion":      if(Int32.TryParse(value[0], out outVal1)) settings.defaultRegion    = outVal1;break;
                case "resources":          if(Int32.TryParse(value[0], out outVal1)) settings.resourcesLevel   = outVal1;break;
                case "initialfunds":       if(Int32.TryParse(value[0], out outVal1)) settings.initialFunds     = outVal1;break;
                case "aistance":           if(Int32.TryParse(value[0], out outVal1)) settings.aistance         = outVal1;break;
                case "startyear":          if(Int32.TryParse(value[0], out outVal1)) settings.startYear        = outVal1;break;
                case "techtreedefault":    if(Int32.TryParse(value[0], out outVal1)) settings.techTreeDefault  = outVal1;break;
                case "mapmusic":           if(Int32.TryParse(value[0], out outVal1)) settings.mapMusic         = outVal1;break;
                case "mapgui":             if(Int32.TryParse(value[0], out outVal1)) settings.mapGui           = outVal1;break;
                case "mapsplash":          if(Int32.TryParse(value[0], out outVal1)) settings.mapSplash        = outVal1;break;
                case "victorytech":        if(Int32.TryParse(value[0], out outVal1)) settings.victoryTech      = outVal1;break;
                case "regionallies":       if(Int32.TryParse(value[0], out outVal1)) settings.regionAllies     = outVal1;break;
                case "regionaxis":         if(Int32.TryParse(value[0], out outVal1)) settings.regionAxis       = outVal1;break;
                case "fastfwddays":        if(Int32.TryParse(value[0], out outVal1)) settings.fastFwdDays      = outVal1;break;
                case "svictorycond":       if(Int32.TryParse(value[0], out outVal1)) settings.sVictoryCond     = outVal1;break;
                case "gamelength":         if(Int32.TryParse(value[0], out outVal1)) settings.gameLength       = outVal1;break;
                case "approvaleff":        if(Int32.TryParse(value[0], out outVal1)) settings.approvalEff      = outVal1;break;
                case "wmdeff":             if(Int32.TryParse(value[0], out outVal1)) settings.wmdEff           = outVal1;break;
                case "spherenn":           if(Int32.TryParse(value[0], out outVal1)) settings.sphereNn         = outVal1;break;
                case "reservelimit":       settings.reserveLimit        = (value[0] == "1" ? true : false);break;
                case "nocapitalmove":      settings.noCapitalMove       = (value[0] == "1" ? true : false);break;
                case "regionequip":        settings.regionEquip         = (value[0] == "1" ? true : false);break;
                case "limitdareffect":     settings.limitDarEffect      = (value[0] == "1" ? true : false);break;
                case "limitmareffect":     settings.limitMarEffect      = (value[0] == "1" ? true : false);break;
                case "wminvolve":          settings.wmInvolve           = (value[0] == "1" ? true : false);break;
                case "wmduse":             settings.wmdUse              = (value[0] == "1" ? true : false);break;
                case "fastbuild":          settings.fastBuild           = (value[0] == "1" ? true : false);break;
                case "govchoice":          settings.govChoice           = (value[0] == "1" ? true : false);break;
                case "grouployaltymerge":  settings.groupLoyaltyMerge   = (value[0] == "1" ? true : false);break;
                case "groupresearchmerge": settings.groupResearchMerge  = (value[0] == "1" ? true : false);break;
                case "relationseffect":    settings.relationsEffect     = (value[0] == "1" ? true : false);break;
                case "limitinscenario":    settings.limitInScenario     = (value[0] == "1" ? true : false);break;
                case "campaigngame":       settings.campaignGame        = (value[0] == "1" ? true : false);break;
                case "missilenolimit":     settings.missileNoLimit      = (value[0] == "1" ? true : false);break;
                case "alliedvictory":      settings.alliedVictory       = (value[0] == "1" ? true : false);break;
                case "restricttechtrade":  settings.restrictTechTrade   = (value[0] == "1" ? true : false);break;
                case "debtfree":           settings.debtFree            = (value[0] == "1" ? true : false);break;
                case "noloypenalty":       settings.noLoyPenalty        = (value[0] == "1" ? true : false);break;
                case "nosphere":           settings.noSphere            = (value[0] == "1" ? true : false);break;

                #endregion

                default:
                    // DEBUG Display error if label doesn't match any variable
                    Info.errorMsg(3, $"No variable found for that label! ({label})");
                    break;
            }
        }

        #endregion
    }
}