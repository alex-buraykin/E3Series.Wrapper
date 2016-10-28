using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <summary>
    /// Interface for class-wrapper of e3Apllication COM object (E3.series COM version 16.5)
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

        int FreeLicense(string feature);

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
        /// Get count of info messages
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

        int GetLicense(string feature);

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

        object GetProcessProperty(string what);
        int GetProjectInformation(ref object filename, ref object type, ref object is_dbe);
        string GetProjectLifecycle(string project);
        string GetProvider(string dbname);
        string GetRegistryVersion();
        object GetScriptArguments();
        int GetScriptReturn();
        string GetServerName();
        int GetServerPort();
        string GetSymbolDatabase();
        string GetSymbolDatabaseTableSchema();
        int GetSystemMenuItemIds(ref object ids);
        string GetTemplateFile();
        string GetTemplateFileDBE();
        int GetTestMark(int num);
        string GetTranslatedText(string text, string language);
        int GetTrigger(string name, ref object filename);
        int GetTriggerReturn();
        int GetUserMenuItemIds(ref object ids);
        int GetUseSheetOrientation();
        int GetVerifyCount();
        string GetVersion();
        int GetWarningCount();
        string GetWorkspaceName();
        int Include(string text);
        int IsBasic();
        int IsBoard();
        int IsCable();
        int IsCaddy();
        int IsCaddyBasic();
        int IsCaddyDemo();
        int IsCaddyEconomy();
        int IsDemo();
        int IsEconomy();
        int IsFluid();
        int IsFormboard();
        int IsFunctionalDesign();
        int IsLogic();
        int IsMultiuser();
        int IsPanel();
        int IsRedliner();
        int IsSchema();
        int IsScriptRunning();
        int IsSmallBusiness();
        int IsStudent();
        int IsViewer();
        int IsViewPlus();
        int IsWago();
        int IsWagoDemo();
        int IsWire();
        int IsWireWorks();
        int Maximize();
        int Minimize();
        int PutError(int ok, string text, int item = 0);
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