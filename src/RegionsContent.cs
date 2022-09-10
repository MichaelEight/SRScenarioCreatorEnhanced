/// RegionsContent.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using SRScenarioCreatorEnhanced.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SRScenarioCreatorEnhanced
{
    public class RegionsContent
    {
        #region Variables

        #region EditorVars

        int countryID; // Also a Country Data, but used as general ID
        internal cvpFile.CountryListDataTable countryList;
        string[] reservedLabels = { "regionname"};

        #endregion

        #region CountryData

        string regionname;
        string   prefixname;
        string   altregionname;
        int?     blocknum;
        int?     altblocknum;
        int?     continentnum;
        int?     flagnum;
        int?     musictrack;
        string   regioncolor;
        int?     politic;
        int?     govtype;
        double?  refpopulation;
        double?  poptotalarmy;
        double?  popminreserve;
        double?  treasury;
        double?  nationaldebtgdp;
        double?  techlevel;
        double?  civapproval;
        double?  milapproval;
        double?  fanaticism;
        int?     defcon;
        double?  loyalty;
        int?     playeragenda;
        int?     playeraistance;
        string   worldavail;
        string   armsavail;
        double?  worldintegrity;
        double?  treatyintegrity;
        double?  envrating;
        double?  milsubsidyrating;
        double?  domsubsidyrating;
        double?  creditrating;
        double?  tourismrating;
        double?  literacy;
        double?  lifeexp;
        double?  avgchildren;
        double?  crimerate;
        double?  unemployment;
        double?  gdpc;
        double?  inflation;
        double?  buyingpower;
        double?  prodefficiency;
        int?     alertlevel;
        bool     bwmmember;
        int?     religionstate;
        bool     bconscript;
        bool     forcesplan;
        double?  milspendsalary;
        double?  milspendmaint;
        double?  milspendintel;
        double?  milspendresearch;
        int?     RacePrimary;
        int?     RaceSecondary;
        int?     capitalx;
        int?     capitaly;
        bool     masterdata;
        bool     nonplayable;
        double?  influence;
        double?  influenceval;
        double?  couppossibility;
        double?  revoltpossibility;
        double?  independencedesire;
        double?  parentloyalty;
        double?  independencetarget;
        double?  sphere;
        double?  civiliansphere;
        bool     keepregion;
        int?     parentregion;
        int?     theatrehome;
        DateTime electiondate;

        // Groups of IDs
        string  grouping;
        string  regiontechs;
        string  regionunitdesign;
        string  regionsocials;
        string  regionreligions;

        #endregion

        #endregion

        // Set default values
        public RegionsContent()
        {
            countryID = 0;
            countryList = new cvpFile.CountryListDataTable();

            regionname          = "";
            prefixname          = "";
            altregionname       = "";
            blocknum            = 0;
            altblocknum         = null;
            continentnum        = 0;
            flagnum             = 0;
            musictrack          = 0;
            regioncolor         = "";
            politic             = 0;
            govtype             = 0;
            refpopulation       = 0;
            poptotalarmy        = 0;
            popminreserve       = 0;
            treasury            = null;
            nationaldebtgdp     = null;
            techlevel           = 0;
            civapproval         = 0;
            milapproval         = null;
            fanaticism          = 0;
            defcon              = 0;
            loyalty             = null;
            playeragenda        = 0;
            playeraistance      = 0;
            worldavail          = "";
            armsavail           = "";
            worldintegrity      = 0;
            treatyintegrity     = null;
            envrating           = 0;
            milsubsidyrating    = null;
            domsubsidyrating    = null;
            creditrating        = 0;
            tourismrating       = null;
            literacy            = 0;
            lifeexp             = 0;
            avgchildren         = null;
            crimerate           = 0;
            unemployment        = 0;
            gdpc                = 0;
            inflation           = null;
            buyingpower         = null;
            prodefficiency      = null;
            alertlevel          = 0;
            bwmmember           = false;
            religionstate       = null;
            bconscript          = false;
            forcesplan          = false;
            milspendsalary      = null;
            milspendmaint       = null;
            milspendintel       = null;
            milspendresearch    = null;
            RacePrimary         = 0;
            RaceSecondary       = 0;
            capitalx            = null;
            capitaly            = null;
            masterdata          = false;
            nonplayable         = false;
            influence           = 0;
            influenceval        = 0;
            couppossibility     = 0;
            revoltpossibility   = 0;
            independencedesire  = 0;
            parentloyalty       = 0;
            independencetarget  = null;
            sphere              = 0;
            civiliansphere      = 0;
            keepregion          = false;
            parentregion        = null;
            theatrehome         = 0;
            electiondate        = DateTime.Now;

            grouping            = "";
            regiontechs         = "";
            regionunitdesign    = "";
            regionsocials       = "";
            regionreligions     = "";
        }
    
        public void LoadDataFromFileToDataSet()
        {
            #region DetermineCVPPAth

            // Potential paths
            string fileInScenarioFolderDir = Configuration.baseExportDirectory + @"\" + Globals.activeScenarioName
                                            + @"\Maps\" + Globals.activeCVPFileName + @".CVP";
            string fileInDefaultGameFolderDir = Configuration.baseGameDirectory + @"\Maps\" + Globals.activeCVPFileName + @".CVP";
            // Final path of the CVP file
            string cvpDir;

            // Open file (from scenario folder if it exists there, else refer to \Maps in gameDir)
            if (File.Exists(fileInScenarioFolderDir))
            {
                cvpDir = fileInScenarioFolderDir;
                Debug.WriteLine($"Found in scenario: {cvpDir}");
            }
            // If the file doesn't exist in scenario folder, check for it in game folder with default files
            else if(File.Exists(fileInDefaultGameFolderDir))
            {
                cvpDir=fileInDefaultGameFolderDir;
                Debug.WriteLine($"Found in defaults: {cvpDir}");
            }
            // If the file doesn't exist in either of these places, it doesn't exist
            // TODO Alternative: Look for the file in the whole game folder
            else
            {
                // Stop loading
                Debug.WriteLine("Not found at all. Tried both\n{0}\nand\n{1} paths.", fileInScenarioFolderDir, fileInDefaultGameFolderDir);
                return;
            }

            #endregion

            #region HandleBasicConditionsOfLoad

            // Load lines
            //
            List<string> lines = new List<string>(File.ReadAllLines(cvpDir));
            Debug.WriteLine($"Lines loaded, count: {lines.Count}");

            // Eliminate useless lines
            //
            // Remove all comments (everything after and including "//")
            lines = lines.Select(p => (!string.IsNullOrEmpty(p) && p.Contains("//")) ? p.Substring(0, p.IndexOf("//")) : p).ToList(); 
            // Remove all spaces and blank lines
            lines.RemoveAll(string.IsNullOrWhiteSpace);
            Debug.WriteLine($"Whitespaces removed, count: {lines.Count}");

            // Ignore theatres
            //
            if (lines.Contains("&&THEATRES") && lines.Contains("&&END"))
            {
                Debug.WriteLine($"Theatres found");
                // Start at the "&&THEATRES" keyword
                // End at the "&&END" keyword
                // Remove all the lines inbetween

                int theatreIndex = lines.IndexOf("&&THEATRES");
                int endIndex = lines.IndexOf("&&END") + 1; // +1 to include &&END
                Debug.WriteLine($"start/end theatre indexes: {theatreIndex}/{endIndex}");

                // Need to add 1 to index diff to remove the end line as well
                lines.RemoveRange(theatreIndex, endIndex - theatreIndex + 1);
                Debug.WriteLine($"Count after removing theatres: {lines.Count}");
            }

            #endregion

            #region LoadActualData

            // Load each country
            //
            // Row holding data on country
            cvpFile.CountryListRow row;

            int numberOfCountries = 0;

            // Count number of countries, so you know how many to expect
            foreach(string line in lines)
                if (line.Contains("&&CVP")) ++numberOfCountries;

            Debug.WriteLine($"Number of countries: {numberOfCountries}");

            // Load until there are no more countries
            while (numberOfCountries > 0)
            {
                // Generate new, empty row
                row = countryList.NewCountryListRow();

                // For distinguishing &&CVP - is it start or the end
                bool isCVPLabelStartOfCountry = true;

                // Get next line of country
                foreach (string line in lines)
                {
                    // Special Cases
                    if(line.Contains("&&CVP"))
                    {
                        if (isCVPLabelStartOfCountry)
                            isCVPLabelStartOfCountry = false;
                        else
                        {
                            // If that &&CVP marks the end,
                            // Get it's index
                            int endIndex = lines.IndexOf(line);
                            // And remove every line before it
                            lines.RemoveRange(0, endIndex);
                            // And restart the interpreter
                            break;
                        }
                    }

                    string tempLine = line; // Using temp, because 'line' is non-modifiable
                    string label = null;
                    string[] values;

                    // Interpret label -- identify which command is it
                    // Compare label to the complete list of commands (reserved labels)
                    foreach (string rl in reservedLabels)
                    {
                        if (tempLine.Contains(rl))
                        {
                            label = rl;
                            break;
                        }
                    }

                    // If label was not identified
                    if (label == null)
                    {
                        // Skip this line
                        continue;
                    }

                    // Removes label from line
                    tempLine.Substring(label.Length - 1);

                    // Remove spaces, tabs, multispaces
                    tempLine = Regex.Replace(line.Replace("\t", ""), @"[ ]{2,}", "");
                    tempLine.Replace(" ", "");

                    // Split values by ',' (most doesn't have it, so after split use index 0)
                    //values = tempLine.Split(',');
                    // Loading might not include splittig data, because DB doesn't support it (single-var column)
                    values = new string[] { tempLine };

                    // Convert values string >> target_type
                    // ...

                    // Assign value to matching label in row
                    row[label] = values[0]; // 0 for now, because it's single

                    // IF (maybe put that on top) line contains sets (GROUPING, REGIONTECHS etc.) 
                    // THEN loop through it, save as... idk... maybe create new DB type to hold that?
                    // IF encountered next CVP or EOF, remove everything up to here and repeat
                }

                row["CountryID"] = numberOfCountries; // DEBUG
                countryList.Rows.Add(row);
                numberOfCountries--;
            }

            #endregion

            // Placeholder Code (!)
            /*cvpFile.CountryListRow row;

            for(int i = 0; i < 10; ++i)
            {
                row = countryList.NewCountryListRow();

                row["CountryID"] = 1000 + i;
                row["regionname"] = new string('A', i);
                row["blocknum"] = (1000 + i) / 100; // ignore last 2 digits

                countryList.Rows.Add(row);
            }*/
        }
    }
}


// Ideas for load to-components and from-components
// Load-to : select row and go textRegionName.Text = r["regionname"] etc.
// Load-from : create new row and go r["regionname"] = textRegionName.Text etc.
// You can add those lines to the end of DB, because on the Editor list they can be sorted, and in the final file
//  order doesn't matter

/*cvpFile.CountryListRow row = countryList.NewCountryListRow();

row["CountryID"]    = 1106;
row["regionname"]   = "Poland";
row["blocknum"]     = 11;

countryList.Rows.Add(row);

foreach(DataRow r in countryList.Rows)
{
    Debug.WriteLine($"[{r["CountryID"]}] is named {r["regionname"]} " +
        $"and it's blocknum is {r["blocknum"]}");
}*/