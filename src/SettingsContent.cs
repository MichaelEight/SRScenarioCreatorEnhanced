/// SettingsContent.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

namespace SRScenarioCreatorEnhanced
{
    public class SettingsContent
    {
        // *Legend*
        // input? - unknown input type, no example given
        // not sure - value or range probable, but not tested
        // what is that? - never used / heard of / no idea what it does

        int startymd; // yyyymmdd
        int defaultRegion; // region's id
        string scenarioid; // what is that?
        int militaryDifficulty; // 0 - 4
        int diplomacyDifficulty; // 0 - 4
        int economicDifficulty; // 0 - 4
        int resourcesLevel; // 0 - 3 not sure
        int initialFunds; // 0 - 3 not sure
        int reserveLimit; // input?
        int aistance; // input? guess 0-5
        int startYear; // input?
        int techTreeDefault; // what is that?
        bool noCapitalMove; // fixedCapital 0-1
        int regionEquip; // what is that? guess, by location, probably bool 0-1
        bool limitDarEffect; // limit Domestic Approval Rating 0-1
        bool limitMarEffect; // limit Military Approval Rating 0-1
        bool wmInvolve; // what is this? 0-1
        bool wmDuse; // what is this? 0-1
        bool fastBuild; // what is this? 0-1
        bool govChoice; // what is this? 0-1
        bool groupLoyaltyMerge; // what is this?
        bool groupResearchMerge; // what is this?
        int relationsEffect; // what is this?
        int limitInScenario; // what is this?
        int mapMusic; // what is this?
        int mapGui; // what is this?
        int mapSplash; // what is this?
        int campaignGame; // what is this?
        int victoryHex; // what is this? ~probably hex needed to be taken to win
        int victoryTech; // what is this? 
        int regionAllies; // what is this?
        int regionAxis; // what is this?
        int fastFwdDays; // input?
        int sVictoryCond; // input?
        int gameLength; // input?
        bool missileNoLimit; // what is this?
        bool alliedVictory; // all countries allied is a win 0-1
        int restrictTechTrade; // what is this?
        int approvalEff; // approval effect, guess 0-4
        int wmdEff; // what is this?
        bool debtFree; // no starting debt 0-1
        bool noLoyPenalty; // no penalty because of low loyalty 0-1
        bool noSphere; // no sphere of influence 0-1
        int sphereNn; // what is this?
    }
}