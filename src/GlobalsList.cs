/// GlobalsList.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System;

public static class Globals
{
    public static bool isSettingsActive = false;
    public static bool isTheatersActive = false;
    public static bool isRegionsActive = false;
    public static bool isResourcesActive = false;
    public static bool isWMActive = false;
    public static bool isOrbatActive = false;
    public static bool isExportBtnActive = false;
}

public static class Configuration
{
    public const bool enableLoadingFilesFromGameDirectory = true; // DEFAULT: TRUE
    public const bool enableLoadingfilesErrorMessageBoxes = true; // DEFAULT: TRUE, set FALSE for production (!)
}