/// RegionsContent.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using SRScenarioCreatorEnhanced.DataSets;
using System;
using System.Data;
using System.Diagnostics;

namespace SRScenarioCreatorEnhanced
{
    public class RegionsContent
    {
        #region Variables

        #region EditorVars

        int countryID; // Also a Country Data, but used as general ID
        internal cvpFile.CountryListDataTable countryList;

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
            // Open file (scenario if exists, else refer to \Maps in gameDir)
            // Load lines
            // Ignore theatres
            // Load each country
            // Refresh list of countries

            cvpFile.CountryListRow row;

            for(int i = 0; i < 10; ++i)
            {
                row = countryList.NewCountryListRow();

                row["CountryID"] = 1000 + i;
                row["regionname"] = new string('A', i);
                row["blocknum"] = (1000 + i) / 100; // ignore last 2 digits

                countryList.Rows.Add(row);
            }

        }
    }
}
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