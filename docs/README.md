# Supreme Ruler Scenario Creator Enhanced

## Work in progress (!)
[Contribution guidelines for this project](CONTRIBUTING.md)

[What do these errors mean? How to fix them?](manual_debugging.md)

## Origin Story
Supreme Ruler Ultimate is one of the most liked games by me & my friends. We decided to try modding it. It was fine, however stock editor has it's issues.
There is a lack of options and exporting scenarios often break for no specific reason. In the end you had to go to the files and manually change the settings.
That's why we decided to make an editor of our own. Improved over the original one.

## Usage
**Alpha Version, work in progress!**

- Download newest release
- Extract files to a folder using WinRar or other archive app
- Run `SRScenarioCreatorEnhanced.exe` file
- **If that's your first time launching the app, remember to go to editor settings (Gear icon) and edit game directory**. Example of Game Directory: *I:\Steam Games\steamapps\common\Supreme Ruler Ultimate*
- If you any problems with the app setup (e.g. app doesn't start), refer to [this](manual_debugging.md#basic-issues). If you experience any issues (bugs etc.) while using the app, refer to [this](manual_debugging.md#full-list). If these guides don't solve your problem, create a new issue (Issues tab on Github) or join the existing one.

### Scenario Tab
<img src="https://github.com/r20de20/SRScenarioCreatorEnhanced/blob/3a17ccfd8856ac10755a31a2713aea77ba69d797/docs/editorScenarioTab.png" width="75%"/>

- If you've selected the right path, editor will load all available scenarios from the folder: *[game directory]\Scenario\Custom*
- Other tabs and export button will unlock once you fill all required fields
- Check "modify" to unlock tabs in which you can modify the content of that file

### Settings Tab
<img src="https://github.com/r20de20/SRScenarioCreatorEnhanced/blob/3a17ccfd8856ac10755a31a2713aea77ba69d797/docs/editorSettingsTab.png" width="75%"/>

- All of the existing scenario settings

### Editor Settings
<img src="https://github.com/r20de20/SRScenarioCreatorEnhanced/blob/3a17ccfd8856ac10755a31a2713aea77ba69d797/docs/editorSettingsWindow.png" width="35%"/>

- Editor scale - general size of the window
- Font scale - ... font size, obviously
- Debug Messages - Some error/info message boxes are disabled to not frustrate the user because of their frequency within some stages (e.g. loading data from files). If you're experiencing any issue, it's recommended to show all debug messages. You might fix the problem yourself. [Helpful guide to resolve the issues](manual_debugging.md) If not, create an issue about that problem.
- Game Directory - Change it to your Supreme Ruler folder e.g. `I:\Steam Games\steamapps\common\Supreme Ruler Ultimate`
- Language - You can select here active language. Editor loads .LANG files from `[Editor directory]\Lang` and displays them. If you've created/modified a language file and it's not displayed there, that means there are lines missing from it. 

### Help Window
<img src="https://github.com/r20de20/SRScenarioCreatorEnhanced/blob/3a17ccfd8856ac10755a31a2713aea77ba69d797/docs/editorHelpWindow.png" width="35%"/>

- Here you will find guide for all tabs, how to use all of the options (explanation + example of use) 

## Licence
GNU GPL v3. Free to use and modify. Not allowed to release with closed source! Credit us as original creators of Enhanced SR Editor (however we are **not** the creators of the game OR the original, steam-version editor).

## Code of Conduct
[Contribution Code of Conduct](CODE_OF_CONDUCT.md). By participating in this project you agree to abide by its terms.
