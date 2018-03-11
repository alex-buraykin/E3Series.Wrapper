using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3DbeApplicationProxy : E3ProxyBase
    {
        public E3DbeApplicationProxy(object comObject) : base(comObject)
        {
        }

        public int AvoidAutomaticClosing(int avoid = 1)
        {
            return ComObject.AvoidAutomaticClosing(avoid);
        }

        public int BeginForeignTask()
        {
            return ComObject.BeginForeignTask();
        }

        public void ClearOutputWindow()
        {
            ComObject.ClearOutputWindow();
        }

        public void ClearResultWindow()
        {
            ComObject.ClearResultWindow();
        }

        public int DeleteComponent(string name, string version)
        {
            return ComObject.DeleteComponent(name, version);
        }

        public int DeleteModel(string name)
        {
            return ComObject.DeleteModel(name);
        }

        public int DeleteSymbol(string name, string version)
        {
            return ComObject.DeleteSymbol(name, version);
        }

        public int Display()
        {
            return ComObject.Display();
        }

        public int EditComponent(string name, string version)
        {
            return ComObject.EditComponent(name, version);
        }

        public int EditModel(string name)
        {
            return ComObject.EditModel(name);
        }

        public int EditSymbol(string name, string version)
        {
            return ComObject.EditSymbol(name, version);
        }

        public int EnableCOM(string password)
        {
            return ComObject.EnableCOM(password);
        }

        public int EnableLogfile(int en)
        {
            return ComObject.EnableLogfile(en);
        }

        public int EndForeignTask()
        {
            return ComObject.EndForeignTask();
        }

        public int FreeLicense(string feature)
        {
            return ComObject.FreeLicense(feature);
        }

        public int FreeLicensePermanent(string feature)
        {
            return ComObject.FreeLicensePermanent(feature);
        }

        public string fullname()
        {
            return ComObject.fullname();
        }

        public string GetActualDatabase()
        {
            return ComObject.GetActualDatabase();
        }

        public int GetAvailableLanguages(ref object languages)
        {
            return ComObject.GetAvailableLanguages(ref languages);
        }

        public string GetBuild()
        {
            return ComObject.GetBuild();
        }

        public string GetComponentDatabase()
        {
            return ComObject.GetComponentDatabase();
        }

        public string GetComponentDatabaseTableSchema()
        {
            return ComObject.GetComponentDatabaseTableSchema();
        }

        public string GetConfigurationDatabase()
        {
            return ComObject.GetConfigurationDatabase();
        }

        public string GetConfigurationDatabaseTableSchema()
        {
            return ComObject.GetConfigurationDatabaseTableSchema();
        }

        public int GetDatabaseTableSelectedComponents(out object ComponentArray, out object VersionArray)
        {
            return ComObject.GetDatabaseTableSelectedComponents(out ComponentArray, out VersionArray);
        }

        public int GetDatabaseTreeSelectedComponents(out object ComponentName, out object version)
        {
            return ComObject.GetDatabaseTreeSelectedComponents(out ComponentName, out version);
        }

        public int GetDatabaseTreeSelectedModels(out object ModelName)
        {
            return ComObject.GetDatabaseTreeSelectedModels(out ModelName);
        }

        public int GetDatabaseTreeSelectedSymbols(out object SymbolName, out object version)
        {
            return ComObject.GetDatabaseTreeSelectedSymbols(out SymbolName, out version);
        }

        public int GetDefinedDatabaseConnectionStrings(string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs)
        {
            return ComObject.GetDefinedDatabaseConnectionStrings(dbname, out cmp_cs, out sym_cs, out cnf_cs);
        }

        public int GetDefinedDatabases(out object dbnames)
        {
            return ComObject.GetDefinedDatabases(out dbnames);
        }

        public int GetEnableInteractiveDialogs()
        {
            return ComObject.GetEnableInteractiveDialogs();
        }

        public int GetErrorCount()
        {
            return ComObject.GetErrorCount();
        }

        public string GetFullName()
        {
            return ComObject.GetFullName();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInfoCount()
        {
            return ComObject.GetInfoCount();
        }

        public int GetInstallationLanguage()
        {
            return ComObject.GetInstallationLanguage();
        }

        public string GetInstallationPath()
        {
            return ComObject.GetInstallationPath();
        }

        public string GetLanguageDatabase()
        {
            return ComObject.GetLanguageDatabase();
        }

        public string GetLanguageDatabaseTableSchema()
        {
            return ComObject.GetLanguageDatabaseTableSchema();
        }

        public int GetLicense(string feature)
        {
            return ComObject.GetLicense(feature);
        }

        public int GetLicensePermanent(string feature)
        {
            return ComObject.GetLicensePermanent(feature);
        }

        public string GetLogfileName(int index = 0)
        {
            return ComObject.GetLogfileName(index);
        }

        public object GetModalWindow()
        {
            return ComObject.GetModalWindow();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public object GetPluginObject(ref object Plugin)
        {
            return ComObject.GetPluginObject(ref Plugin);
        }

        public int GetPrintCropMarks()
        {
            return ComObject.GetPrintCropMarks();
        }

        public int GetPrinterColour()
        {
            return ComObject.GetPrinterColour();
        }

        public double GetPrinterLinewidth()
        {
            return ComObject.GetPrinterLinewidth();
        }

        public int GetPrinterMargins(ref object top, ref object bottom, ref object left, ref object right)
        {
            return ComObject.GetPrinterMargins(ref top, ref bottom, ref left, ref right);
        }

        public string GetPrinterName()
        {
            return ComObject.GetPrinterName();
        }

        public int GetPrintPageNumbers()
        {
            return ComObject.GetPrintPageNumbers();
        }

        public int GetPrintSheetOrder()
        {
            return ComObject.GetPrintSheetOrder();
        }

        public int GetPrintSplitPages()
        {
            return ComObject.GetPrintSplitPages();
        }

        public object GetProcessProperty(string what)
        {
            return ComObject.GetProcessProperty(what);
        }

        public int GetProjectInformation(ref object filename, ref object type, ref object is_dbe)
        {
            return ComObject.GetProjectInformation(ref filename, ref type, ref is_dbe);
        }

        public string GetProvider(string dbname)
        {
            return ComObject.GetProvider(dbname);
        }

        public string GetRegistryVersion()
        {
            return ComObject.GetRegistryVersion();
        }

        public object GetScriptArguments()
        {
            return ComObject.GetScriptArguments();
        }

        public int GetScriptReturn()
        {
            return ComObject.GetScriptReturn();
        }

        public string GetSymbolDatabase()
        {
            return ComObject.GetSymbolDatabase();
        }

        public string GetSymbolDatabaseTableSchema()
        {
            return ComObject.GetSymbolDatabaseTableSchema();
        }

        public string GetTemplateFileDBE()
        {
            return ComObject.GetTemplateFileDBE();
        }

        public int GetTestMark(int num)
        {
            return ComObject.GetTestMark(num);
        }

        public string GetTranslatedText(string text, string language)
        {
            return ComObject.GetTranslatedText(text, language);
        }

        public int GetTrigger(string name, ref object filename)
        {
            return ComObject.GetTrigger(name, ref filename);
        }

        public int GetTriggerReturn()
        {
            return ComObject.GetTriggerReturn();
        }

        public int GetUseSheetOrientation()
        {
            return ComObject.GetUseSheetOrientation();
        }

        public string GetVersion()
        {
            return ComObject.GetVersion();
        }

        public int GetWarningCount()
        {
            return ComObject.GetWarningCount();
        }

        public string GetWorkspaceName()
        {
            return ComObject.GetWorkspaceName();
        }

        public int Include(string text)
        {
            return ComObject.Include(text);
        }

        public int IsBasic()
        {
            return ComObject.IsBasic();
        }

        public int IsBoard()
        {
            return ComObject.IsBoard();
        }

        public int IsCable()
        {
            return ComObject.IsCable();
        }

        public int IsCaddy()
        {
            return ComObject.IsCaddy();
        }

        public int IsCaddyBasic()
        {
            return ComObject.IsCaddyBasic();
        }

        public int IsCaddyDemo()
        {
            return ComObject.IsCaddyDemo();
        }

        public int IsCaddyEconomy()
        {
            return ComObject.IsCaddyEconomy();
        }

        public int IsDemo()
        {
            return ComObject.IsDemo();
        }

        public int IsEconomy()
        {
            return ComObject.IsEconomy();
        }

        public int IsFluid()
        {
            return ComObject.IsFluid();
        }

        public int IsFormboard()
        {
            return ComObject.IsFormboard();
        }

        public int IsFunctionalDesign()
        {
            return ComObject.IsFunctionalDesign();
        }

        public int IsLogic()
        {
            return ComObject.IsLogic();
        }

        public int IsMultiuser()
        {
            return ComObject.IsMultiuser();
        }

        public int IsPanel()
        {
            return ComObject.IsPanel();
        }

        public int IsRedliner()
        {
            return ComObject.IsRedliner();
        }

        public int IsSchema()
        {
            return ComObject.IsSchema();
        }

        public int IsScriptRunning()
        {
            return ComObject.IsScriptRunning();
        }

        public int IsSmallBusiness()
        {
            return ComObject.IsSmallBusiness();
        }

        public int IsStudent()
        {
            return ComObject.IsStudent();
        }

        public int IsViewer()
        {
            return ComObject.IsViewer();
        }

        public int IsViewPlus()
        {
            return ComObject.IsViewPlus();
        }

        public int IsWago()
        {
            return ComObject.IsWago();
        }

        public int IsWagoDemo()
        {
            return ComObject.IsWagoDemo();
        }

        public int IsWire()
        {
            return ComObject.IsWire();
        }

        public int IsWireWorks()
        {
            return ComObject.IsWireWorks();
        }

        public int Maximize()
        {
            return ComObject.Maximize();
        }

        public int Minimize()
        {
            return ComObject.Minimize();
        }

        public int NewComponent(string name, string version, string baseName, string baseVersion, int flags = 0)
        {
            return ComObject.NewComponent(name, version, baseName, baseVersion, flags);
        }

        public int NewModel(string name, string baseName, int flags = 0)
        {
            return ComObject.NewModel(name, baseName, flags);
        }

        public int NewSymbol(string name, string version, string baseName, string baseVersion, int flags = 0)
        {
            return ComObject.NewSymbol(name, version, baseName, baseVersion, flags);
        }

        public int PutError(int ok, string text, int item = 0)
        {
            return ComObject.PutError(ok, text, item);
        }

        public int PutInfo(int ok, string text, int item = 0)
        {
            return ComObject.PutInfo(ok, text, item);
        }

        public int PutMessage(string text, int item = 0)
        {
            return ComObject.PutMessage(text, item);
        }

        public int PutWarning(int ok, string text, int item = 0)
        {
            return ComObject.PutWarning(ok, text, item);
        }

        public int Quit()
        {
            return ComObject.Quit();
        }

        public int ResetErrorCount()
        {
            return ComObject.ResetErrorCount();
        }

        public int ResetInfoCount()
        {
            return ComObject.ResetInfoCount();
        }

        public int ResetWarningCount()
        {
            return ComObject.ResetWarningCount();
        }

        public int Run(string filename, ref object arguments)
        {
            return ComObject.Run(filename, ref arguments);
        }

        public object ScriptArguments()
        {
            return ComObject.ScriptArguments();
        }

        public string ScriptFullName()
        {
            return ComObject.ScriptFullName();
        }

        public string ScriptName()
        {
            return ComObject.ScriptName();
        }

        public int SelectComponentFromTable(ref object ComponentName, ref object ComponentVersion)
        {
            return ComObject.SelectComponentFromTable(ref ComponentName, ref ComponentVersion);
        }

        public int SetActualDatabase(string dbname)
        {
            return ComObject.SetActualDatabase(dbname);
        }

        public int SetDefinedDatabaseConnectionStrings(string dbname, string cmp_cs, string sym_cs, string cnf_cs)
        {
            return ComObject.SetDefinedDatabaseConnectionStrings(dbname, cmp_cs, sym_cs, cnf_cs);
        }

        public int SetEnableInteractiveDialogs(int value)
        {
            return ComObject.SetEnableInteractiveDialogs(value);
        }

        public int SetLanguageDatabase(string dbname)
        {
            return ComObject.SetLanguageDatabase(dbname);
        }

        public int SetLogfileName(string logfile, int index = 0)
        {
            return ComObject.SetLogfileName(logfile, index);
        }

        public int SetModalWindow(ref object hWnd)
        {
            return ComObject.SetModalWindow(ref hWnd);
        }

        public int SetPrintCropMarks(int set)
        {
            return ComObject.SetPrintCropMarks(set);
        }

        public int SetPrinterCollate(int col)
        {
            return ComObject.SetPrinterCollate(col);
        }

        public int SetPrinterColour(int colour)
        {
            return ComObject.SetPrinterColour(colour);
        }

        public int SetPrinterCopies(int copies)
        {
            return ComObject.SetPrinterCopies(copies);
        }

        public double SetPrinterLinewidth(double linewidth)
        {
            return ComObject.SetPrinterLinewidth(linewidth);
        }

        public int SetPrinterMargins(double top, double bottom, double left, double right)
        {
            return ComObject.SetPrinterMargins(top, bottom, left, right);
        }

        public int SetPrinterName(string name)
        {
            return ComObject.SetPrinterName(name);
        }

        public int SetPrintPageNumbers(int set)
        {
            return ComObject.SetPrintPageNumbers(set);
        }

        public int SetPrintSheetOrder(int set)
        {
            return ComObject.SetPrintSheetOrder(set);
        }

        public int SetPrintSplitPages(int set)
        {
            return ComObject.SetPrintSplitPages(set);
        }

        public int SetScriptReturn(int value)
        {
            return ComObject.SetScriptReturn(value);
        }

        public int SetTemplateFileDBE(string templatefilename)
        {
            return ComObject.SetTemplateFileDBE(templatefilename);
        }

        public int SetTestMark(int num, int value)
        {
            return ComObject.SetTestMark(num, value);
        }

        public int SetTrigger(string name, string filename, int active)
        {
            return ComObject.SetTrigger(name, filename, active);
        }

        public int SetTriggerReturn(int value)
        {
            return ComObject.SetTriggerReturn(value);
        }

        public int SetUseSheetOrientation(int set)
        {
            return ComObject.SetUseSheetOrientation(set);
        }

        public int ShowNormal()
        {
            return ComObject.ShowNormal();
        }

        public int Sleep(int msec)
        {
            return ComObject.Sleep(msec);
        }

        public int SortArrayByIndex(ref object array, int rows, int columns, int sortindex1, int sortindex2)
        {
            return ComObject.SortArrayByIndex(ref array, rows, columns, sortindex1, sortindex2);
        }

        public int SortArrayByIndexEx(ref object array, ref object options)
        {
            return ComObject.SortArrayByIndexEx(ref array, ref options);
        }
    }
}