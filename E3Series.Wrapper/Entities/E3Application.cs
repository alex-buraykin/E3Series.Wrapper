using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Extensions;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <summary>
    /// Implementation of IApplication interface
    /// </summary>
    public class E3Application : ComWrapper, IApplication
    {
        #region Constructor

        protected internal E3Application(object comObject)
            : base(null, () => comObject)
        {
        }

        #endregion

        #region IApplication Members

        public int AvoidAutomaticClosing(bool avoid = true)
        {
            return ComObject.AvoidAutomaticClosing(avoid ? 1 : 0);
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

        public object CreateDllObject()
        {
            return ComObject.CreateDllObject();
        }

        public IJob CreateJobObject()
        {
            return this.CreateObject<IJob>();
        }

        public object CreateMenuItemObject()
        {
            return ComObject.CreateMenuItemObject();
        }

        public object CreateWespeObject()
        {
            return ComObject.CreateWespeObject();
        }

        public int Display()
        {
            return ComObject.Display();
        }

        public int EnableCOM(string password)
        {
            return ComObject.EnableCOM(password);
        }

        public int EnableLogfile(bool enabled)
        {
            return ComObject.EnableLogfile(enabled ? 1 : 0);
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

        public string FullName()
        {
            return ComObject.fullname();
        }

        public string GetActualDatabase()
        {
            return ComObject.GetActualDatabase();
        }

        public ReadOnlyCollection<string> GetAvailableLanguages()
        {
            object languages = null;
            ComObject.GetAvailableLanguages(ref languages);

            return new ReadOnlyCollection<string>(languages.CastToIEnumerable<string>().ToList());
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

        public int GetDatabaseTableSelectedComponents(ref object componentArray, ref object versionArray)
        {
            return ComObject.GetDatabaseTableSelectedComponents(ref componentArray, ref versionArray);
        }

        public int GetDatabaseTreeSelectedComponents(out object componentArray, out object versionArray)
        {
            return ComObject.GetDatabaseTreeSelectedComponents(out componentArray, out versionArray);
        }

        public int GetDatabaseTreeSelectedModels(out object modelArray)
        {
            return ComObject.GetDatabaseTreeSelectedModels(out modelArray);
        }

        public int GetDatabaseTreeSelectedSymbols(out object symbolArray, out object versionArray)
        {
            return ComObject.GetDatabaseTreeSelectedSymbols(out symbolArray, out versionArray);
        }

        public int GetDefinedDatabaseConnectionStrings(string dbname, out object cmpCs, out object symCs, out object cnfCs)
        {
            return ComObject.GetDefinedDatabaseConnectionStrings(dbname, out cmpCs, out symCs, out cnfCs);
        }

        public ReadOnlyCollection<string> GetDefinedDatabases()
        {
            object dbnames;
            ComObject.GetDefinedDatabases(out dbnames);

            return new ReadOnlyCollection<string>(dbnames.CastToIEnumerable<string>().ToList());
        }

        public bool GetEnableInteractiveDialogs()
        {
            return ComObject.GetEnableInteractiveDialogs() == 1;
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

        public int GetJobCount()
        {
            return ComObject.GetJobCount();
        }

        public ReadOnlyCollection<int> GetJobIds()
        {
            object ids = null;
            ComObject.GetJobIds(ref ids);

            return new ReadOnlyCollection<int>(ids.CastToIEnumerable().ToList());
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

        public IntPtr GetModalWindow()
        {
            return (IntPtr) ComObject.GetModalWindow();
        }

        public KeyValuePair<int, string> GetMultiuserFolderPath()
        {
            object path;
            var id = ComObject.GetMultiuserFolderPath(out path);

            return new KeyValuePair<int, string>(id, (string) path);
        }

        public ReadOnlyCollection<string> GetMultiuserProjects()
        {
            object names = null;
            ComObject.GetMultiuserProjects(ref names);

            return new ReadOnlyCollection<string>(names.CastToIEnumerable<string>().ToList());
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public object GetPluginObject(ref object plugin)
        {
            return ComObject.GetPluginObject(ref plugin);
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

        public bool GetPrintPageNumbers()
        {
            return ComObject.GetPrintPageNumbers() == 1;
        }

        public int GetPrintSheetOrder()
        {
            return ComObject.GetPrintSheetOrder();
        }

        public bool GetPrintSplitPages()
        {
            return ComObject.GetPrintSplitPages() == 1;
        }

        public object GetProcessProperty(string what)
        {
            return ComObject.GetProcessProperty(what);
        }

        public int GetProjectInformation(ref object filename, ref object type, ref object is_dbe)
        {
            return ComObject.GetProjectInformation(ref filename, ref type, ref is_dbe);
        }

        public string GetProjectLifecycle(string project)
        {
            return ComObject.GetProjectLifecycle(project);
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

        public string GetServerName()
        {
            return ComObject.GetServerName();
        }

        public int GetServerPort()
        {
            return ComObject.GetServerPort();
        }

        public string GetSymbolDatabase()
        {
            return ComObject.GetSymbolDatabase();
        }

        public string GetSymbolDatabaseTableSchema()
        {
            return ComObject.GetSymbolDatabaseTableSchema();
        }

        public int GetSystemMenuItemIds(ref object ids)
        {
            return ComObject.GetSystemMenuItemIds(ref ids);
        }

        public string GetTemplateFile()
        {
            return ComObject.GetTemplateFile();
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

        public int GetUserMenuItemIds(ref object ids)
        {
            return ComObject.GetUserMenuItemIds(ref ids);
        }

        public int GetUseSheetOrientation()
        {
            return ComObject.GetUseSheetOrientation();
        }

        public int GetVerifyCount()
        {
            return ComObject.GetVerifyCount();
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

        public int PutMultiuserLogMessage(string source, string text)
        {
            return ComObject.PutMultiuserLogMessage(source, text);
        }

        public int PutVerify(int ok, string text, int item = 0)
        {
            return ComObject.PutVerify(ok, text, item);
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

        public int ResetVerifyCount()
        {
            return ComObject.ResetVerifyCount();
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

        public int SetProjectLifecycle(string project, string lifecycle)
        {
            return ComObject.SetProjectLifecycle(project, lifecycle);
        }

        public int SetScriptReturn(int value)
        {
            return ComObject.SetScriptReturn(value);
        }

        public int SetTemplateFile(string templatefilename)
        {
            return ComObject.SetTemplateFile(templatefilename);
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

        #endregion
    }
}