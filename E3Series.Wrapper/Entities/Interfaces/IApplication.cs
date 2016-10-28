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
        int GetPrintCropMarks();

        /// <summary>
        /// Returns the current colour setting 
        /// </summary>
        /// <returns>
        /// -1 means: use colours as drawn on sheets 
        /// 0: use only black and white
        /// </returns>
        int GetPrinterColour();

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
        /// <param name="text"></param>
        /// <param name="itemId">Id of the item for hyperlink</param>
        /// <returns></returns>
        int PutError(bool wait, string text, int itemId = 0);

        int PutInfo(int ok, string text, int item = 0);
        int PutMessage(string text, int item = 0);
        int PutMultiuserLogMessage(string source, string text);
        int PutVerify(int ok, string text, int item = 0);
        int PutWarning(int ok, string text, int item = 0);
        int Quit();
        int ResetErrorCount();
        int ResetInfoCount();
        int ResetVerifyCount();
        int ResetWarningCount();
        int Run(string filename, ref object arguments);
        object ScriptArguments();
        string ScriptFullName();
        string ScriptName();
        int SelectComponentFromTable(ref object ComponentName, ref object ComponentVersion);
        int SetActualDatabase(string dbname);
        int SetDefinedDatabaseConnectionStrings(string dbname, string cmp_cs, string sym_cs, string cnf_cs);
        int SetEnableInteractiveDialogs(int value);
        int SetLanguageDatabase(string dbname);
        int SetLogfileName(string logfile, int index = 0);
        int SetModalWindow(ref object hWnd);
        int SetPrintCropMarks(int set);
        int SetPrinterCollate(int col);
        int SetPrinterColour(int colour);
        int SetPrinterCopies(int copies);
        double SetPrinterLinewidth(double linewidth);
        int SetPrinterMargins(double top, double bottom, double left, double right);
        int SetPrinterName(string name);
        int SetPrintPageNumbers(int set);
        int SetPrintSheetOrder(int set);
        int SetPrintSplitPages(int set);
        int SetProjectLifecycle(string project, string lifecycle);
        int SetScriptReturn(int value);
        int SetTemplateFile(string templatefilename);
        int SetTemplateFileDBE(string templatefilename);
        int SetTestMark(int num, int value);
        int SetTrigger(string name, string filename, int active);
        int SetTriggerReturn(int value);
        int SetUseSheetOrientation(int set);
        int ShowNormal();
        int Sleep(int msec);
        int SortArrayByIndex(ref object array, int rows, int columns, int sortindex1, int sortindex2);
        int SortArrayByIndexEx(ref object array, ref object options);
    }
}