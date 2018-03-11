using System;
using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3PinProxy : E3ProxyBase
    {
        public E3PinProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return ComObject.AddDefaultWire(wiregroup, wirename);
        }

        public int AddEndAttributeValue(int which, string name, string value)
        {
            return ComObject.AddEndAttributeValue(which, name, value);
        }

        public int AddPinsToConnector(ref object pinidarray, string name, string assignment, string location)
        {
            return ComObject.AddPinsToConnector(ref pinidarray, name, assignment, location);
        }

        public int AssignTo(ref object pinids)
        {
            return ComObject.AssignTo(ref pinids);
        }

        public int CalculateFittingForWires(ref object wirids, ref object fittinglst)
        {
            return ComObject.CalculateFittingForWires(ref wirids, ref fittinglst);
        }

        public int Create(string name, int devi, int pini, int before)
        {
            return ComObject.Create(name, devi, pini, before);
        }

        public int CreateNewConnectorForPins(ref object pinidarray, string name, string assignment, string location)
        {
            return ComObject.CreateNewConnectorForPins(ref pinidarray, name, assignment, location);
        }

        public int CreateWire(string name, string cabtyp, string wirnam, int devi, int pini, int before)
        {
            return ComObject.CreateWire(name, cabtyp, wirnam, devi, pini, before);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return ComObject.DeleteDefaultWire(wiregroup, wirename);
        }

        public int DeleteEndAttribute(int which, string name)
        {
            return ComObject.DeleteEndAttribute(which, name);
        }

        public int DeleteForced()
        {
            return ComObject.DeleteForced();
        }

        public int DeletePanelPath()
        {
            return ComObject.DeletePanelPath();
        }

        public int FindPanelPath()
        {
            return ComObject.FindPanelPath();
        }

        public int GenerateNewWireNames(ref object ids)
        {
            return ComObject.GenerateNewWireNames(ref ids);
        }

        public int GetAllNetSegmentPaths(ref object ids, int pin1i, int pin2i)
        {
            return ComObject.GetAllNetSegmentPaths(ref ids, pin1i, pin2i);
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

        public int GetBlockConnectionNumber()
        {
            return ComObject.GetBlockConnectionNumber();
        }

        public int GetCableDuctIds(ref object ids)
        {
            return ComObject.GetCableDuctIds(ref ids);
        }

        public int GetCCT()
        {
            return ComObject.GetCCT();
        }

        public int GetColour()
        {
            return ComObject.GetColour();
        }

        public string GetColourDescription()
        {
            return ComObject.GetColourDescription();
        }

        public string GetComponentAttributeValue(string name)
        {
            return ComObject.GetComponentAttributeValue(name);
        }

        public int GetConnectedNodeIds(ref object ids)
        {
            return ComObject.GetConnectedNodeIds(ref ids);
        }

        public int GetConnectedPinId()
        {
            return ComObject.GetConnectedPinId();
        }

        public int GetConnectedPinIds(ref object ids)
        {
            return ComObject.GetConnectedPinIds(ref ids);
        }

        public int GetConnectionType()
        {
            return ComObject.GetConnectionType();
        }

        public string GetConnectionTypeDescription()
        {
            return ComObject.GetConnectionTypeDescription();
        }

        public int GetCoreChangeIds(ref object ids)
        {
            return ComObject.GetCoreChangeIds(ref ids);
        }

        public int GetCoreChangeIds(ref object ids, ref object optids)
        {
            return ComObject.GetCoreChangeIds(ref ids, ref optids);
        }

        public string GetCoreCost()
        {
            return ComObject.GetCoreCost();
        }

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public double GetCoreManufacturingLength()
        {
            return ComObject.GetCoreManufacturingLength();
        }

        public double GetCoreWeight()
        {
            return ComObject.GetCoreWeight();
        }

        public string GetCounterpart()
        {
            return ComObject.GetCounterpart();
        }

        public double GetCrossSection()
        {
            return ComObject.GetCrossSection();
        }

        public string GetCrossSectionDescription()
        {
            return ComObject.GetCrossSectionDescription();
        }

        public int GetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            return ComObject.GetDefaultWires(ref wiregroups, ref wirenames);
        }

        public double GetDefinedOuterDiameter()
        {
            return ComObject.GetDefinedOuterDiameter();
        }

        public int GetDestinationCount()
        {
            return ComObject.GetDestinationCount();
        }

        public int GetDestinationIds(ref object ids)
        {
            return ComObject.GetDestinationIds(ref ids);
        }

        public int GetDevicePinIds(ref object ids)
        {
            return ComObject.GetDevicePinIds(ref ids);
        }

        public double GetDiameter()
        {
            return ComObject.GetDiameter();
        }

        public string GetDiameterDescription()
        {
            return ComObject.GetDiameterDescription();
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

        public int GetEndPinId(int which, int flags = 0)
        {
            return ComObject.GetEndPinId(which, flags);
        }

        public int GetExchangeableID()
        {
            return ComObject.GetExchangeableID();
        }

        public string GetExternSignalName()
        {
            return ComObject.GetExternSignalName();
        }

        public string GetFitting()
        {
            return ComObject.GetFitting();
        }

        public int GetFittingIds(ref object ids)
        {
            return ComObject.GetFittingIds(ref ids);
        }

        public int GetFittingIds(ref object ids, ref object optids)
        {
            return ComObject.GetFittingIds(ref ids, ref optids);
        }

        public int GetFunc()
        {
            return ComObject.GetFunc();
        }

        public int GetFunctionalPortID()
        {
            return ComObject.GetFunctionalPortID();
        }

        public int GetHarnessId()
        {
            return ComObject.GetHarnessId();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInterruptSignalFlow()
        {
            return ComObject.GetInterruptSignalFlow();
        }

        public double GetLength()
        {
            return ComObject.GetLength();
        }

        public int GetLocking()
        {
            return ComObject.GetLocking();
        }

        public int GetLogicalEquivalenceID()
        {
            return ComObject.GetLogicalEquivalenceID();
        }

        public int GetLossAngle(ref object lossangle)
        {
            return ComObject.GetLossAngle(ref lossangle);
        }

        public int GetMaterial()
        {
            return ComObject.GetMaterial();
        }

        public string GetMaterialDescription()
        {
            return ComObject.GetMaterialDescription();
        }

        public int GetMergeSegment()
        {
            return ComObject.GetMergeSegment();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNameEquivalenceID()
        {
            return ComObject.GetNameEquivalenceID();
        }

        public int GetNetSegmentCount()
        {
            return ComObject.GetNetSegmentCount();
        }

        public int GetNetSegmentIds(ref object ids)
        {
            return ComObject.GetNetSegmentIds(ref ids);
        }

        public int GetNetSegmentPath(ref object ids, int pin1i, int pin2i)
        {
            return ComObject.GetNetSegmentPath(ref ids, pin1i, pin2i);
        }

        public int GetNodeIds(ref object ids)
        {
            return ComObject.GetNodeIds(ref ids);
        }

        public int GetNodeType(ref object type)
        {
            return ComObject.GetNodeType(ref type);
        }

        public int GetNumberOfWindings()
        {
            return ComObject.GetNumberOfWindings();
        }

        public int GetOriginalId()
        {
            return ComObject.GetOriginalId();
        }

        public double GetOuterDiameter()
        {
            return ComObject.GetOuterDiameter();
        }

        public int GetOverbraidId()
        {
            return ComObject.GetOverbraidId();
        }

        public int GetPanelLocation(ref object x, ref object y, ref object z)
        {
            return ComObject.GetPanelLocation(ref x, ref y, ref z);
        }

        public int GetPanelNetSegmentIds(ref object ids)
        {
            return ComObject.GetPanelNetSegmentIds(ref ids);
        }

        public int GetPanelPath(ref object xarr, ref object yarr, ref object zarr)
        {
            return ComObject.GetPanelPath(ref xarr, ref yarr, ref zarr);
        }

        public int GetPassPins(ref object ids, ref object ends, ref object ende)
        {
            return ComObject.GetPassPins(ref ids, ref ends, ref ende);
        }

        public int GetPassWires(ref object ids)
        {
            return ComObject.GetPassWires(ref ids);
        }

        public int GetPhysicalConnectionDirection()
        {
            return ComObject.GetPhysicalConnectionDirection();
        }

        public int GetPhysicalConnectionType()
        {
            return ComObject.GetPhysicalConnectionType();
        }

        public string GetPhysicalConnectionTypeDescription()
        {
            return ComObject.GetPhysicalConnectionTypeDescription();
        }

        public int GetPhysicalID()
        {
            return ComObject.GetPhysicalID();
        }

        public int GetPhysicalMaxConnections()
        {
            return ComObject.GetPhysicalMaxConnections();
        }

        public double GetPhysicalMaxCrossSection()
        {
            return ComObject.GetPhysicalMaxCrossSection();
        }

        public double GetPhysicalMinCrossSection()
        {
            return ComObject.GetPhysicalMinCrossSection();
        }

        public int GetPhysicalPosition(ref object x, ref object y, ref object z)
        {
            return ComObject.GetPhysicalPosition(ref x, ref y, ref z);
        }

        public double GetPhysicalTotalMaxCrossSection()
        {
            return ComObject.GetPhysicalTotalMaxCrossSection();
        }

        public int GetPinIndex()
        {
            return ComObject.GetPinIndex();
        }

        public string GetPortName()
        {
            return ComObject.GetPortName();
        }

        public int GetRelativePermittivity(ref object relativepermittivity)
        {
            return ComObject.GetRelativePermittivity(ref relativepermittivity);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid)
        {
            return ComObject.GetSchemaLocation(ref x, ref y, ref grid);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value)
        {
            return ComObject.GetSchemaLocation(ref x, ref y, ref grid, ref column_value);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value)
        {
            return ComObject.GetSchemaLocation(ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public int GetSchematicEndPinId(int which)
        {
            return ComObject.GetSchematicEndPinId(which);
        }

        public int GetSequenceNumber()
        {
            return ComObject.GetSequenceNumber();
        }

        public string GetSignalName()
        {
            return ComObject.GetSignalName();
        }

        public int GetSupplyInfo(ref object supid, ref object signum, ref object signam)
        {
            return ComObject.GetSupplyInfo(ref supid, ref signum, ref signam);
        }

        public int GetTemplateSymbolId()
        {
            return ComObject.GetTemplateSymbolId();
        }

        public int GetTemplateSymbolIds(ref object ids)
        {
            return ComObject.GetTemplateSymbolIds(ref ids);
        }

        public int GetTextCount()
        {
            return ComObject.GetTextCount();
        }

        public int GetTextIds(ref object ids, int txttyp = 0, string search_string = "")
        {
            return ComObject.GetTextIds(ref ids, txttyp, search_string);
        }

        public string GetTranslatedSignalName()
        {
            return ComObject.GetTranslatedSignalName();
        }

        public int GetTypeId()
        {
            return ComObject.GetTypeId();
        }

        public int GetValidCounterparts(ref object strings)
        {
            return ComObject.GetValidCounterparts(ref strings);
        }

        public int GetValidFittings(ref object strings)
        {
            return ComObject.GetValidFittings(ref strings);
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

        public int GetWireKindId()
        {
            return ComObject.GetWireKindId();
        }

        public int GetWireType(ref object comp, ref object name)
        {
            return ComObject.GetWireType(ref comp, ref name);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int HasDevice()
        {
            return ComObject.HasDevice();
        }

        public int HasEndAttribute(int which, string name)
        {
            return ComObject.HasEndAttribute(which, name);
        }

        public int Highlight()
        {
            return ComObject.Highlight();
        }

        public int IsBackShell()
        {
            return ComObject.IsBackShell();
        }

        public int IsCoreEndLocked(int which)
        {
            return ComObject.IsCoreEndLocked(which);
        }

        public int IsExternal()
        {
            return ComObject.IsExternal();
        }

        public int IsInternal()
        {
            return ComObject.IsInternal();
        }

        public int IsLocked()
        {
            return ComObject.IsLocked();
        }

        public int IsNoconn()
        {
            return ComObject.IsNoconn();
        }

        public int IsOffline()
        {
            return ComObject.IsOffline();
        }

        public int IsPanelPathLocked()
        {
            return ComObject.IsPanelPathLocked();
        }

        public int IsPassWire()
        {
            return ComObject.IsPassWire();
        }

        public int IsPinView()
        {
            return ComObject.IsPinView();
        }

        public int IsRouted()
        {
            return ComObject.IsRouted();
        }

        public int IsSupply()
        {
            return ComObject.IsSupply();
        }

        public int IsView()
        {
            return ComObject.IsView();
        }

        public int LockCoreEnd(int which, int @lock)
        {
            return ComObject.LockCoreEnd(which, @lock);
        }

        public int LockObject()
        {
            return ComObject.LockObject();
        }

        public int LockPanelPath(int @lock)
        {
            return ComObject.LockPanelPath(@lock);
        }

        public int PlaceNode(int shtId, double x, double y)
        {
            return ComObject.PlaceNode(shtId, x, y);
        }

        public int ResetLength()
        {
            return ComObject.ResetLength();
        }

        public int Search(string name, int devi)
        {
            return ComObject.Search(name, devi);
        }

        public int SetAsExternal(int onoff)
        {
            return ComObject.SetAsExternal(onoff);
        }

        public int SetAsInternal(int onoff)
        {
            return ComObject.SetAsInternal(onoff);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetColour(int color)
        {
            return ComObject.SetColour(color);
        }

        public int SetColourByDescription(string color)
        {
            return ComObject.SetColourByDescription(color);
        }

        public int SetColourDescription(string color)
        {
            return ComObject.SetColourDescription(color);
        }

        public int SetCoreChangeId(int id)
        {
            return ComObject.SetCoreChangeId(id);
        }

        public int SetCoreCost(string value)
        {
            return ComObject.SetCoreCost(value);
        }

        public int SetCounterpart(string name)
        {
            return ComObject.SetCounterpart(name);
        }

        public int SetCrossSection(double crossec)
        {
            return ComObject.SetCrossSection(crossec);
        }

        public int SetCrossSectionByDescription(string description)
        {
            return ComObject.SetCrossSectionByDescription(description);
        }

        public int SetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            return ComObject.SetDefaultWires(ref wiregroups, ref wirenames);
        }

        public int SetDeviceId(int devid, int pinid, int before)
        {
            return ComObject.SetDeviceId(devid, pinid, before);
        }

        public int SetEndAttributeValue(int which, string name, string value)
        {
            return ComObject.SetEndAttributeValue(which, name, value);
        }

        public int SetEndPinId(int which, int pini)
        {
            return ComObject.SetEndPinId(which, pini);
        }

        public int SetFitting(string name)
        {
            return ComObject.SetFitting(name);
        }

        public int SetFittingId(int id)
        {
            return ComObject.SetFittingId(id);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetInterruptSignalFlow(int sigflow = 1)
        {
            return ComObject.SetInterruptSignalFlow(sigflow);
        }

        public int SetLength(double length)
        {
            return ComObject.SetLength(length);
        }

        public int SetLocking(int bSet)
        {
            return ComObject.SetLocking(bSet);
        }

        public int SetMergeSegment(int bSet)
        {
            return ComObject.SetMergeSegment(bSet);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetNameSymbol(string name)
        {
            return ComObject.SetNameSymbol(name);
        }

        public int SetNetSegmentPathIds(ref object netsegids)
        {
            return ComObject.SetNetSegmentPathIds(ref netsegids);
        }

        public int SetNodeId(int id)
        {
            return ComObject.SetNodeId(id);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public double SetOuterDiameter(double newval)
        {
            return ComObject.SetOuterDiameter(newval);
        }

        public int SetPanelPath(int pnts, ref object x, ref object y, ref object z, int use_exact_coords = 0)
        {
            return ComObject.SetPanelPath(pnts, ref x, ref y, ref z, use_exact_coords);
        }

        public int SetPhysicalConnectionDirection(int conndir)
        {
            return ComObject.SetPhysicalConnectionDirection(conndir);
        }

        public int SetPhysicalConnectionType(int conntyp)
        {
            return ComObject.SetPhysicalConnectionType(conntyp);
        }

        public int SetPhysicalMaxConnections(int conncount)
        {
            return ComObject.SetPhysicalMaxConnections(conncount);
        }

        public int SetSignalName(string name)
        {
            return ComObject.SetSignalName(name);
        }

        public int SetWireType(string comp, string name)
        {
            return ComObject.SetWireType(comp, name);
        }

        public int UnassignFrom(int id)
        {
            return ComObject.UnassignFrom(id);
        }

        public int UnlockObject(string password)
        {
            return ComObject.UnlockObject(password);
        }
    }
}