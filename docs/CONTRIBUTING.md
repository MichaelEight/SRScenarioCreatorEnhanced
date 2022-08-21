# Content of This File
- [How to download, run the project](#how-to-edit)
- [Main idea in few words](#main-idea)
- [Main goals of the app, what are we trying to achieve](#main-goals)
- [Details about scheme of the app](#how-does-should-the-editor-work)
- [Which directories editor uses, what file scheme to expect while using it (for editor to work)](#directories-needed)
- [What file does what, which to edit, where to find what while developing editor (project content)](#development-directories)
- [Problems with development or loading project](#known-developer-issues)

## How To Edit
Fork the repository, download the project.
Run ```SRScenarioCreatorEnhanced.sln``` using Visual Studio 2022 (may work with previous versions).
Make the changes. Make sure everything works as intended. Make a pull request.

## Main Idea
Scenario creator (and at the same time editor) for a game "Supreme Ruler Ultimate".
Highly based on the [original one](https://supremeruler.fandom.com/wiki/Scenario_Creator). This project is basically a remake of it.

## Main Goals
- Editor should be able to **create** or **load and modify**:
  - *.scenario* files -> containing all of the names of other files (it's like a map of what files to use and where to find them)
  - *.cvp* files -> containing data on countries and their setting as well as theaters (note: .regionincl file contains regions selected from list in .cvp ; TODO: add "selected" checkBox by the country on the country list to add it to .regionincl)
  - *.oob* files -> containing data on units assigned to each country (IDs, quantity, experience, names etc.)
  - *.wmdata* files -> containing data on resources and world market
  - **NOTE:** "Non-editable Data" section must be present, files must be detected and available to select, however editing **will not** be supported by this editor
- Editor should eliminate (and preferably not add new) problems with the original one:
  - Lack of options e.g. Regions Tab has just few options available, while each country has **a lot** of different options and settings
  - .scenario file generator producing mistakes like duplicated lines or wrong extension, which makes the scenario unplayable
- Editor should have some Visual Enhancements. You know, make it prettier. But prefer ease-of-use over graphics. It's an editor after all.

## How Does (Should) the Editor Work
User opens up the editor. Scenario Tab is displayed on start.

User can select an existing scenario file from the drop down list (upon selection, names of all other files are loaded to the remaining combo boxes) or enter a new name (this will create a new scenario ; nothing new is loaded after typing the name).

User **must** meet few requirements to be able to continue editing and to export scenario. Requirements: boxes marked with (R) label must not be empty.

Conditions to unlock tabs:
- Scenario - always unlocked
- Settings - basic requirements met
- Theaters, Regions - basic + 'modify' CVP selected
- Resources, WMData - basic + 'modify' WM selected
- Orbats - basic + 'modify' OOB selected

In other tabs user should be able to modify content of all listed files.

Additional Guidelines:
- Regions Tab should have a list of all existing countries (ID + name + isSelected). On click, country's data should be loaded to all boxes besides it. There, user should be able to modify as many options as possible. You can divide options to 2 sections: basic (name, id, flag etc.) and advanced (crimerate, ratings etc.). "Advanced" options may be skipped by a checkbox (more specific - press to enable advanced options). If advanced not selected then leave them blank (well, game is suprisingly good at working without some information) or generate random values. There should be a "Save changes" button and "Create New Country" button. 
- **Use descriptive variable names! Readability over pure shortcuts!**


## Directories Needed
// Edit on 2022/08/21 19:47 -- in src>>GlobalsList.cs exists "Configuration" class. There are debug settings you can use. Set `enableLoadingFilesFromGameDirectory` to `false` to disable app accessing game directory (sometimes needed, if a directory error appears)

Main Game folder -- Supreme Ruler Ultimate, from now on marked as ..\

- Custom Scenarios Folder:
  - ..\Scenario\Custom\
- Sandbox Scenarios Folder:
  - ..\Sandbox\

- Example with premade scenario:
  - ..\Scenario\Custom\ -- scenario folder and .scenario file go here
  - ..\Scenario\Custom\FourIslands\Maps\ -- here go .cvp, .mapx, .oof and .regionincl files
  - ..\Scenario\Custom\FourIslands\Maps\Orbat -- .oob file
  - ..\Scenario\Custom\FourIslands\Maps\Data -- non-editable content files, so: .unit, .pplx, .ttrx, .terx, .newsitems and .prf

- Folder with default game files (.mapx, .cvp etc.):
  - ..\Maps

- ... and accordingly, like in the example above:
  - ..\Maps\Orbat
  - ..\Maps\Data

## Development Directories
- `Forms` folder - contains windows displayed (most important - editorMainWindow, which is base for the whole app: it's a container for tabs, exit button, info button, title name etc.)
- `Resources` folder - graphics, icons
- `src` (source) folder - back-end files. Mostly have variables for holding data. Used for exporting and importing files.
  - `GlobalList.cs` contains technical global variables. They hold info on which tab should be active and option, section not to use (debug commands e.g. to disable loading files from game directory)
  - `Program.cs` - do not touch. Starting file for main window.
  - `ScenarioContent.cs` - file containing all info and mechanic of a .scenario file. It has all of the data (names and values needed for the file). It is responsible for exporting files from **the whole** editor (including other tabs) and importing and loading data from .scenario file. It holds also the game directory string.
  - Everything else with `*content.cs` - contains data on other tabs and functions used in them.
- `UserControls` - front-ent files. Collection of UserControls, so basically content of tabs. It is responsible for how tabs look like and for the mechanic of buttons, comboboxes and other components

## Known Developer Issues
- `GUNA.UI2` errors. GUNA.UI2 is a set of premade UI elements. You can try to solve it by updating the addon: Tools >> NuGet Package Manager >> Manage NuGet Packages for Solution. Make sure `Guna.UI2.WinForms` is present in "Installed" tab. Switch to "Updates" and update `Guna.UI2.WinForms`.
