using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <summary>
    /// Interface for class-wrapper of e3Apllication COM object (E³ COM version 16.5)
    /// </summary>
    public interface IApplication : IComObjectProvider
    {
        /// <summary>
        /// According to other programs like MS Word™ or Excel™, E³ exits if the last (COM-)reference to its application object is released (using "Set e3 = Nothing" or simply exiting a script) and there is no project open. This behavior may be changed by e3.AvoidAutomaticClosing([avoid=true]). 
        /// If called with parameter avoid=1 or without any parameters, E³ will remain active after the script exits.
        /// You may call e3.AvoidAutomaticClosing(false) later to return to the default behavior.
        /// </summary>
        /// <param name="avoid"></param>
        /// <returns></returns>
        int AvoidAutomaticClosing(bool avoid = true);

        /// <summary>
        /// When accessing to another program from the E³.series process and the program doesn't respond within 10 seconds, a Windows message 'Switch to...' is displayed by default. This message cannot be closed until the request of the other program is finished. Even so, the message must be applied with 'retry'.
        /// This method sets E³ to a status, in which no interactive entries are possible. The hour glass cursor indicates that another program is active. If the other program communicates with E³ by the COM interface, no unnecessary "waiting" dialogs are displayed, when the communication exceeds any time limits. 
        /// </summary>
        /// <returns></returns>
        int BeginForeignTask();

        /// <summary>
        /// Clears the output window (clear screen). 
        /// </summary>
        void ClearOutputWindow();

        /// <summary>
        /// Available since Build 2014-1400
        /// Clears the Results Window(clear screen). 
        /// </summary>
        void ClearResultWindow();

        // TODO: Convert for return wrapped DllObject
        [Obsolete("Unknown Method", false)]
        object CreateDllObject();

        /// <summary>
        /// Returns an object, that enables the use of methods for reading and writing to a project (may also be called a job or drawing).
        /// </summary>
        /// <returns></returns>
        IJob CreateJobObject();

        // TODO: Convert for return wrapped MenuItemObject
        /// <summary>
        /// Creates a new menu item object, this is to access other menu items in project.
        /// </summary>
        /// <returns></returns>
        object CreateMenuItemObject();

        // TODO: Convert for return wrapped WespeObject
        object CreateWespeObject();

        /// <summary>
        /// Recreates the display before last minimize mode.
        /// </summary>
        /// <returns></returns>
        int Display();

        // ReSharper disable once InconsistentNaming
        [Obsolete("Unknown Method", false)]
        int EnableCOM(string password);

        /// <summary>
        /// Enables output of all messages to logfile of enabled=true. If output is enabled, the current logfile name is written to the output window.
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        int EnableLogfile(bool enabled);

        /// <summary>
        /// This method resets E³.series to a normal status.
        /// When accessing to another program from the E³.series process and the program doesn't respond within 10 seconds, a Windows message 'Switch to...' is displayed by default. This message cannot be closed until the request of the other program is finished. Even so, the message must be applied with 'retry'.
        /// </summary>
        /// <returns>The value that was active before executing the methods is returned as return value:
        /// the return value is 1, if E³.series was inactive
        /// the return value is 0, if E³.series was active(i.e.normal status)
        /// </returns>
        int EndForeignTask();

        [Obsolete("Unknown Method", false)]
        int FreeLicense(string feature);

        [Obsolete("Unknown Method", false)]
        int FreeLicensePermanent(string feature);

        /// <summary>
        /// Returns the application's name and version as a string.
        /// </summary>
        /// <returns></returns>
        string FullName();

        /// <summary>
        /// To define current database(s).
        /// Connection strings itself can be called using GetConfigurationDatabase(), GetComponentDatabase() and GetSymbolDatabase().   
        /// </summary>
        /// <returns>The string under which the user sees the database in the database tree in the register 'Component' (i.e. not the connection string).</returns>
        string GetActualDatabase();

        /// <summary>
        /// Get all available languages from the text database.
        /// In contrast to job.GetAvailableLanguages() no open project is required.
        /// Note:
        /// This COM command doesn't function with E³.ViewPlus or E³.Redliner because no access to the text database is possible.
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<string> GetAvailableLanguages();

        /// <summary>
        /// Get the current build version of E³ in form of main version number + 2000 and main version number * 100 + patchlevel.
        /// </summary>
        /// <returns></returns>
        string GetBuild();

        /// <summary>
        /// Get connection sting of currently active component database.
        /// </summary>
        /// <returns></returns>
        string GetComponentDatabase();

        /// <summary>
        /// Determine the component database's table schema.
        /// </summary>
        /// <returns></returns>
        string GetComponentDatabaseTableSchema();

        /// <summary>
        /// Get connection sting of currently active configuration database.
        /// </summary>
        /// <returns></returns>
        string GetConfigurationDatabase();

        /// <summary>
        /// Determine the configuration database's table schema.
        /// </summary>
        /// <returns></returns>
        string GetConfigurationDatabaseTableSchema();

        // TODO: Convert to return array
        /// <summary>
        /// Available since Build 2014-1400
        /// Get selected components from the Component Table 
        /// </summary>
        /// <param name="componentArray">Contains selected component from the Component Table </param>
        /// <param name="versionArray">Contains version numbers</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTableSelectedComponents(ref object componentArray, ref object versionArray);

        // TODO: Convert to return array
        /// <summary>
        /// Available since Build 2014-1400
        /// Get selected components from the Database Tree
        /// </summary>
        /// <param name="componentArray">Contains selected components from the Database Tree</param>
        /// <param name="versionArray">Contains version numbers</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTreeSelectedComponents(out object componentArray, out object versionArray);

        // TODO: Convert to return array
        /// <summary>
        /// Available since Build 2014-1400
        /// Get selected models from the Database and Model Trees 
        /// cnt number of objects found
        /// </summary>
        /// <param name="modelArray">Contains selected models from the Database and Model Trees</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTreeSelectedModels(out object modelArray);

        // TODO: Convert to return array
        /// <summary>
        /// Get selected symbols from the Database, Symbol and Misc Trees
        /// </summary>
        /// <param name="symbolArray">Contains selected symbols from the Database, Symbol and Misc Trees</param>
        /// <param name="versionArray">Contains version numbers</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTreeSelectedSymbols(out object symbolArray, out object versionArray);

        // TODO: Convert to return array
        /// <summary>
        /// Returns for dbname the configured connection strings. 
        /// </summary>
        /// <param name="dbname">As dbname only names are supported that are visible in the component tab</param>
        /// <param name="cmpCs">Components database connection string</param>
        /// <param name="symCs">Symbols database connection string</param>
        /// <param name="cnfCs">Configuration database connection string</param>
        /// <returns></returns>
        int GetDefinedDatabaseConnectionStrings(string dbname, out object cmpCs, out object symCs, out object cnfCs);

        /// <summary>
        /// Returns an array of database names, that can be used with e3.SetActualDatabase(). 
        /// Note: Only names that are visible in the component tab are visible.
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<string> GetDefinedDatabases();

        /// <summary>
        /// There are situations in which a user wants to permit explicit (modal) dialogs because certain scripts can only run interactively (also in the presence of the user).  
        /// The current setting can be queried.curval is either false (dialogs switched off) or true (dialogs switched on). 
        /// </summary>
        /// <returns></returns>
        bool GetEnableInteractiveDialogs();

        /// <summary>
        /// Get count of errors
        /// </summary>
        /// <returns></returns>
        int GetErrorCount();

        /// <summary>
        /// Get fully qualified name including the names of the superior options.
        /// </summary>
        /// <returns></returns>
        string GetFullName();

        /// <summary>
        /// Returns a unique integer, which identifies an E³ application. It may be used to check whether E³ has been stopped and restarted between different script execution events.
        /// </summary>
        /// <returns>Process id</returns>
        int GetId();

        /// <summary>
        /// Returns the number of info messages already written
        /// </summary>
        /// <returns></returns>
        int GetInfoCount();

        /// <summary>
        /// Get installation language as number code:
        /// </summary>
        /// <returns>
        /// Returns the following installation language as number code:
        /// 1   -   English(US)
        /// 44  -   English(UK)
        /// 2 or 33 -   French
        /// 7   -   Russian
        /// 34  -   Spanish
        /// 39  -   Italian
        /// 49  -   German
        /// 55 or 351   -   Portuguese
        /// 86  -   Chinese
        /// 81  -   Japanese
        /// 90  -   Turkish
        /// </returns>
        int GetInstallationLanguage();

        /// <summary>
        /// Returns the application's installation path (Windows folder name) as a string.
        /// </summary>
        /// <returns></returns>
        string GetInstallationPath();

        /// <summary>
        /// Returns count of currently opened projects in E³ window. Presently, E³ allows you to have only one open project
        /// </summary>
        /// <returns></returns>
        int GetJobCount();

        /// <summary>
        /// To determine the number and Ids of open projects, use e3.GetJobIds. prj.SetId assigns an ID to a project object.
        /// Presently, E³ allows you to have only one open project
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<int> GetJobIds();

        /// <summary>
        /// Get connection name of currently active language database
        /// </summary>
        /// <returns></returns>
        string GetLanguageDatabase();

        /// <summary>
        /// Determine the languages database's table schema.
        /// </summary>
        /// <returns></returns>
        string GetLanguageDatabaseTableSchema();

        [Obsolete("Unknown Method", false)]
        int GetLicense(string feature);

        [Obsolete("Unknown Method", false)]
        int GetLicensePermanent(string feature);

        // TODO: Make parameter enum instead int
        /// <summary>
        /// Returns the log file name of an Output window, if one has already been defined. 
        /// </summary>
        /// <param name="index">index is an optional parameter (default value = 0) 
        /// Index 0: Log file of the Message window
        /// Index 1: Log file of the Results window
        /// </param>
        /// <returns></returns>
        string GetLogfileName(int index = 0);

        /// <summary>
        /// Returns a window handle that is currently placed "in front of" E³.series. If none is set, 0 is returned
        /// </summary>
        /// <returns></returns>
        IntPtr GetModalWindow();

        /// <summary>
        /// This command opens the dialog to select a multi-user folder (server must be running) and returns its path after folder selection and OK. 
        /// </summary>
        /// <returns>Key - folder id, Value - folder path</returns>
        KeyValuePair<int, string> GetMultiuserFolderPath();

        /// <summary>
        /// Returns all names of all multi-user projects saved on the multi-user server that can be opened by the current user.
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<string> GetMultiuserProjects();

        /// <summary>
        /// Returns the application's name
        /// </summary>
        /// <returns></returns>
        string GetName();

        /// <summary>
        /// Returns the plugin COM object that is saved in E³.series.
        /// </summary>
        /// <param name="plugin">Plugin is the com object's name defined in the registry. For example: AcroPDF.PDF.1</param>
        /// <returns></returns>
        object GetPluginObject(ref object plugin);

        /// <summary>
        /// Available since Build 2011-1010
        /// Return value is the definition of the 'Print crop marks' option
        /// </summary>
        /// <returns></returns>
        bool GetPrintCropMarks();

        // TODO: convert return value to struct
        /// <summary>
        /// Returns the current colour setting 
        /// </summary>
        /// <returns>
        /// -1 means: use colours as drawn on sheets 
        /// 0: use only black and white
        /// </returns>
        int GetPrinterColour();

        // TODO: convert return value to struct
        /// <summary>
        /// Returns the current line width setting
        /// </summary>
        /// <returns>
        /// -1 means: use line width as defined on sheets and scale them according to scaling parameters of methods prj.PrintOut and sht.PrintOut 
        /// 0: use line width on sheets but ignore scaling parameters
        /// </returns>
        double GetPrinterLinewidth();

        // TODO: convert return value to struct instead of ref
        /// <summary>
        /// Returns the current margin settings: top, bottom, left, right in the predefined unit of measure.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        int GetPrinterMargins(ref object top, ref object bottom, ref object left, ref object right);

        /// <summary>
        /// Returns the current printer's name, which is defined in the File -> Printer Setup
        /// </summary>
        /// <returns></returns>
        string GetPrinterName();

        /// <summary>
        /// Available since Build 2011-1010
        /// Return value is the definition of the 'Print page numbers' option
        /// </summary>
        /// <returns></returns>
        bool GetPrintPageNumbers();

        // TODO: convert return value to enum instead of int
        /// <summary>
        /// Available since Build 2011-1020
        /// Get print sheet order
        /// </summary>
        /// <returns></returns>
        int GetPrintSheetOrder();

        /// <summary>
        /// Available since Build 2011-1010
        /// Return value is the definition of the 'Select pages' option
        /// </summary>
        /// <returns></returns>
        bool GetPrintSplitPages();

        // TODO: convert parameter to enum instead of string, convert return value to string instead of object
        /// <summary>
        /// To determine the resources used
        /// </summary>
        /// <param name="what">what is a string that defines what is to be returned with ret:
        /// [what] - [type of return value] - [description]
        /// 
        /// BuildTimeStamp - string - build timestamp
        /// Dictionary - string - HKLM\SW\CT\E3\<NR>\MU\Dictionary, e.g.Provider=sqloledb;Server=name\E3_2007;Initial Catalog = E3DICTIONARY;
        /// Host - string - Hostname
        /// ProcessID - string (integer) -E³-PID
        /// ProcessInfo - dictionary(string/string) - contains all E³ Process parameters(times values are milliseconds (integer), memory values are kilo bytes(integer))
        /// ServerHost - string - Hostname of the MuService process, if connected
        /// ServerPort - string - Port of the MuService process, if connected
        /// ServerProcessInfo - dictionary(string/string) - contains all MuService Process parameters(times values are milliseconds (integer), memory values are kilo bytes(integer))
        /// UserModeTime - string (integer) - User mode time of the E³ process in milliseconds(integer) since the start of E³
        /// User - string - Username
        /// WorkingSetSize - string (integer) - Working set size in kilo bytes(integer)
        /// WindowHandle - string (integer) - WindowHandle
        /// </param>
        /// <returns></returns>
        object GetProcessProperty(string what);

        /// <summary>
        /// Using this method, it's possible to read information of a *.e3s file:
        /// </summary>
        /// <param name="filename">filename path and name of the *.e3s file.</param>
        /// <param name="type"> type = the returned value is the information of the *.e3s project
        /// 1 = cable(also schema)
        /// 2 = logic
        /// 3 = WireWorks
        /// 4 = demo
        /// 5 = student </param>
        /// <param name="isDbe">is_dbe = the returned value is 1, when the project was saved in Database Editor mode, otherwise 0.</param>
        /// <returns>ret = the return value can have the following values:
        /// 0 = the command could be successfully executed.
        /// 1 = the file was not found.
        /// 2 = the file information could not be read, for example because the project is older than e3 version 2004.
        /// 3 = the file is already open, the file information could not be read.</returns>
        int GetProjectInformation(ref object filename, ref object type, ref object isDbe);

        /// <summary>
        /// Returns the state of lifecycle of given project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        string GetProjectLifecycle(string project);

        string GetProvider(string dbname);

        /// <summary>
        /// Outputs the internal registry version number (e.g. 8.0, 9.0,...) .
        /// </summary>
        /// <returns></returns>
        string GetRegistryVersion();

        /// <summary>
        /// Returns the handed over parameters as an array of strings for internal running scripts.
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<string> GetScriptArguments();

        /// <summary>
        /// This method and SetScriptReturn() can both be used to manipulate the return value. The default return value is 0. 
        /// </summary>
        /// <returns></returns>
        int GetScriptReturn();

        /// <summary>
        /// Get server name definition in E³. series multi-user environments. 
        /// </summary>
        /// <returns></returns>
        string GetServerName();

        /// <summary>
        /// Get server port definition in E³. series multi-user environments. 
        /// </summary>
        /// <returns></returns>
        int GetServerPort();

        /// <summary>
        /// Get connection string of currently active symbol database.
        /// </summary>
        /// <returns></returns>
        string GetSymbolDatabase();

        /// <summary>
        /// Get table schema of currently active symbol database.
        /// </summary>
        /// <returns></returns>
        string GetSymbolDatabaseTableSchema();

        /// <summary>
        /// New since Build 2011-1000:
        /// Returns the system menu item IDs.
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<int> GetSystemMenuItemIds();

        /// <summary>
        /// Returns the filename of the defined template file, which is used when creating new projects.
        /// </summary>
        /// <returns></returns>
        string GetTemplateFile();

        /// <summary>
        /// Returns the file name of the defines template file, which is used when creating new DBE objects
        /// </summary>
        /// <returns></returns>
        string GetTemplateFileDBE();

        [Obsolete("Unknown Method", false)]
        int GetTestMark(int num);

        // TODO: convert parameter 'language' to enum
        /// <summary>
        /// Get the translated text
        /// </summary>
        /// <param name="text">text must be the internal name (&#<num>), i.e. &#4</param>
        /// <param name="language">language any language(as a string) from the text database.</param>
        /// <returns></returns>
        string GetTranslatedText(string text, string language);

        // TODO: convert parameter 'name' to enum
        /// <summary>
        /// Get file name for trigger
        /// </summary>
        /// <param name="name">Name of trigger</param>
        /// <returns></returns>
        string GetTrigger(string name);

        /// <summary>
        /// Returns a value valid for triggers, which was defined as trigger return value. 
        /// When no trigger is active at the time of calling, the return value is always 0. 
        /// When the trigger return value is not yet defined in the active trigger, the trigger's default value is returned (see description of the individual triggers). 
        /// </summary>
        /// <returns>Value     -    symbolic name in Visual Basic/Visual Basic Script
        /// 1 - vbOK 
        /// 2 - vbCancel 
        /// 3 - vbAbort 
        /// 4 - vbRetry 
        /// 5 - vbIgnore 
        /// 6 - vbYes 
        /// 7 - vbNo
        /// </returns>
        int GetTriggerReturn();

        /// <summary>
        /// Returns the UserMenuItem IDs.
        /// New since Build 2011-1000: returns separators too
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<int> GetUserMenuItemIds();

        /// <summary>
        /// Get setting Use sheet orientation in the Print dialog. 
        /// If this option is checked (default setting), the printer's settings are ignored and the orientation is used depending on the sheet format. 
        /// </summary>
        /// <returns></returns>
        bool GetUseSheetOrientation();

        [Obsolete("Unknown Method", false)]
        int GetVerifyCount();

        /// <summary>
        /// Returns the application's version
        /// </summary>
        /// <returns></returns>
        string GetVersion();

        /// <summary>
        /// Returns the number of warning messages already written
        /// </summary>
        /// <returns></returns>
        int GetWarningCount();

        /// <summary>
        /// Returns the name of the currently set workspace.
        /// </summary>
        /// <returns></returns>
        string GetWorkspaceName();

        /// <summary>
        /// Executes the script defined in the text and adds the functions defined therin to the current context so that they can be called up with the coded script parts. 
        /// Note:
        /// This method only works with internally running scripts(defined using the Tools menu or as Triggered Script). When a script is started externally(using WSCRIPT.EXE, CSCRIPT.EXE or by double-clicking in the Windows Explorer), it cannot be used.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        [Obsolete ("This method only works with internally running scripts", true)]
        int Include(string text);

        [Obsolete("Unknown Method", false)]
        bool IsBasic();

        [Obsolete("Unknown Method", false)]
        bool IsBoard();

        /// <summary>
        /// Check is E³.Cable feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsCable();

        [Obsolete("Unknown Method", false)]
        bool IsCaddy();

        [Obsolete("Unknown Method", false)]
        bool IsCaddyBasic();

        [Obsolete("Unknown Method", false)]
        bool IsCaddyDemo();

        [Obsolete("Unknown Method", false)]
        bool IsCaddyEconomy();

        /// <summary>
        /// Check if runnung in Demo mode
        /// </summary>
        /// <returns></returns>
        bool IsDemo();

        [Obsolete("Unknown Method", false)]
        bool IsEconomy();

        [Obsolete("Unknown Method", false)]
        bool IsFluid();

        [Obsolete("Unknown Method", false)]
        bool IsFormboard();

        [Obsolete("Unknown Method", false)]
        bool IsFunctionalDesign();

        [Obsolete("Unknown Method", false)]
        bool IsLogic();

        /// <summary>
        /// Check is E³.Enterprise (multiuser support) feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsMultiuser();

        /// <summary>
        /// Check is E³.Panel feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsPanel();

        /// <summary>
        /// Check is E³.Redliner feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsRedliner();

        /// <summary>
        /// Check is E³.Schematic feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsSchema();

        /// <summary>
        /// The following COM method is available to check whether an application is already running in a project
        /// Note: To check and see if another script is running, no E³.series COM objects, except the application object, must be defined in the script which executes the IsScriptRunning call.If necessary, existing objects may have to be first released.
        /// </summary>
        /// <returns>Returns 'true', when E³.series COM objects are generated, regardless of whether they were generated in the executing script or another one. Otherwise, the return value is 'false'.</returns>
        bool IsScriptRunning();

        [Obsolete("Unknown Method", false)]
        bool IsSmallBusiness();

        [Obsolete("Unknown Method", false)]
        bool IsStudent();

        /// <summary>
        /// Check is E³.Viewer feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsViewer();

        /// <summary>
        /// Check is E³.ViewerPlus feature enabled
        /// </summary>
        /// <returns></returns>
        bool IsViewPlus();

        [Obsolete("Unknown Method", false)]
        bool IsWago();

        [Obsolete("Unknown Method", false)]
        bool IsWagoDemo();

        [Obsolete("Unknown Method", false)]
        bool IsWire();

        [Obsolete("Unknown Method", false)]
        bool IsWireWorks();

        /// <summary>
        /// Maximize the application's display window
        /// </summary>
        /// <returns></returns>
        int Maximize();

        /// <summary>
        /// Minimize the application's display window
        /// </summary>
        /// <returns></returns>
        int Minimize();

        /// <summary>
        /// Writes message to the program's output window. The output line starts either with an "E - ". 
        /// Errors are written in red.
        /// </summary>
        /// <param name="wait">wait indicates whether an additional message box should appear (wait='true')</param>
        /// <param name="text">Message text</param>
        /// <param name="itemId">Id of the item for hyperlink</param>
        /// <returns></returns>
        int PutError(bool wait, string text, int itemId = 0);

        /// <summary>
        /// Writes message to the program's output window. The output line starts either with an "I - ". 
        /// </summary>
        /// <param name="wait">wait indicates whether an additional message box should appear (wait='true')</param>
        /// <param name="text">Message text</param>
        /// <param name="itemId">Id of the item for hyperlink</param>
        /// <returns></returns>
        int PutInfo(bool wait, string text, int itemId = 0);

        /// <summary>
        /// Writes message to the program's output window.
        /// </summary>
        /// <param name="text">Message text</param>
        /// <param name="itemId">Id of the item for hyperlink</param>
        int PutMessage(string text, int itemId = 0);

        [Obsolete("Unknown Method", false)]
        int PutMultiuserLogMessage(string source, string text);

        /// <summary>
        /// Available since Build 2011-1010
        /// Generates a message in the Results Window, depending on the current verification setting, as information, warning or error. 
        /// These messages are also output in the end results. 
        /// This method can only be executed in scripts configured using XML files and only last while the check (Verify) is running.
        /// </summary>
        /// <param name="wait">wait indicates whether an additional message box should appear (wait='true')</param>
        /// <param name="text">Message text</param>
        /// <param name="itemId">Id of the item for hyperlink</param>
        /// <returns></returns>
        int PutVerify(bool wait, string text, int itemId = 0);

        /// <summary>
        /// Writes message to the program's output window. The output line starts either with an "W - ". 
        /// Warning are written in red.
        /// </summary>
        /// <param name="wait">wait indicates whether an additional message box should appear (wait='true')</param>
        /// <param name="text">Message text</param>
        /// <param name="itemId">Id of the item for hyperlink</param>
        /// <returns></returns>
        int PutWarning(bool wait, string text, int itemId = 0);

        /// <summary>
        /// Immediately stops the execution of a script and releases all previously allocated objects.
        /// </summary>
        /// <returns></returns>
        int Quit();

        /// <summary>
        /// Available since Build 2011-1000
        /// Reset counter of Errors
        /// The return value is the counter reading before resetting.  
        /// </summary>
        /// <returns></returns>
        int ResetErrorCount();

        /// <summary>
        /// Available since Build 2011-1000
        /// Reset counter of Infos
        /// The return value is the counter reading before resetting.
        /// </summary>
        /// <returns></returns>
        int ResetInfoCount();

        /// <summary>
        /// Available since Build 2011-1010
        /// Resets the verify counter
        /// This method can only be executed in scripts configured using XML files and only last while the check (Verify) is running.
        /// </summary>
        /// <returns></returns>
        int ResetVerifyCount();

        /// <summary>
        /// Available since Build 2011-1000
        /// Reset counter of Warnings
        /// The return value is the counter reading before resetting.  
        /// </summary>
        /// <returns></returns>
        int ResetWarningCount();

        /// <summary>
        /// Executes the specified script in the internal script interpreter. The method only ends if the script has been completely run. 
        /// Within an internally running script no additional scripts can be started with e3.Run(). 
        /// </summary>
        /// <param name="filename">Name of the script to be executed
        /// This name may also contain DOS variable names(embedded in %-signs).
        /// The file extension must be either.VBS or.VBX.</param>
        /// <param name="arguments">is a VBS array (starting with Index 0) of strings, which are transferred to the executed script.</param>
        /// <returns>Is an integer return, which was set by the method e3.SetScriptReturn()while executing</returns>
        int Run(string filename, ref object arguments);

        /// <summary>
        /// Returns the handed over parameters as an array of strings for internal running scripts.
        /// </summary>
        /// <returns></returns>
        object ScriptArguments();

        /// <summary>
        /// The object variable WScript is automatically connected with the E³ application object in the internally running engine. 
        /// To differentiate, whether a script is internally or externally running, the WScript.FullName method has already been implemented, which returns the "E³.series" string in case of the internal engine:
        /// <code>
        /// If(InStr( WScript.FullName, "E³" ) ) Then
        ///    Set e3 = WScript                           ' internal
        /// Else
        ///    Set e3 = CreateObject( "CT.Application" )  ' external
        /// End If
        /// </code>
        /// There are, however, many situations in which it is important to know, from where the currently running script has been loaded. To do so, the engine of the external WSCRIPT or CSCRIPT hosts offers the 
        /// WScript.ScriptFullName and
        /// WScript.ScriptName
        /// methods.Especially when working with many general sub-routines, it is common practise to derive the desired function from the script's name. Thus, these methods are now supported. 
        /// </summary>
        /// <returns></returns>
        string ScriptFullName();

        /// <summary>
        /// The object variable WScript is automatically connected with the E³ application object in the internally running engine. 
        /// To differentiate, whether a script is internally or externally running, the WScript.FullName method has already been implemented, which returns the "E³.series" string in case of the internal engine:
        /// <code>
        /// If(InStr( WScript.FullName, "E³" ) ) Then
        ///    Set e3 = WScript                           ' internal
        /// Else
        ///    Set e3 = CreateObject( "CT.Application" )  ' external
        /// End If
        /// </code>
        /// There are, however, many situations in which it is important to know, from where the currently running script has been loaded. To do so, the engine of the external WSCRIPT or CSCRIPT hosts offers the 
        /// WScript.ScriptFullName and
        /// WScript.ScriptName
        /// methods.Especially when working with many general sub-routines, it is common practise to derive the desired function from the script's name. Thus, these methods are now supported. 
        /// </summary>
        /// <returns></returns>
        string ScriptName();

        // TODO: Convert to return array
        /// <summary>
        /// Available since Build 2012-1100
        /// Using this command the Component Table can be called up. Therein a component can be selected, whose name and version are returned. 
        /// In the Component Table context menu only the two commands 'Cancel' and 'Select Component' are active. After selecting one of the commands, the dialog closes.
        /// </summary>
        /// <param name="componentName"></param>
        /// <param name="componentVersion"></param>
        /// <returns></returns>
        int SelectComponentFromTable(ref object componentName, ref object componentVersion);

        /// <summary>
        /// To define and activate current database.
        /// Defines all three databases (configuration, component and symbol), in which interactively only the database name is defined. 
        /// Thus the configuration is not immediately updated.Therefore use prj.UpdateConfiguration(). 
        /// </summary>
        /// <param name="dbname"></param>
        /// <returns></returns>
        int SetActualDatabase(string dbname);

        /// <summary>
        /// Configured connection strings are stored in a combined definition. Thus it is possible to handle the complete interactive definition using a script. 
        /// Using this call it is possible to change an existing definition in the registry (in case dbname already exists) or to create a database definition. dbname is valid for all databases.
        /// sym_cs and cnf_cs can be empty in both cases (may however not miss). When changing, the definition of the symbol and/or configuration database is not adjusted.
        ///  When adding, the component database is interpreted as symbol and/or configuration database.
        /// The connection strings of both calls contain with SQL databases a table in form of 
        /// Form; Table Schema=name
        /// This has to be considered, when the connection string in the script is used for building up a database connection.In this case, this part has to be removed from the connection string.
        /// </summary>
        /// <param name="dbname"></param>
        /// <param name="cmpCs"></param>
        /// <param name="symCs"></param>
        /// <param name="cnfCs"></param>
        /// <returns></returns>
        int SetDefinedDatabaseConnectionStrings(string dbname, string cmpCs, string symCs, string cnfCs);

        /// <summary>
        /// There are situations in which a user wants to permit explicit (modal) dialogs because certain scripts can only run interactively (also in the presence of the user).  
        /// Changes the current setting. The current value is returned before it's changed. 
        /// The setting remains permanently(also if a script closes). The default setting is 0 when starting E³.series(dialogs switched off). 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        int SetEnableInteractiveDialogs(bool value);

        /// <summary>
        /// This COM call is available for changing the language database (e.g. for automated outputs)
        /// When no project is opened, the language database is simply changed using HKCU\Software\Zuken\E3.series\Version\Databases\Languages.
        /// When the defined languages, which no longer exist in the new language database, are deleted from Settings... in an open project and all translatable texts are again output.
        /// </summary>
        /// <param name="dbname"></param>
        /// <returns></returns>
        int SetLanguageDatabase(string dbname);

        // TODO: Make parameter enum instead int
        /// <summary>
        /// Defines the log file name logfile of an Output window and closes the previous log file. 
        /// logfile can also contain environment variables, which will be dissolved afterwards.
        /// </summary>
        /// <param name="logfile">logfile must contain a complete and valid path.This path can be relative or absolute. 
        /// logfile can also contain environment variables, which will be dissolved afterwards.</param>
        /// <param name="index">index is an optional parameter(default value = 0):  
        /// Index 0: Log file of the message window
        /// Index 1: Log file of the results window</param>
        /// <returns>Return value when succussfully executed is 1, otherwise 0</returns>
        int SetLogfileName(string logfile, int index = 0);

        /// <summary>
        /// Using the following methods to handle a modal dialog for external programs.
        /// </summary>
        /// <param name="hWnd">
        /// If hWnd  is a window handle of window of an external program, this window is set as modal "in front of" E³.series.E³.series itself is then blocked.If the "foreign" window is iconifized E³.series disappears from the monitor.If E³.series (or the other window) appears again, then E³.series and the other window are displayed again.Whereas the other window is displayed "in front of" E³.series.This means the other window is displayed as a model dialog from E³.series.
        //  If hWnd = IntPtr.Zero the connection to any other window of E³.series is cancelled.This means that the user can continue work in E³.series as normal.
        /// </param>
        /// <returns>The return value ok is either 1 (successful) or 0 (not successful). If hWnd = 0 and E³.series doesn't display any other modal window, 1 is also returned.</returns>
        int SetModalWindow(IntPtr hWnd);

        /// <summary>
        /// Available since Build 2011-1010
        /// Enable or disable 'Print crop marks' option
        /// </summary>
        /// <param name="set">New value for the definition of the 'Print crop marks' option</param>
        /// <returns>Return value is the previous setting</returns>
        bool SetPrintCropMarks(bool set);

        /// <summary>
        ///  If more than one copy is to be sento the printer as one print job, e3.SetPrinterCollate defines the sort order for the pages.
        /// </summary>
        /// <param name="col">
        /// Use the following sort codes: 
        /// true: 1-2-3 1-2-3 
        /// false: 1-1 2-2 3-3 
        /// </param>
        /// <returns>Return value is the previous setting</returns>
        bool SetPrinterCollate(bool col);

        // TODO: convert return value to enum
        /// <summary>
        /// Defines the new colour setting (black and white only or use colours as drawn on sheets)
        /// </summary>
        /// <param name="colour">
        /// -1 means: use colours as drawn on sheets 
        /// 0: use only black and white
        /// </param>
        /// <returns></returns>
        int SetPrinterColour(int colour);

        /// <summary>
        /// Use e3.SetPrinterCopies to define the number of copies and the following sht.PrintOut commands will send n copies to the printer as one print job. 
        /// </summary>
        /// <param name="copies">Number of copies</param>
        /// <returns></returns>
        int SetPrinterCopies(int copies);

        // TODO: convert return and parameter value to enum
        /// <summary>
        /// Defines the new line width setting. Values other than those described above are not yet valid. 
        /// </summary>
        /// <param name="linewidth">
        /// -1 means: use line width as defined on sheets and scale them according to scaling parameters of methods prj.PrintOut and sht.PrintOut 
        /// 0: use line width on sheets but ignore scaling parameters</param>
        /// <returns></returns>
        double SetPrinterLinewidth(double linewidth);

        // TODO: convert parameter value to struct
        /// <summary>
        /// Set the margin settings: top, bottom, left, right in the predefined unit of measure.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        int SetPrinterMargins(double top, double bottom, double left, double right);

        /// <summary>
        ///  Defines the new default printer.
        /// </summary>
        /// <param name="name">The name must be entered as a string and match one of the installed Windows printers' names.
        /// To use a network printer, specify its name in the format
        /// \\computer\printerservicename</param>
        /// <returns></returns>
        int SetPrinterName(string name);

        /// <summary>
        /// Available since Build 2011-1010
        /// Enable or disable 'Print page numbers' option
        /// </summary>
        /// <param name="set"></param>
        /// <returns>Return value is the previous setting</returns>
        bool SetPrintPageNumbers(bool set);

        // TODO: convert return and parameters values to enum instead of int
        /// <summary>
        /// Available since Build 2011-1020
        /// Set print sheet order
        /// </summary>
        /// <returns></returns>
        int SetPrintSheetOrder(int set);

        /// <summary>
        /// Available since Build 2011-1010
        /// Enable or disable 'Select pages' option
        /// </summary>
        /// <param name="set"></param>
        /// <returns>Return value is the previous setting</returns>
        bool SetPrintSplitPages(bool set);

        /// <summary>
        /// Set new lifecycle to given project
        /// Note: After changing the lifecycle, new permissions are valid, that may result in the project no longer being able to be edited.
        /// Users of another group can edit it now and change its lifecycle.
        /// </summary>
        /// <param name="project">Project name</param>
        /// <param name="lifecycle">lifecycle = changes the lifecycle of given project, if lifecycle is a valid string</param>
        /// <returns></returns>
        bool SetProjectLifecycle(string project, string lifecycle);

        /// <summary>
        /// This method can be used to manipulate the return value. The default return value is 0. 
        /// </summary>
        /// <param name="value">value is the new return value to be defined</param>
        /// <returns>The previous value that was set before with e3.SetScriptReturn()</returns>
        int SetScriptReturn(int value);

        /// <summary>
        /// Define the template file (Settings... -> General -> Initial settings can be read from a file.) in project mode.
        /// </summary>
        /// <param name="templatefilename">Defines the file name templatefilename of the template file, which is used when creating new projects</param>
        /// <returns></returns>
        bool SetTemplateFile(string templatefilename);

        /// <summary>
        /// Define the template file (Settings... -> General -> Initial settings can be read from a file.) in DBE mode:
        /// </summary>
        /// <param name="templatefilename">Defines the file name templatefilename of the template file, which is used when creating new projects</param>
        /// <returns></returns>
        bool SetTemplateFileDBE(string templatefilename);

        [Obsolete("Unknown Method", false)]
        int SetTestMark(int num, int value);

        // TODO: convert parameter 'name' to enum
        // TODO: convert parameter 'active' and return values to enum
        /// <summary>
        /// Defines 'filename' as trigger 'name'. 'active' defines, whether the trigger is to be activated.
        /// </summary>
        /// <param name="name">Must always be defined. All trigger names are allowed that can be defined in the Registry.</param>
        /// <param name="filename">Must not be defined, when a trigger shall be activated or deactivated and the file name is already common from the registry or previous SetTrigger calls.</param>
        /// <param name="active">
        /// 0: deactivates a trigger (however, remembers the file name and file contents). 
        /// 1: activates an either known trigger or a new file defined through 'filename'.
        /// 2: activates an either known trigger or a new file defined through 'filename', however reloads the file even if the file name hasn't changed.
        /// =-1: permanently deletes a trigger(forgets the file name and file contents), when no 'filename' is defined.When a 'filename' is defined, its contents are re-read.In this case, the old state of the 'active' designation of the trigger remains unchanged.
        /// </param>
        /// <returns>The return value is the state of the 'active' flag before it might be realized (usually 0 or 1). When a defined 'filename' name is not readable, -1 is returned.When an invalid trigger 'name' is defined, -2 is returned.When the registry key EnableTriggerModifications doesn't exist or is 0, -3 is returned.</returns>
        int SetTrigger(string name, string filename, int active);

        /// <summary>
        /// Set trigger return value. 
        /// </summary>
        /// <param name="value">Value     -    symbolic name in Visual Basic/Visual Basic Script
        /// 1 - vbOK 
        /// 2 - vbCancel 
        /// 3 - vbAbort 
        /// 4 - vbRetry 
        /// 5 - vbIgnore 
        /// 6 - vbYes 
        /// 7 - vbNo</param>
        /// <returns> When no trigger is active at the time of calling, the return value is always 0 and no value is defined.
        /// Otherwise, the return value is value last defined for the trigger.
        /// When the trigger return value is not yet defined in the active trigger, the trigger's default value is returned (see description of the individual triggers). 
        /// </returns>
        int SetTriggerReturn(int value);

        /// <summary>
        /// Enable or disable 'Use sheet orientation' option in the Print dialog.
        /// </summary>
        /// <param name="set">If this option is checked (default setting), the printer's settings are ignored and the orientation is used depending on the sheet format. </param>
        /// <returns>Return value is the previous setting</returns>
        bool SetUseSheetOrientation(bool set);

        /// <summary>
        /// Handling application's display window: displays it in 'normal mode' and 'not in full screen mode'.
        /// </summary>
        /// <returns></returns>
        int ShowNormal();

        /// <summary>
        /// Stops execution of script for specified number of msec milliseconds.
        /// </summary>
        /// <param name="msec"></param>
        /// <returns></returns>
        int Sleep(int msec);

        /// <summary>
        /// Sorts the lines of a two-dimensional array, first by column 'sortindex1' and then all rows with the same value using 'sortindex2'. 
        /// In complex strings only the numeric part will be sorted, alphanumeric parts will be ignored.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rows">rows gives the number of lines(rows).</param>
        /// <param name="columns">columns gives the number of columns.</param>
        /// <param name="sortindex1">sortindex1 column number for first sorting.</param>
        /// <param name="sortindex2">sortindex2 column number for second sorting. If sortindex2 is less than 1, the second sorting event will be ignored.</param>
        /// <returns></returns>
        int SortArrayByIndex(ref object array, int rows, int columns, int sortindex1, int sortindex2);

        /// <summary>
        /// SortArrayByIndexEx( array, options ) sorts the 1 or 2 dimensional array according to options.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="options">
        /// options is arranged as follows: 
        /// options is a 2 dimensional array with n-lines and 3 columns.
        /// for each column according to which the array should be sorted, one line has to be in options.
        /// The first column of options contains the index of the column, according to which it should be sorted.
        /// The second column contains a sorting algorithm: 
        /// "0": for easy sorting(enough for numbers and easy strings).
        /// "1": more complex sorting.
        ///    E.g.before sorting: F1, F10, F1.1, F11, F2, F1.10, F1.11, F1.2... 
        ///    After sorting: F1, F1.1, F1.10, F1.11, F1.2, F2, F10, F11,...
        /// "2": tree sorting.
        ///    E.g.before sorting: F1, F10, F1.1, F11, F2, F1.10, F1.11, F1.2... 
        ///    After sorting: F1, F1.1, F1.2, F1.10, F1.11, F2, F10, F11,... 
        /// The third column displays whether it should be sorting ascending or descending: 
        /// "0": ascending
        /// "1": descending
        /// Note: The column's index starts with 1.
        /// </param>
        /// <returns>Return value when successful: "1", otherwise "0"</returns>
        int SortArrayByIndexEx(ref object array, ref object options);
    }
}