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

        public bool GetPrintCropMarks()
        {
            return ComObject.GetPrintCropMarks() == 1;
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

        public int GetProjectInformation(ref object filename, ref object type, ref object isDbe)
        {
            return ComObject.GetProjectInformation(ref filename, ref type, ref isDbe);
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

        public ReadOnlyCollection<string> GetScriptArguments()
        {
            object args = ComObject.GetScriptArguments();

            return new ReadOnlyCollection<string>(args.CastToIEnumerable<string>().ToList());
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

        public ReadOnlyCollection<int> GetSystemMenuItemIds()
        {
            object ids = null;
            ComObject.GetSystemMenuItemIds(ref ids);

            return new ReadOnlyCollection<int>(ids.CastToIEnumerable().ToList());
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

        public string GetTrigger(string name)
        {
            object filename = null;
            var result = ComObject.GetTrigger(name, ref filename);

            return result == -2 ? string.Empty : (string) filename;
        }

        public int GetTriggerReturn()
        {
            return ComObject.GetTriggerReturn();
        }

        public ReadOnlyCollection<int> GetUserMenuItemIds()
        {
            object ids = null;
            ComObject.GetUserMenuItemIds(ref ids);

            return new ReadOnlyCollection<int>(ids.CastToIEnumerable().ToList());
        }

        public bool GetUseSheetOrientation()
        {
            return ComObject.GetUseSheetOrientation() == 1;
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

        public bool IsBasic()
        {
            return ComObject.IsBasic() == 1;
        }

        public bool IsBoard()
        {
            return ComObject.IsBoard() == 1;
        }

        public bool IsCable()
        {
            return ComObject.IsCable() == 1;
        }

        public bool IsCaddy()
        {
            return ComObject.IsCaddy() == 1;
        }

        public bool IsCaddyBasic()
        {
            return ComObject.IsCaddyBasic() == 1;
        }

        public bool IsCaddyDemo()
        {
            return ComObject.IsCaddyDemo() == 1;
        }

        public bool IsCaddyEconomy()
        {
            return ComObject.IsCaddyEconomy() == 1;
        }

        public bool IsDemo()
        {
            return ComObject.IsDemo() == 1;
        }

        public bool IsEconomy()
        {
            return ComObject.IsEconomy() == 1;
        }

        public bool IsFluid()
        {
            return ComObject.IsFluid() == 1;
        }

        public bool IsFormboard()
        {
            return ComObject.IsFormboard() == 1;
        }

        public bool IsFunctionalDesign()
        {
            return ComObject.IsFunctionalDesign() == 1;
        }

        public bool IsLogic()
        {
            return ComObject.IsLogic() == 1;
        }

        public bool IsMultiuser()
        {
            return ComObject.IsMultiuser() == 1;
        }

        public bool IsPanel()
        {
            return ComObject.IsPanel() == 1;
        }

        public bool IsRedliner()
        {
            return ComObject.IsRedliner() == 1;
        }

        public bool IsSchema()
        {
            return ComObject.IsSchema() == 1;
        }

        public bool IsScriptRunning()
        {
            return ComObject.IsScriptRunning() == 1;
        }

        public bool IsSmallBusiness()
        {
            return ComObject.IsSmallBusiness() == 1;
        }

        public bool IsStudent()
        {
            return ComObject.IsStudent() == 1;
        }

        public bool IsViewer()
        {
            return ComObject.IsViewer() == 1;
        }

        public bool IsViewPlus()
        {
            return ComObject.IsViewPlus() == 1;
        }

        public bool IsWago()
        {
            return ComObject.IsWago() == 1;
        }

        public bool IsWagoDemo()
        {
            return ComObject.IsWagoDemo() == 1;
        }

        public bool IsWire()
        {
            return ComObject.IsWire() == 1;
        }

        public bool IsWireWorks()
        {
            return ComObject.IsWireWorks() == 1;
        }

        public int Maximize()
        {
            return ComObject.Maximize();
        }

        public int Minimize()
        {
            return ComObject.Minimize();
        }

        public int PutError(bool wait, string text, int itemId = 0)
        {
            return ComObject.PutError(wait ? 1 : 0, text, itemId);
        }

        public int PutInfo(bool wait, string text, int itemId = 0)
        {
            return ComObject.PutInfo(wait ? 1 : 0, text, itemId);
        }

        public int PutMessage(string text, int itemId = 0)
        {
            return ComObject.PutMessage(text, itemId);
        }

        public int PutMultiuserLogMessage(string source, string text)
        {
            return ComObject.PutMultiuserLogMessage(source, text);
        }

        public int PutVerify(bool wait, string text, int itemId = 0)
        {
            return ComObject.PutVerify(wait ? 1 : 0, text, itemId);
        }

        public int PutWarning(bool wait, string text, int itemId = 0)
        {
            return ComObject.PutWarning(wait ? 1 : 0, text, itemId);
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

        public int SelectComponentFromTable(ref object componentName, ref object componentVersion)
        {
            return ComObject.SelectComponentFromTable(ref componentName, ref componentVersion);
        }

        public int SetActualDatabase(string dbname)
        {
            return ComObject.SetActualDatabase(dbname);
        }

        public int SetDefinedDatabaseConnectionStrings(string dbname, string cmpCs, string symCs, string cnfCs)
        {
            return ComObject.SetDefinedDatabaseConnectionStrings(dbname, cmpCs, symCs, cnfCs);
        }

        public int SetEnableInteractiveDialogs(bool value)
        {
           return ComObject.SetEnableInteractiveDialogs(value ? 1 : 0);
        }

        public int SetLanguageDatabase(string dbname)
        {
            return ComObject.SetLanguageDatabase(dbname);
        }

        public int SetLogfileName(string logfile, int index = 0)
        {
            return ComObject.SetLogfileName(logfile, index);
        }

        public int SetModalWindow(IntPtr hWnd)
        {
            return ComObject.SetModalWindow(ref hWnd);
        }

        public bool SetPrintCropMarks(bool set)
        {
            return ComObject.SetPrintCropMarks(set ? 1 : 0) == 1;
        }

        public bool SetPrinterCollate(bool col)
        {
            return ComObject.SetPrinterCollate(col ? 1 : 0) == 1;
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

        public bool SetPrintPageNumbers(bool set)
        {
            return ComObject.SetPrintPageNumbers(set ? 1 : 0) == 1;
        }

        public int SetPrintSheetOrder(int set)
        {
            return ComObject.SetPrintSheetOrder(set);
        }

        public bool SetPrintSplitPages(bool set)
        {
            return ComObject.SetPrintSplitPages(set ? 1 : 0) == 1;
        }

        public bool SetProjectLifecycle(string project, string lifecycle)
        {
            return ComObject.SetProjectLifecycle(project, lifecycle) == 1;
        }

        public int SetScriptReturn(int value)
        {
            return ComObject.SetScriptReturn(value);
        }

        public bool SetTemplateFile(string templatefilename)
        {
            return ComObject.SetTemplateFile(templatefilename) == 1;
        }

        public bool SetTemplateFileDBE(string templatefilename)
        {
            return ComObject.SetTemplateFileDBE(templatefilename) == 1;
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

        public bool SetUseSheetOrientation(bool set)
        {
            return ComObject.SetUseSheetOrientation(set ? 1 : 0) == 1;
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