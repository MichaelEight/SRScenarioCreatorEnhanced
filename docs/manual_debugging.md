# Guide to help you solve few issues, which may appear

## Basic Issues
### App doesn't start
**Solution:** Make sure you've extracted all files from .rar, especially .exe and .dll-s. If you use Norton Antivirus, it may help to turn it off for a second, because this thing is so officious it will delete the app instantly, if it learns it has more that 10 comboboxes (proved by experiments). 

## Format
(Error Code) "*Error Message*" (Introduced in app version)

**Explanation**: ...

**Solution**: ... 

**NOTE:** Error Code marks the area, where error appeared. It's **not** shown in the error message. Exact info in Configuration class. Developer-only info.

## Full List
### (0) "*Failed to find that .scenario file!*" (Alpha 3+)

**Explanation:** Editor tried to open .scenario file with name given in Scenario_Tab >> Scenario_Name. Error-check detected,
that file doesn't exist. It could've been deleted by user or other 3rd party application. List of file names is generated on launch and after directory change.
If it got deleted between launching Editor and selecting scenario from the list, the error will appear.

**Solution:** Just... don't delete the scenario you're trying to edit.

### (1) "*Wrong startymd date format!*" (Alpha 3+)

**Explanation:** Editor tried to load setting called "startymd" from .scenario file (usually somewhere around line 43). However given date
was invalid. Default format is `yyyy, MM, dd`, where yyyy stands for year, MM for month and dd - day. Error might appear, when different format was used or part of
the date was missing. Error also points out, that game won't be able to recognise it as valid date either.

**Solution:** Edit the starting date to correct one in Settings Tab. Alternatively - manually change startymd in the .scenario file to the correct format

### (2) "*Too few or too much arguments for setting {setting}!*" (Alpha 3+)

**Explanation**: Loading error. Shown setting had wrong amount of arguments. Settings are meant to have from 1 to 3 arguments (maybe more for some occasions).
This error might appear, if a necessary setting was empty (expected - editor should apply default value of that setting) or had not enough arguments
(e.g. startymd having year and month, without day number). Too many arguments are expected to be ignored, however that *might* potentially be the cause.

**Solution**: Proceed with editting in scenario tab. Editor will revert that specific setting to default value. You can still change it to your own value.
Alternative - edit value manually in the .scenario file. 

### (3) "*No variable found for that label! ({label})*" (Alpha 3+)

**Explanation**: Loading error. While loading .scenario file, editor has to distinguish between different settings, because they might be out of order.
It does so by looking at the label (i.e. name before colon in each line). For example, for line `startymd: 1999, 08, 08`, the `startymd` is the label.
Error appears, when unknown label has been detected. This might by a typo of the existing setting or just a random word, which exists there for whatever reason.

**Solution**: If you proceed with editting, file will be overwritten with correct label. However you need to specify the value of that setting in Settings Tab,
otherwise the editor will pick the default one for you. Alternative - edit .scenario file manually to correct typos.

### (4) "*File already in use (bug). Retry!*" (Alpha 3+)

**Explanation**: Bug which appears from time to time for no apparent reason. Happens when trying to export scenario (exact point - exporting .scenario file).

**Solution**: No solutions yet. Try to retry the export. 

### (5) "*Loading language {file}: missing lines"*" (Alpha 4+)

**Explanation**: Some language file has missing lines i.e. every line contains text, which will be loaded to some component in the Editor. If there is not enough lines, not every component will have it's text. So editor had to block loading that file to not allow for that to happen.

**Solution**: Check your language file. See if you're missing any lines in each section (Scenario Tab, Settings Tab etc.). '//' and blank lines are ignored by editor.
