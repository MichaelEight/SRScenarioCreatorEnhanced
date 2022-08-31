/// GlobalsList.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

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

    public static string defaultEditorFontFamily = "Century Gothic"; // DEFAULT: "Century Gothic"

    public static float currentAppScaleFactor = 1.0f;
    public static float previousAppScaleFactor = 1.0f;
    
    public static float currentFontScaleFactor = 1.0f;
    public static float previousFontScaleFactor = 1.0f;
}