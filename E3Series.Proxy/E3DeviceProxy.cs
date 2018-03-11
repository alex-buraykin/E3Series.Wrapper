using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3DeviceProxy : E3ProxyBase
    {
        public E3DeviceProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttibuteValue(string name, string value)
        {
            return ComObject.AddAttibuteValue(name, value);
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddToAssembly()
        {
            return ComObject.AddToAssembly();
        }

        public int AddToAssembly(ref object ids, int position = 0, int before = 0)
        {
            return ComObject.AddToAssembly(ref ids, position, before);
        }

        public int AddToInstallationSpace()
        {
            return ComObject.AddToInstallationSpace();
        }

        public int AddToInstallationSpace(ref object ids)
        {
            return ComObject.AddToInstallationSpace(ref ids);
        }

        public int AddToOverbraid()
        {
            return ComObject.AddToOverbraid();
        }

        public int AddToOverbraid(ref object ids, int position = 0, int before = 0)
        {
            return ComObject.AddToOverbraid(ref ids, position, before);
        }

        public int AssignAsVariantInstance(int devid, string expression)
        {
            return ComObject.AssignAsVariantInstance(devid, expression);
        }

        public int AssignFunctionalUnits()
        {
            return ComObject.AssignFunctionalUnits();
        }

        public int AssignFunctionalUnits(ref object ids)
        {
            return ComObject.AssignFunctionalUnits(ref ids);
        }

        public int AssignFunctionalUnitsDynamic(string name, string assignment, string location, int type)
        {
            return ComObject.AssignFunctionalUnitsDynamic(name, assignment, location, type);
        }

        public int AssignFunctionalUnitsDynamic(string name, string assignment, string location, int type, ref object ids)
        {
            return ComObject.AssignFunctionalUnitsDynamic(name, assignment, location, type, ref ids);
        }

        public int Create(string name, string assignment, string location, string comp, string vers, int after)
        {
            return ComObject.Create(name, assignment, location, comp, vers, after);
        }

        public int Create2DView(int modi, string name, string symbol, int position, int before)
        {
            return ComObject.Create2DView(modi, name, symbol, position, before);
        }

        public int Create2DViewEx(int modi, string name, string symbol, int position = 0, int before = 0, int shtId = 0,
            double xMin = 0, double yMin = 0, double xMax = 0, double yMax = 0, double scale = 0)
        {
            return ComObject.Create2DViewEx(modi, name, symbol, position, before, shtId, xMin, yMin, xMax, yMax, scale);
        }

        public int CreateAssembly()
        {
            return ComObject.CreateAssembly();
        }

        public int CreateAssembly(ref object ids)
        {
            return ComObject.CreateAssembly(ref ids);
        }

        public int CreateBlock(string name = null, string assignment = null, string location = null, string cmpname = null,
            string version = null, string filename = null)
        {
            return ComObject.CreateBlock(name, assignment, location, cmpname, version, filename);
        }

        public int CreateCable(string name, string assignment, string location)
        {
            return ComObject.CreateCable(name, assignment, location);
        }

        public int CreateCableDuct(string name, string assignment, string location, double xlen, double ywid, double zhgt,
            string templ)
        {
            return ComObject.CreateCableDuct(name, assignment, location, xlen, ywid, zhgt, templ);
        }

        public int CreateCableDuctEx(string name, string assignment, string location, double xlen, double ywid, double zhgt,
            string templ, int flags, double combwidth)
        {
            return ComObject.CreateCableDuctEx(name, assignment, location, xlen, ywid, zhgt, templ, flags, combwidth);
        }

        public int CreateConnector(string name, string assignment, string location)
        {
            return ComObject.CreateConnector(name, assignment, location);
        }

        public int CreateConnectorOnBlock(int blkid, string name, string assignment, string location)
        {
            return ComObject.CreateConnectorOnBlock(blkid, name, assignment, location);
        }

        public int CreateFormboard(int from, int shtId, int blockid = 0, string databaseDeviceView = "")
        {
            return ComObject.CreateFormboard(from, shtId, blockid, databaseDeviceView);
        }

        public int CreateFunctionalDesignBlock(string name, string assignment, string location, string cmpname, string version)
        {
            return ComObject.CreateFunctionalDesignBlock(name, assignment, location, cmpname, version);
        }

        public int CreateInstance(int vari)
        {
            return ComObject.CreateInstance(vari);
        }

        public int CreateMount(string name, string assignment, string location, double xlen, double ywid, double zhgt, string slotdes,
            string templ)
        {
            return ComObject.CreateMount(name, assignment, location, xlen, ywid, zhgt, slotdes, templ);
        }

        public int CreateOverbraid(string name, string assignment, string location, string cmpname, string version)
        {
            return ComObject.CreateOverbraid(name, assignment, location, cmpname, version);
        }

        public int CreateView(int from, int level, int blockid = 0, string databaseDeviceView = "")
        {
            return ComObject.CreateView(from, level, blockid, databaseDeviceView);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteEndAttribute(int which, string name)
        {
            return ComObject.DeleteEndAttribute(which, name);
        }

        public int DeleteForced()
        {
            return ComObject.DeleteForced();
        }

        public int DeleteInstance()
        {
            return ComObject.DeleteInstance();
        }

        public int DeleteInstanceForced()
        {
            return ComObject.DeleteInstanceForced();
        }

        public int FindPanelPath()
        {
            return ComObject.FindPanelPath();
        }

        public int Get3DTransparency()
        {
            return ComObject.Get3DTransparency();
        }

        public int GetAllCoreCount()
        {
            return ComObject.GetAllCoreCount();
        }

        public int GetAllCoreIds(ref object ids)
        {
            return ComObject.GetAllCoreIds(ref ids);
        }

        public int GetAllPinCount()
        {
            return ComObject.GetAllPinCount();
        }

        public int GetAllPinIds(ref object ids)
        {
            return ComObject.GetAllPinIds(ref ids);
        }

        public int GetAnyCount()
        {
            return ComObject.GetAnyCount();
        }

        public int GetAnyIds(ref object ids)
        {
            return ComObject.GetAnyIds(ref ids);
        }

        public int GetAssemblyId()
        {
            return ComObject.GetAssemblyId();
        }

        public int GetAssignedOptionExpressions(ref object expressions, int Term = 0)
        {
            return ComObject.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public int GetAssignedOptionExpressionsEx(ref object expressions, int Term = 0)
        {
            return ComObject.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public int GetAssignedOptionIds(ref object ids)
        {
            return ComObject.GetAssignedOptionIds(ref ids);
        }

        public string GetAssignment()
        {
            return ComObject.GetAssignment();
        }

        public int GetAssignmentLockChangeable()
        {
            return ComObject.GetAssignmentLockChangeable();
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = null)
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetBlockId()
        {
            return ComObject.GetBlockId();
        }

        public int GetBundleCount()
        {
            return ComObject.GetBundleCount();
        }

        public int GetBundleIds(ref object ids)
        {
            return ComObject.GetBundleIds(ref ids);
        }

        public int GetCableCount()
        {
            return ComObject.GetCableCount();
        }

        public int GetCableDuctInletOutlet()
        {
            return ComObject.GetCableDuctInletOutlet();
        }

        public int GetCableDuctInletOutlet(ref object ids)
        {
            return ComObject.GetCableDuctInletOutlet(ref ids);
        }

        public int GetCableDuctInletOutletId()
        {
            return ComObject.GetCableDuctInletOutletId();
        }

        public double GetCableDuctLength()
        {
            return ComObject.GetCableDuctLength();
        }

        public int GetCableIds(ref object ids)
        {
            return ComObject.GetCableIds(ref ids);
        }

        public int GetCarrierId()
        {
            return ComObject.GetCarrierId();
        }

        public string GetComponentAttributeValue(string name)
        {
            return ComObject.GetComponentAttributeValue(name);
        }

        public string GetComponentName()
        {
            return ComObject.GetComponentName();
        }

        public string GetComponentVersion()
        {
            return ComObject.GetComponentVersion();
        }

        public int GetConnectorCount()
        {
            return ComObject.GetConnectorCount();
        }

        public int GetConnectorIds(ref object ids)
        {
            return ComObject.GetConnectorIds(ref ids);
        }

        public int GetConnWithInsertsId()
        {
            return ComObject.GetConnWithInsertsId();
        }

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public string GetCounterpartComponentName()
        {
            return ComObject.GetCounterpartComponentName();
        }

        public string GetCounterpartComponentVersion()
        {
            return ComObject.GetCounterpartComponentVersion();
        }

        public int GetDeviceCount()
        {
            return ComObject.GetDeviceCount();
        }

        public int GetDeviceIds(ref object ids)
        {
            return ComObject.GetDeviceIds(ref ids);
        }

        public int GetDisconnecting()
        {
            return ComObject.GetDisconnecting();
        }

        public int GetDynamicModelSize(out object x, out object y, out object z)
        {
            return ComObject.GetDynamicModelSize(out x, out y, out z);
        }

        public int GetEndAttributeCount(int which)
        {
            return ComObject.GetEndAttributeCount(which);
        }

        public int GetEndAttributeIds(int which, ref object ids, string attnam = null)
        {
            return ComObject.GetEndAttributeIds(which, ref ids, attnam);
        }

        public string GetEndAttributeValue(int which, string name)
        {
            return ComObject.GetEndAttributeValue(which, name);
        }

        public string GetFileName()
        {
            return ComObject.GetFileName();
        }

        public int GetFormboardIds(ref object ids)
        {
            return ComObject.GetFormboardIds(ref ids);
        }

        public int GetFormboardSheetId()
        {
            return ComObject.GetFormboardSheetId();
        }

        public int GetFunctionalBlockSymbolIDs(ref object ids)
        {
            return ComObject.GetFunctionalBlockSymbolIDs(ref ids);
        }

        public int GetFunctionalUnitIds(ref object ids)
        {
            return ComObject.GetFunctionalUnitIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInheritName()
        {
            return ComObject.GetInheritName();
        }

        public int GetInstallationSpace()
        {
            return ComObject.GetInstallationSpace();
        }

        public int GetInterruptSignalFlow()
        {
            return ComObject.GetInterruptSignalFlow();
        }

        public string GetLocation()
        {
            return ComObject.GetLocation();
        }

        public int GetLocationLockChangeable()
        {
            return ComObject.GetLocationLockChangeable();
        }

        public string GetMasterPinName()
        {
            return ComObject.GetMasterPinName();
        }

        public string GetModelCharacteristic()
        {
            return ComObject.GetModelCharacteristic();
        }

        public string GetModelName()
        {
            return ComObject.GetModelName();
        }

        public int GetMountedCount()
        {
            return ComObject.GetMountedCount();
        }

        public int GetMountedIds(ref object ids)
        {
            return ComObject.GetMountedIds(ref ids);
        }

        public double GetMountLength()
        {
            return ComObject.GetMountLength();
        }

        public int GetMountTypes(ref object types)
        {
            return ComObject.GetMountTypes(ref types);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNameLockChangeable()
        {
            return ComObject.GetNameLockChangeable();
        }

        public int GetNetIds(ref object ids)
        {
            return ComObject.GetNetIds(ref ids);
        }

        public int GetNoconnPinIds(ref object ids)
        {
            return ComObject.GetNoconnPinIds(ref ids);
        }

        public int GetOriginalId()
        {
            return ComObject.GetOriginalId();
        }

        public double GetOuterDiameter()
        {
            return ComObject.GetOuterDiameter();
        }

        public int GetOutlineCount()
        {
            return ComObject.GetOutlineCount();
        }

        public int GetOutlineIds(ref object ids)
        {
            return ComObject.GetOutlineIds(ref ids);
        }

        public int GetOverbraidId()
        {
            return ComObject.GetOverbraidId();
        }

        public int GetPanelFreePlacement()
        {
            return ComObject.GetPanelFreePlacement();
        }

        public int GetPanelLevel()
        {
            return ComObject.GetPanelLevel();
        }

        public int GetPanelLocation(out object x, out object y, out object z, out object rot)
        {
            return ComObject.GetPanelLocation(out x, out y, out z, out rot);
        }

        public int GetPanelLocation(out object x, out object y, out object z, out object rot, ref object pivot)
        {
            return ComObject.GetPanelLocation(out x, out y, out z, out rot, ref pivot);
        }

        public int GetPanelPositionLock()
        {
            return ComObject.GetPanelPositionLock();
        }

        public int GetPinCount()
        {
            return ComObject.GetPinCount();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetReferenceType()
        {
            return ComObject.GetReferenceType();
        }

        public int GetRootAssemblyId()
        {
            return ComObject.GetRootAssemblyId();
        }

        public int GetSchematicTypes(ref object types)
        {
            return ComObject.GetSchematicTypes(ref types);
        }

        public int GetSlotIds(ref object ids)
        {
            return ComObject.GetSlotIds(ref ids);
        }

        public int GetSupplyId()
        {
            return ComObject.GetSupplyId();
        }

        public int GetSupplyIds(ref object ids)
        {
            return ComObject.GetSupplyIds(ref ids);
        }

        public int GetSupplyPinIds(ref object ids)
        {
            return ComObject.GetSupplyPinIds(ref ids);
        }

        public int GetSymbolCount(int get_mode = 0)
        {
            return ComObject.GetSymbolCount(get_mode);
        }

        public int GetSymbolIds(ref object ids, int get_mode = 0)
        {
            return ComObject.GetSymbolIds(ref ids, get_mode);
        }

        public int GetTableSymbolId()
        {
            return ComObject.GetTableSymbolId();
        }

        public int GetTerminalBlockId()
        {
            return ComObject.GetTerminalBlockId();
        }

        public int GetTerminalPlanSettings(ref object parameters)
        {
            return ComObject.GetTerminalPlanSettings(ref parameters);
        }

        public int GetTerminalPlanSheetIds(ref object shtids)
        {
            return ComObject.GetTerminalPlanSheetIds(ref shtids);
        }

        public int GetValidComponentCodes(ref object names)
        {
            return ComObject.GetValidComponentCodes(ref names);
        }

        public int GetValidModelCharacteristics(ref object characteristics)
        {
            return ComObject.GetValidModelCharacteristics(ref characteristics);
        }

        public int GetVariantObjectProperties(int iObjectType, string sAttributeName, ref object arr)
        {
            return ComObject.GetVariantObjectProperties(iObjectType, sAttributeName, ref arr);
        }

        public int GetViewCount()
        {
            return ComObject.GetViewCount();
        }

        public int GetViewIds(ref object ids)
        {
            return ComObject.GetViewIds(ref ids);
        }

        public int GetViewNumber()
        {
            return ComObject.GetViewNumber();
        }

        public int Has2DView()
        {
            return ComObject.Has2DView();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int HasEndAttribute(int which, string name)
        {
            return ComObject.HasEndAttribute(which, name);
        }

        public int HasNoconn()
        {
            return ComObject.HasNoconn();
        }

        public int HasPassWirePins()
        {
            return ComObject.HasPassWirePins();
        }

        public int InsertTerminalPlan(ref object parameters)
        {
            return ComObject.InsertTerminalPlan(ref parameters);
        }

        public int IsAssembly()
        {
            return ComObject.IsAssembly();
        }

        public int IsAssemblyPart()
        {
            return ComObject.IsAssemblyPart();
        }

        public int IsAssignmentLockChangeable()
        {
            return ComObject.IsAssignmentLockChangeable();
        }

        public int IsBlock()
        {
            return ComObject.IsBlock();
        }

        public int IsCable()
        {
            return ComObject.IsCable();
        }

        public int IsCableDuct()
        {
            return ComObject.IsCableDuct();
        }

        public int IsCableDuctInletOutlet()
        {
            return ComObject.IsCableDuctInletOutlet();
        }

        public int IsCableDuctInletOutletPart()
        {
            return ComObject.IsCableDuctInletOutletPart();
        }

        public int IsClipboardPart()
        {
            return ComObject.IsClipboardPart();
        }

        public int IsConnector()
        {
            return ComObject.IsConnector();
        }

        public int IsConnWithInserts()
        {
            return ComObject.IsConnWithInserts();
        }

        public int IsConnWithInsertsPart()
        {
            return ComObject.IsConnWithInsertsPart();
        }

        public int IsDevice()
        {
            return ComObject.IsDevice();
        }

        public int IsDynamicModel()
        {
            return ComObject.IsDynamicModel();
        }

        public int IsFormboard()
        {
            return ComObject.IsFormboard();
        }

        public int IsFunctionalBlock()
        {
            return ComObject.IsFunctionalBlock();
        }

        public int IsFunctionalDesignBlock()
        {
            return ComObject.IsFunctionalDesignBlock();
        }

        public int IsHarness()
        {
            return ComObject.IsHarness();
        }

        public int IsHierarchicalBlock()
        {
            return ComObject.IsHierarchicalBlock();
        }

        public int IsHose()
        {
            return ComObject.IsHose();
        }

        public int IsInstallationSpace()
        {
            return ComObject.IsInstallationSpace();
        }

        public int IsLocationLockChangeable()
        {
            return ComObject.IsLocationLockChangeable();
        }

        public int IsLocked()
        {
            return ComObject.IsLocked();
        }

        public int IsLockPurgeUnused()
        {
            return ComObject.IsLockPurgeUnused();
        }

        public int IsModule()
        {
            return ComObject.IsModule();
        }

        public int IsMount()
        {
            return ComObject.IsMount();
        }

        public int IsNameLockChangeable()
        {
            return ComObject.IsNameLockChangeable();
        }

        public int IsOverbraid()
        {
            return ComObject.IsOverbraid();
        }

        public int IsOverbraidPart()
        {
            return ComObject.IsOverbraidPart();
        }

        public int IsPinTerminalSymbolsUsed()
        {
            return ComObject.IsPinTerminalSymbolsUsed();
        }

        public int IsTerminal()
        {
            return ComObject.IsTerminal();
        }

        public int IsTerminalBlock()
        {
            return ComObject.IsTerminalBlock();
        }

        public int IsTube()
        {
            return ComObject.IsTube();
        }

        public int IsView()
        {
            return ComObject.IsView();
        }

        public int IsWireGroup()
        {
            return ComObject.IsWireGroup();
        }

        public int Jump()
        {
            return ComObject.Jump();
        }

        public int LoadAndCreate(string comp, string vers, int type)
        {
            return ComObject.LoadAndCreate(comp, vers, type);
        }

        public int LoadAndPlaceComponent(string name, string assignment, string location, string comp, string vers, string wirename,
            int after, int options)
        {
            return ComObject.LoadAndPlaceComponent(name, assignment, location, comp, vers, wirename, after, options);
        }

        public int LockObject()
        {
            return ComObject.LockObject();
        }

        public int MergeHarnesses()
        {
            return ComObject.MergeHarnesses();
        }

        public int MergeHarnesses(ref object ids)
        {
            return ComObject.MergeHarnesses(ref ids);
        }

        public int RemoveFromAssembly()
        {
            return ComObject.RemoveFromAssembly();
        }

        public int RemoveFromAssembly(ref object ids)
        {
            return ComObject.RemoveFromAssembly(ref ids);
        }

        public int RemoveFromInstallationSpace()
        {
            return ComObject.RemoveFromInstallationSpace();
        }

        public int RemoveFromInstallationSpace(ref object ids)
        {
            return ComObject.RemoveFromInstallationSpace(ref ids);
        }

        public int RemoveFromOverbraid()
        {
            return ComObject.RemoveFromOverbraid();
        }

        public int RemoveFromOverbraid(ref object ids)
        {
            return ComObject.RemoveFromOverbraid(ref ids);
        }

        public int Search(string name, string assignment, string location)
        {
            return ComObject.Search(name, assignment, location);
        }

        public int SearchAll(string name, string assignment, string location, ref object ids)
        {
            return ComObject.SearchAll(name, assignment, location, ref ids);
        }

        public int Set3DTransparency(int mode)
        {
            return ComObject.Set3DTransparency(mode);
        }

        public int SetAssignedOptionIds(ref object ids)
        {
            return ComObject.SetAssignedOptionIds(ref ids);
        }

        public int SetAssignment(string name)
        {
            return ComObject.SetAssignment(name);
        }

        public int SetAssignmentLockChangeable(int lockchangeable)
        {
            return ComObject.SetAssignmentLockChangeable(lockchangeable);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetAttributeValueVariant(string name, string value, int copy, string VariantExpression)
        {
            return ComObject.SetAttributeValueVariant(name, value, copy, VariantExpression);
        }

        public int SetCableDuctLength(double newlen)
        {
            return ComObject.SetCableDuctLength(newlen);
        }

        public int SetCompleteName(string name, string assignment, string location, int onlygiven = 0)
        {
            return ComObject.SetCompleteName(name, assignment, location, onlygiven);
        }

        public int SetComponentName(string name, string version)
        {
            return ComObject.SetComponentName(name, version);
        }

        public int SetDisconnecting(int onoff)
        {
            return ComObject.SetDisconnecting(onoff);
        }

        public int SetDynamicModelSize(ref object x, ref object y, ref object z)
        {
            return ComObject.SetDynamicModelSize(ref x, ref y, ref z);
        }

        public int SetEndAttributeValue(int which, string name, string value)
        {
            return ComObject.SetEndAttributeValue(which, name, value);
        }

        public int SetFileName(string name)
        {
            return ComObject.SetFileName(name);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetInheritName(int onoff)
        {
            return ComObject.SetInheritName(onoff);
        }

        public int SetInterruptSignalFlow(int sigflow = 1)
        {
            return ComObject.SetInterruptSignalFlow(sigflow);
        }

        public int SetLocation(string name)
        {
            return ComObject.SetLocation(name);
        }

        public int SetLocationLockChangeable(int lockchangeable)
        {
            return ComObject.SetLocationLockChangeable(lockchangeable);
        }

        public int SetLockPurgeUnused(int id)
        {
            return ComObject.SetLockPurgeUnused(id);
        }

        public int SetMasterPinName(string name)
        {
            return ComObject.SetMasterPinName(name);
        }

        public int SetModelCharacteristic(string characteristic)
        {
            return ComObject.SetModelCharacteristic(characteristic);
        }

        public int SetModule(int newval)
        {
            return ComObject.SetModule(newval);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetNameLockChangeable(int lockchangeable)
        {
            return ComObject.SetNameLockChangeable(lockchangeable);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public double SetOuterDiameter(double newval)
        {
            return ComObject.SetOuterDiameter(newval);
        }

        public int SetPanelFreePlacement(int freeplacement = 1)
        {
            return ComObject.SetPanelFreePlacement(freeplacement);
        }

        public int SetPanelLevel(int nLevel, int bChangeMounted)
        {
            return ComObject.SetPanelLevel(nLevel, bChangeMounted);
        }

        public int SetPanelLocation(int world, int shti, double x, double y, double z, string rot, int use_start_z = 0,
            int place_combined = 0, int pivot = 0)
        {
            return ComObject.SetPanelLocation(world, shti, x, y, z, rot, use_start_z, place_combined, pivot);
        }

        public int SetPanelLocationEx(int world, int shti, double x, double y, double z, string rot, int use_start_z = 0,
            int place_combined = 0, int pivot = 0, int shift_key = 0)
        {
            return ComObject.SetPanelLocationEx(world, shti, x, y, z, rot, use_start_z, place_combined, pivot, shift_key);
        }

        public int SetPanelPositionLock(int onoff)
        {
            return ComObject.SetPanelPositionLock(onoff);
        }

        public int SetPinTerminalSymbolsUsed(int use)
        {
            return ComObject.SetPinTerminalSymbolsUsed(use);
        }

        public int SetReferenceType(int type)
        {
            return ComObject.SetReferenceType(type);
        }

        public int SetSupplyId(int id)
        {
            return ComObject.SetSupplyId(id);
        }

        public int SetTerminalPlanSettings(ref object parameters)
        {
            return ComObject.SetTerminalPlanSettings(ref parameters);
        }

        public int SetTerminalSequence(ref object ids)
        {
            return ComObject.SetTerminalSequence(ref ids);
        }

        public int SetViewNumber(int id)
        {
            return ComObject.SetViewNumber(id);
        }

        public int Sort(int Sort = 0)
        {
            return ComObject.Sort(Sort);
        }

        public int SortHarness(ref object ids, int postion, int options)
        {
            return ComObject.SortHarness(ref ids, postion, options);
        }

        public int UnlockObject(string password)
        {
            return ComObject.UnlockObject(password);
        }

        public int UnplacePanel()
        {
            return ComObject.UnplacePanel();
        }

        public int UpdateDisconnecting(int options)
        {
            return ComObject.UpdateDisconnecting(options);
        }

        public int UpdateDisconnecting(int options, ref object ids)
        {
            return ComObject.UpdateDisconnecting(options, ref ids);
        }
    }
}