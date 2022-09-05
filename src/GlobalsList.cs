/// GlobalsList.cs file released under GNU GPL v3 licence.
/// Originally used in the SRScenarioCreatorEnhanced project: https://github.com/r20de20/SRScenarioCreatorEnhanced

using System.IO;
using System.Reflection;
using System.Windows.Forms;
public static class Globals
{
    public static bool isSettingsActive  = false;
    public static bool isTheatersActive  = false;
    public static bool isRegionsActive   = false;
    public static bool isResourcesActive = false;
    public static bool isWMActive        = false;
    public static bool isOrbatActive     = false;
    public static bool isExportBtnActive = false;
}

public static class Configuration
{
    // EDIT EVERY NEW RELEASE!
    // Manual version of app
    public const string editorVersion = "Alpha 4";
    // Auto version of assembly
    public static string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public static string currentLanguage = "en-US";

    // @"[path_to_steam]\Steam Games\steamapps\common\Supreme Ruler Ultimate"
    // Preferably auto-detect SR folder OR leave it empty and force user to choose path at 1st start
    public static string baseGameDirectory = Directory.GetCurrentDirectory();
    public static string baseExportDirectory = baseGameDirectory + @"\Scenario\Custom";

    public const bool enableLoadingFilesFromGameDirectory = true; // DEFAULT: TRUE
    
    public static string defaultEditorFontFamily = "Century Gothic"; // DEFAULT: "Century Gothic", probably obsolete

    public static float currentAppScaleFactor  = 1.0f;
    public static float previousAppScaleFactor = 1.0f;

    public static float currentFontScaleFactor  = 1.0f;
    public static float previousFontScaleFactor = 1.0f;

    public static int settingsDebugLevel = 1;
}

public static class Info
{
    // Error messages switches -- enable/disable
    // Might be useful to turn them off for production
    public static bool loadingFilesError                   = true;
    public static bool loadingDataIntoTabsError            = true;
    public static bool loadingDataFromFileError            = true;
    public static bool failedToRecogniseLabelFromfileError = true; // By default, it should be off
    public static bool fileIsAlreadyInUseError             = true;

    /// <summary>
    /// Displays MessageBox with error description
    /// IDs: 0:loading files, 1:loading data into tabs, 2:while loading data from file
    /// 3:failedToRecogniseLabel, 4:fileInUse
    /// </summary>
    /// <param name="errorTypeId">Error is checked, if it's allowed to be displayed</param>
    /// <param name="message">Description of error</param>
    public static void errorMsg(int errorTypeId, string message)
    {
        // Check if specific message box is allowed to appear
        switch(errorTypeId)
        {
            case 0: if (loadingFilesError)                   return; break;
            case 1: if (loadingDataIntoTabsError)            return; break;
            case 2: if (loadingDataFromFileError)            return; break;
            case 3: if (failedToRecogniseLabelFromfileError) return; break;
            case 4: if (fileIsAlreadyInUseError)             return; break;

            default:break;
        }

        // Display error box
        MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}