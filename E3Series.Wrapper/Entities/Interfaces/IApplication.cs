using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <summary>
    /// Interface for class-wrapper of e3Apllication COM object
    /// </summary>
    public interface IApplication : IComObjectProvider
    {
        int AvoidAutomaticClosing(int avoid = 1);
        int BeginForeignTask();
        void ClearOutputWindow();
        void ClearResultWindow();
        object CreateDllObject();

        /// <summary>
        /// Returns an object, that enables the use of methods for reading and writing to a project (may also be called a job or drawing).
        /// </summary>
        /// <returns></returns>
        IJob CreateJobObject();

        object CreateMenuItemObject();
        object CreateWespeObject();
        int Display();
        int EnableCOM(string password);
        int EnableLogfile(int en);
        int EndForeignTask();
        int FreeLicense(string feature);
        int FreeLicensePermanent(string feature);
        string fullname();
        string GetActualDatabase();
        int GetAvailableLanguages(ref object languages);
        string GetBuild();
        string GetComponentDatabase();
        string GetComponentDatabaseTableSchema();
        string GetConfigurationDatabase();
        string GetConfigurationDatabaseTableSchema();
        int GetDatabaseTableSelectedComponents(ref object ComponentArray, ref object VersionArray);
        int GetDatabaseTreeSelectedComponents(out object ComponentArray, out object VersionArray);
        int GetDatabaseTreeSelectedModels(out object ModelArray);
        int GetDatabaseTreeSelectedSymbols(out object SymbolArray, out object VersionArray);
        int GetDefinedDatabaseConnectionStrings(string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs);
        int GetDefinedDatabases(out object dbnames);
        int GetEnableInteractiveDialogs();
        int GetErrorCount();
        string GetFullName();
        int GetId();
        int GetInfoCount();
        int GetInstallationLanguage();
        string GetInstallationPath();
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