﻿/// SettingsContent.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System;

namespace SRScenarioCreatorEnhanced
{
    public class SettingsContent
    {
        // *Legend*
        // input? - unknown input type, no example given
        // not sure - value or range probable, but not tested
        // what is that? - never used / heard of / no idea what it does

        public string startymd; // yyyy, mm, dd // FORMAT: ToString("yyyy, MM, dd");
        public int? defaultRegion; // region's id
        public string scenarioid; // some kind of scenario id
        public int? militaryDifficulty; // 0 - 4
        public int? diplomacyDifficulty; // 0 - 4
        public int? economicDifficulty; // 0 - 4
        public int? resourcesLevel; // 0 - 3 not sure
        public int? initialFunds; // 0 - 3 not sure
        public bool reserveLimit; // limits reserves
        public int? aistance; // input? guess 0-5
        public int? startYear; // input?
        public int? techTreeDefault; // what is that?
        public bool noCapitalMove; // fixedCapital 0-1
        public bool regionEquip; // what is that? guess, by location, probably bool 0-1
        public bool limitDarEffect; // limit Domestic Approval Rating 0-1
        public bool limitMarEffect; // limit Military Approval Rating 0-1
        public bool wmInvolve; // effects of using nukes 0-1
        public bool wmdUse; // allow nukes 0-1
        public bool fastBuild; // what is this? 0-1
        public bool govChoice; // what is this? 0-1
        public bool groupLoyaltyMerge; // what is this? 0-1
        public bool groupResearchMerge; // what is this? 0-1
        public bool relationsEffect; // what is this? guessed bool, but default in w2020 is 2
        public bool limitInScenario; // limit regions in scenario 0-1
        public int? mapMusic; // what is this?
        public int? mapGui; // input? gui type (year) in-game 
        public int? mapSplash; // input? map icon
        public bool campaignGame; // what is this?
        public int? victoryHexX; // hex needed to be taken to win
        public int? victoryHexY; // hex needed to be taken to win
        public int? victoryTech; // tech needed to win 
        public int? regionAllies; // input? ~region ids marked as Allies side
        public int? regionAxis; // input? ~region ids marked as Axis side
        public int? fastFwdDays; // how many days to fast forward
        public int? sVictoryCond; // input? victory by capital, complete etc.
        public int? gameLength; // input?
        public bool missileNoLimit; // no limit of missiles 0-1
        public bool alliedVictory; // all countries allied is a win 0-1
        public bool restrictTechTrade; // what is this?
        public int? approvalEff; // approval effect, guess 0-4
        public int? wmdEff; // weapon of mass destruction effect 0-2
        public bool debtFree; // no starting debt 0-1
        public bool noLoyPenalty; // no penalty because of low loyalty 0-1
        public bool noSphere; // no sphere of influence 0-1
        public int? sphereNn; // what is this?

        /// <summary>
        /// Default values for variables, some randomly chosen
        /// </summary>
        public SettingsContent()
        {
            startymd = DateTime.Now.ToString("yyyy, MM, dd");
            defaultRegion = 1000;
            scenarioid = "";
            militaryDifficulty = 2;
            diplomacyDifficulty = 2;
            economicDifficulty = 2;
            resourcesLevel = 1;
            initialFunds = 1;
            //reserveLimit = ;
            //aistance = ;
            //startYear = ;
            //techTreeDefault = ;
            noCapitalMove = false;
            regionEquip = true;
            limitDarEffect = false;
            limitMarEffect = false;
            wmInvolve = true;
            wmdUse = true;
            fastBuild = false;
            govChoice = true;
            groupLoyaltyMerge = true;
            groupResearchMerge = true;
            relationsEffect = true;
            limitInScenario = true;
            //mapMusic = ;
            mapGui = 2;
            mapSplash = 57;
            campaignGame = false;
            //victoryHexX = ;
            //victoryHexY = ;
            victoryTech = 1818;
            //regionAllies = ;
            //regionAxis = ;
            fastFwdDays = 0;
            //sVictoryCond = ;
            //gameLength = ;
            missileNoLimit = true;
            alliedVictory = true;
            restrictTechTrade = false;
            approvalEff = 2;
            wmdEff = 2;
            debtFree = false;
            noLoyPenalty = false;
            noSphere = true;
            sphereNn = 3;
        }
    }
}