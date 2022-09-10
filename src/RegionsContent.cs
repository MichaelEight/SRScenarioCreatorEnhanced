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

        int selectedCountryID; // ID of country selected to edit
        internal cvpFile.CountryListDataTable countryList;

        // Labels used in CVP file, used to determine command
        // Warning! Order matters! "regionname" will be detected in "altregionname" as substring
        // 2022/09/10 11:51 am -- sorted descending by length
        string[] reservedLabels = { "independencetarget",
                                    "independencedesire",
                                    "revoltpossibility",
                                    "milsubsidyrating",
                                    "milspendresearch",
                                    "domsubsidyrating",
                                    "treatyintegrity",
                                    "nationaldebtgdp",
                                    "couppossibility",
                                    "prodefficiency",
                                    "worldintegrity",
                                    "playeraistance",
                                    "milspendsalary",
                                    "civiliansphere",
                                    "tourismrating",
                                    "religionstate",
                                    "refpopulation",
                                    "popminreserve",
                                    "parentloyalty",
                                    "milspendmaint",
                                    "milspendintel",
                                    "altregionname",
                                    "RaceSecondary",
                                    "unemployment",
                                    "poptotalarmy",
                                    "playeragenda",
                                    "parentregion",
                                    "influenceval",
                                    "electiondate",
                                    "creditrating",
                                    "continentnum",
                                    "theatrehome",
                                    "regioncolor",
                                    "nonplayable",
                                    "milapproval",
                                    "civapproval",
                                    "buyingpower",
                                    "avgchildren",
                                    "altblocknum",
                                    "RacePrimary",
                                    "worldavail",
                                    "regionname",
                                    "prefixname",
                                    "musictrack",
                                    "masterdata",
                                    "keepregion",
                                    "forcesplan",
                                    "fanaticism",
                                    "bconscript",
                                    "alertlevel",
                                    "techlevel",
                                    "influence",
                                    "inflation",
                                    "envrating",
                                    "crimerate",
                                    "bwmmember",
                                    "armsavail",
                                    "treasury",
                                    "literacy",
                                    "capitaly",
                                    "capitalx",
                                    "blocknum",
                                    "politic",
                                    "loyalty",
                                    "lifeexp",
                                    "govtype",
                                    "flagnum",
                                    "sphere",
                                    "defcon",
                                    "gdpc"
        };

        #endregion

        #region CountryData

        string   regionname;
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
            selectedCountryID = 0;
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

        #region LoadingFromFile

        internal void LoadDataFromFileToDataSet()
        {
            // Clear DB on load
            countryList.Clear();

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
            }
            // If the file doesn't exist in scenario folder, check for it in game folder with default files
            else if(File.Exists(fileInDefaultGameFolderDir))
            {
                cvpDir=fileInDefaultGameFolderDir;
            }
            // If the file doesn't exist in either of these places, it doesn't exist
            // TODO Alternative: Look for the file in the whole game folder
            else
            {
                // Stop loading
                return;
            }

            #endregion

            #region HandleBasicConditionsOfLoad

            // Load lines
            //
            List<string> lines = new List<string>(File.ReadAllLines(cvpDir));

            // Eliminate useless lines
            //
            // Remove all comments (everything after and including "//")
            lines = lines.Select(p => (!string.IsNullOrEmpty(p) && p.Contains("//")) ? p.Substring(0, p.IndexOf("//")) : p).ToList(); 
            // Remove all spaces and blank lines
            lines.RemoveAll(string.IsNullOrWhiteSpace);

            // Ignore theatres
            //
            if (lines.Contains("&&THEATRES") && lines.Contains("&&END"))
            {
                // Start at the "&&THEATRES" keyword
                // End at the "&&END" keyword
                // Remove all the lines inbetween

                int theatreIndex = lines.IndexOf("&&THEATRES");
                int endIndex = lines.IndexOf("&&END") + 1; // +1 to include &&END

                // Need to add 1 to index diff to remove the end line as well
                lines.RemoveRange(theatreIndex, endIndex - theatreIndex);
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

            // Load until there are no more countries
            while (numberOfCountries > 0)
            {
                // Generate new, empty row
                row = countryList.NewCountryListRow();

                // For distinguishing &&CVP - is it start or the end
                bool isCVPLabelStartOfCountry = true;

                // Does loading go through a section e.g. RegionTechs?
                // GROUPING, REGIONTECHS, REGIONUNITDESIGNS, REGIONPRODUCTS, REGIONSOCIALS, REGIONRELIGIONS
                string activeSectionGroup = null;

                // Get next line of country
                foreach (string line in lines)
                {
                    string tempLine = line; // Using temp, because 'line' is non-modifiable
                    string label = null;

                    #region SpecialCasesCVPandSections

                    // IF encountered next CVP or EOF, remove everything up to here and repeat
                    if (tempLine.Contains("&&CVP"))
                    {
                        // Reset sections indicator
                        activeSectionGroup = null;

                        // Determine if it's starting or ending CVP
                        if (isCVPLabelStartOfCountry)
                        {
                            isCVPLabelStartOfCountry = false;

                            // Remove useless chars
                            tempLine = RemoveSpecifiedCharsFromLine(tempLine);

                            // Detect CountryID 
                            tempLine = tempLine.Substring("&&CVP".Length);

                            // Assign number from line to id
                            Int32.TryParse(tempLine, out int result);
                            row["CountryID"] = result;

                            continue; // Skip the rest 
                        }
                        else
                        {
                            // If that &&CVP marks the end,
                            // Get it's index
                            int endIndex = lines.IndexOf(tempLine);
                            // And remove every line before it
                            lines.RemoveRange(0, endIndex);
                            // And restart the interpreter
                            break;
                        }
                    }

                    // Check if line indicates start of some section
                    string sectionDeterminer = null;
                    switch (tempLine)
                    {
                        case string a when a.Contains("&&GROUPING"):            sectionDeterminer = "grouping"; break;
                        case string a when a.Contains("&&REGIONTECHS"):         sectionDeterminer = "regiontechs"; break;
                        case string a when a.Contains("&&REGIONUNITDESIGNS"):   sectionDeterminer = "regionunitdesigns"; break;
                        case string a when a.Contains("&&REGIONPRODUCTS"):      sectionDeterminer = "regionproducts"; break;
                        case string a when a.Contains("&&REGIONSOCIALS"):       sectionDeterminer = "regionsocials"; break;
                        case string a when a.Contains("&&REGIONRELIGIONS"):     sectionDeterminer = "regionreligions"; break;

                        default: sectionDeterminer = null; break;
                    }

                    // If it was null so far and now it got updated
                    if(sectionDeterminer != null)
                    {
                        // Update column label to load into
                        activeSectionGroup = sectionDeterminer;
                        // Skip further analysis
                        continue;
                    }

                    // Loop through active sections
                    if (activeSectionGroup != null)
                    {
                        // Keep adding values to string row[activesectiongroup] += this
                        row[activeSectionGroup] += tempLine;

                        // Skip analysis
                        continue;
                    }

                    #endregion

                    #region InterpretLabel

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

                    #endregion

                    #region RemoveSpecifiedCharsAndLabel

                    tempLine = RemoveSpecifiedCharsFromLine(tempLine);

                    // Remove quotes
                    tempLine = tempLine.Replace("\"", "");

                    // Remove command (label) from line
                    tempLine = tempLine.Substring(label.Length);

                    #endregion

                    // (OBSOLETE) Split values by ',' (most doesn't have it, so after split use index 0)
                    //values = tempLine.Split(',');
                    // Loading might not include splittig data, because DB doesn't support it (single-var column)

                    // Try loading given label
                    try
                    {
                        // Value can't be null for conversion
                        if (!string.IsNullOrEmpty(tempLine) && !string.IsNullOrWhiteSpace(tempLine))
                        {
                            // Convert value: string >> target_type
                            // Get type used by this column (label)
                            Type type = countryList.Columns[label].DataType;

                            // Convert value to expected type
                            // Assign value to matching label in row
                            if(type == typeof(Boolean))
                            {
                                row[label] = tempLine == "1" ? true : false;
                            }
                            else if(type == typeof(Double))
                            {
                                Double.TryParse(tempLine, out double result);
                                row[label] = result;
                            }
                            else
                            {
                                row[label] = Convert.ChangeType(tempLine, type); // Credit for command: [1]
                            }
                        }
                        else
                        {
                            // If value is null, insert DBNull
                            row[label] = DBNull.Value;
                        }
                    }
                    catch(Exception e)
                    {
                        Info.errorMsg(6, "Loading label from CVP, error:" + e.Message);
                    }
                }

                // Add row to the DB
                countryList.Rows.Add(row);
                // Mark country as done
                numberOfCountries--;
            }

            #endregion
        }

        private string RemoveSpecifiedCharsFromLine(string line)
        {
            // Remove spaces, tabs, multispaces
            line = Regex.Replace(line.Replace("\t", ""), @"[ ]{2,}", "");
            line.Replace(" ", "");

            return line;
        }

        #endregion

        #region ExportingToFile

        internal void ExportFromDBtoFile()
        {
            string exportPath = Configuration.baseExportDirectory + @"\" + Globals.activeScenarioName
                + @"\Maps\" + Globals.activeCVPFileName + @".CVP";

            if(!File.Exists(exportPath))
            {
                File.Delete(exportPath);
            }

            // Clear content of file
            File.WriteAllText(exportPath, "");

            // Remember that Theatres data will also go to this file, at the very beginning (!)
            // TODO

            // Insert Theatres Info (EMPTY)
            File.AppendAllLines(exportPath, new string[]
            {
                $"// SCENARIO REGIONS",
                $"// Created using Enhanced Scenario Creator {Configuration.editorVersion}:{Configuration.assemblyVersion} - {DateTime.Now}\n",
                $"&& THEATRES\n",
                $"&& THEATRETRANSF",
                $"&& END\n"
            });

            // Insert country info, same template for each row (country)
            foreach(DataRow row in countryList.Rows)
            {
                File.AppendAllLines(exportPath, new string[]
                {
                    $"&&CVP                         {row["CountryID"]}",

                    $"regionname                    {row["regionname"]}",
                    $"prefixname                    {row["prefixname"]}",
                    $"altregionname                 {row["altregionname"]}",
                    $"blocknum                      {row["blocknum"]}",
                    $"altblocknum                   {row["altblocknum"]}",
                    $"continentnum                  {row["continentnum"]}",
                    $"flagnum                       {row["flagnum"]}",
                    $"musictrack                    {row["musictrack"]}",
                    $"regioncolor                   {row["regioncolor"]}",
                    $"politic                       {row["politic"]}",
                    $"govtype                       {row["govtype"]}",
                    $"refpopulation                 {row["refpopulation"]}",
                    $"poptotalarmy                  {row["poptotalarmy"]}",
                    $"popminreserve                 {row["popminreserve"]}",
                    $"treasury                      {row["treasury"]}",
                    $"nationaldebtgdp               {row["nationaldebtgdp"]}",
                    $"techlevel                     {row["techlevel"]}",
                    $"civapproval                   {row["civapproval"]}",
                    $"milapproval                   {row["milapproval"]}",
                    $"fanaticism                    {row["fanaticism"]}",
                    $"defcon                        {row["defcon"]}",
                    $"loyalty                       {row["loyalty"]}",
                    $"playeragenda                  {row["playeragenda"]}",
                    $"playeraistance                {row["playeraistance"]}",
                    $"worldavail                    {row["worldavail"]}",
                    $"armsavail                     {row["armsavail"]}",
                    $"worldintegrity                {row["worldintegrity"]}",
                    $"treatyintegrity               {row["treatyintegrity"]}",
                    $"envrating                     {row["envrating"]}",
                    $"milsubsidyrating              {row["milsubsidyrating"]}",
                    $"domsubsidyrating              {row["domsubsidyrating"]}",
                    $"creditrating                  {row["creditrating"]}",
                    $"tourismrating                 {row["tourismrating"]}",
                    $"literacy                      {row["literacy"]}",
                    $"lifeexp                       {row["lifeexp"]}",
                    $"avgchildren                   {row["avgchildren"]}",
                    $"crimerate                     {row["crimerate"]}",
                    $"unemployment                  {row["unemployment"]}",
                    $"gdpc                          {row["gdpc"]}",
                    $"inflation                     {row["inflation"]}",
                    $"buyingpower                   {row["buyingpower"]}",
                    $"prodefficiency                {row["prodefficiency"]}",
                    $"alertlevel                    {row["alertlevel"]}",
                    $"bwmmember                     {(row["bwmmember"] == "True" ? 1 : 0)}",
                    $"religionstate                 {row["religionstate"]}",
                    $"bconscript                    {(row["bconscript"] == "True" ? 1 : 0)}",
                    $"forcesplan                    {(row["forcesplan"] == "True" ? 1 : 0)}",
                    $"milspendsalary                {row["milspendsalary"]}",
                    $"milspendmaint                 {row["milspendmaint"]}",
                    $"milspendintel                 {row["milspendintel"]}",
                    $"milspendresearch              {row["milspendresearch"]}",
                    $"RacePrimary                   {row["RacePrimary"]}",
                    $"RaceSecondary                 {row["RaceSecondary"]}",
                    $"capitalx                      {row["capitalx"]}",
                    $"capitaly                      {row["capitaly"]}",
                    $"masterdata                    {(row["masterdata"] == "True" ? 1 : 0)}",
                    $"nonplayable                   {(row["nonplayable"] == "True" ? 1 : 0)}",
                    $"influence                     {row["influence"]}",
                    $"influenceval                  {row["influenceval"]}",
                    $"couppossibility               {row["couppossibility"]}",
                    $"revoltpossibility             {row["revoltpossibility"]}",
                    $"independencedesire            {row["independencedesire"]}",
                    $"parentloyalty                 {row["parentloyalty"]}",
                    $"independencetarget            {row["independencetarget"]}",
                    $"sphere                        {row["sphere"]}",
                    $"civiliansphere                {row["civiliansphere"]}",
                    $"keepregion                    {(row["keepregion"] == "True" ? 1 : 0)}",
                    $"parentregion                  {row["parentregion"]}",
                    $"theatrehome                   {row["theatrehome"]}",
                    $"electiondate                  {row["electiondate"]}\n",
                });

                try
                {
                    ExportSectionToFile(exportPath, "grouping", row);
                    ExportSectionToFile(exportPath, "regiontechs", row);
                    ExportSectionToFile(exportPath, "regionunitdesigns", row);
                    ExportSectionToFile(exportPath, "regionproducts", row);
                    ExportSectionToFile(exportPath, "regionsocials", row);
                    ExportSectionToFile(exportPath, "regionreligions", row);
                }catch(Exception e)
                {
                    Info.errorMsg(-1, $"Exporting to CVP fail, err:{e.Message}");
                }
            }
        }

        private void ExportSectionToFile(string exportPath, string label, DataRow row)
        {
            // Split data by comma
            string[] values = row[label].ToString().Split(',');

            // Append label name and id e.g. &&GROUPING               1010\n
            File.AppendAllText(exportPath, "&&" + label.ToUpper() + new String(' ', 15) + row["CountryID"] + "\n");

            // Insert each value to the file, end line with a comma
            foreach (string value in values)
            {
                File.AppendAllText(exportPath, value + ",\n");
            }
            File.AppendAllText(exportPath, "\n");
        }

        #endregion
    }
}

/// [CREDITS]
/// [1] https://stackoverflow.com/a/4010198/12934099
///



// Ideas for load to-components and from-components
// Load-to : select row and go textRegionName.Text = r["regionname"] etc.
// Load-from : create new row and go r["regionname"] = textRegionName.Text etc.
// You can add those lines to the end of DB, because on the Editor list they can be sorted, and in the final file
//  order doesn't matter
