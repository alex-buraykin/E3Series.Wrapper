﻿using System.Collections.Generic;
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
        IList<string> GetAvailableLanguages();

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
        /// <param name="ComponentArray">Contains selected component from the Component Table </param>
        /// <param name="VersionArray">Contains version numbers</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTableSelectedComponents(ref object ComponentArray, ref object VersionArray);

        // TODO: Convert to return array
        /// <summary>
        /// Available since Build 2014-1400
        /// Get selected components from the Database Tree
        /// </summary>
        /// <param name="ComponentArray">Contains selected components from the Database Tree</param>
        /// <param name="VersionArray">Contains version numbers</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTreeSelectedComponents(out object ComponentArray, out object VersionArray);

        // TODO: Convert to return array
        /// <summary>
        /// Available since Build 2014-1400
        /// Get selected models from the Database and Model Trees 
        /// cnt number of objects found
        /// </summary>
        /// <param name="ModelArray">Contains selected models from the Database and Model Trees</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTreeSelectedModels(out object ModelArray);

        // TODO: Convert to return array
        /// <summary>
        /// Get selected symbols from the Database, Symbol and Misc Trees
        /// </summary>
        /// <param name="SymbolArray">Contains selected symbols from the Database, Symbol and Misc Trees</param>
        /// <param name="VersionArray">Contains version numbers</param>
        /// <returns>Number of objects found</returns>
        int GetDatabaseTreeSelectedSymbols(out object SymbolArray, out object VersionArray);

        // TODO: Convert to return array
        /// <summary>
        /// Returns for dbname the configured connection strings. 
        /// </summary>
        /// <param name="dbname">As dbname only names are supported that are visible in the component tab</param>
        /// <param name="cmp_cs">Components database connection string</param>
        /// <param name="sym_cs">Symbols database connection string</param>
        /// <param name="cnf_cs">Configuration database connection string</param>
        /// <returns></returns>
        int GetDefinedDatabaseConnectionStrings(string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs);

        /// <summary>
        /// Returns an array of database names, that can be used with e3.SetActualDatabase(). 
        /// Note: Only names that are visible in the component tab are visible.
        /// </summary>
        /// <returns></returns>
        IList<string> GetDefinedDatabases();

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

        int GetJobIds(ref object ids);
        string GetLanguageDatabase();
        string GetLanguageDatabaseTableSchema();
        int GetLicense(string feature);
        int GetLicensePermanent(string feature);
        string GetLogfileName(int index = 0);
        object GetModalWindow();
        int GetMultiuserFolderPath(out object path);
        int GetMultiuserProjects(ref object name);
        string GetName();
        object GetPluginObject(ref object Plugin);
        int GetPrintCropMarks();
        int GetPrinterColour();
        double GetPrinterLinewidth();
        int GetPrinterMargins(ref object top, ref object bottom, ref object left, ref object right);
        string GetPrinterName();
        int GetPrintPageNumbers();
        int GetPrintSheetOrder();
        int GetPrintSplitPages();
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