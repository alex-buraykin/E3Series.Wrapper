using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3SymbolProxy : E3ProxyBase
    {
        public E3SymbolProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddToSheetReference(int symi)
        {
            return ComObject.AddToSheetReference(symi);
        }

        public int AssignFunctionalPorts()
        {
            return ComObject.AssignFunctionalPorts();
        }

        public int AssignFunctionalPorts(ref object ids)
        {
            return ComObject.AssignFunctionalPorts(ref ids);
        }

        public int AssignTo(int AssignTo, int nonodeassignment = 0)
        {
            return ComObject.AssignTo(AssignTo, nonodeassignment);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetArea(ref xMin, ref yMin, ref xMax, ref yMax);
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

        public int GetBlockHatchColour()
        {
            return ComObject.GetBlockHatchColour();
        }

        public double GetBlockHatchDistance()
        {
            return ComObject.GetBlockHatchDistance();
        }

        public int GetBlockHatchPattern(ref object angle1, ref object angle2)
        {
            return ComObject.GetBlockHatchPattern(ref angle1, ref angle2);
        }

        public int GetBlockHatchStyle()
        {
            return ComObject.GetBlockHatchStyle();
        }

        public double GetBlockHatchWidth()
        {
            return ComObject.GetBlockHatchWidth();
        }

        public int GetBlockOutlineColour()
        {
            return ComObject.GetBlockOutlineColour();
        }

        public int GetBlockOutlineStyle()
        {
            return ComObject.GetBlockOutlineStyle();
        }

        public double GetBlockOutlineWidth()
        {
            return ComObject.GetBlockOutlineWidth();
        }

        public int GetBoundIds(ref object ids)
        {
            return ComObject.GetBoundIds(ref ids);
        }

        public string GetCharacteristic()
        {
            return ComObject.GetCharacteristic();
        }

        public int GetCode()
        {
            return ComObject.GetCode();
        }

        public int GetDBTextSize()
        {
            return ComObject.GetDBTextSize();
        }

        public int GetDevicePinIds(ref object ids)
        {
            return ComObject.GetDevicePinIds(ref ids);
        }

        public double GetDisplayLength()
        {
            return ComObject.GetDisplayLength();
        }

        public double GetDisplayWidth()
        {
            return ComObject.GetDisplayWidth();
        }

        public int GetDynamicChildrenIds(ref object ids)
        {
            return ComObject.GetDynamicChildrenIds(ref ids);
        }

        public int GetDynamicParentId()
        {
            return ComObject.GetDynamicParentId();
        }

        public int GetGateId()
        {
            return ComObject.GetGateId();
        }

        public int GetGroupId()
        {
            return ComObject.GetGroupId();
        }

        public int GetHyperlinkTextIds(ref object ids)
        {
            return ComObject.GetHyperlinkTextIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetLevel()
        {
            return ComObject.GetLevel();
        }

        public int GetMasterCount()
        {
            return ComObject.GetMasterCount();
        }

        public int GetMasterIds(ref object ids)
        {
            return ComObject.GetMasterIds(ref ids);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetPinCount()
        {
            return ComObject.GetPinCount();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetPlacedArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetPlacedArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public int GetPlacedPolygon(ref object npnts, ref object xarr, ref object yarr)
        {
            return ComObject.GetPlacedPolygon(ref npnts, ref xarr, ref yarr);
        }

        public string GetReferenceText()
        {
            return ComObject.GetReferenceText();
        }

        public int GetReferenceTextExtent(ref object xarr, ref object yarr)
        {
            return ComObject.GetReferenceTextExtent(ref xarr, ref yarr);
        }

        public int GetReferenceTextExtentSingleLine(ref object nlines, ref object xarr, ref object yarr)
        {
            return ComObject.GetReferenceTextExtentSingleLine(ref nlines, ref xarr, ref yarr);
        }

        public int GetReferenceTextSingleLine(ref object textarr)
        {
            return ComObject.GetReferenceTextSingleLine(ref textarr);
        }

        public string GetRotation()
        {
            return ComObject.GetRotation();
        }

        public double GetScaling()
        {
            return ComObject.GetScaling();
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

        public int GetSchemaLocationShared(int shtId, ref object x, ref object y, ref object grid)
        {
            return ComObject.GetSchemaLocationShared(shtId, ref x, ref y, ref grid);
        }

        public int GetSchemaLocationShared(int shtId, ref object x, ref object y, ref object grid, ref object column_value)
        {
            return ComObject.GetSchemaLocationShared(shtId, ref x, ref y, ref grid, ref column_value);
        }

        public int GetSchemaLocationShared(int shtId, ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value)
        {
            return ComObject.GetSchemaLocationShared(shtId, ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public int GetSchematicTypes(ref object types)
        {
            return ComObject.GetSchematicTypes(ref types);
        }

        public int GetSharedPinGroupState()
        {
            return ComObject.GetSharedPinGroupState();
        }

        public int GetSheetReferenceInfo(out object inout, out object type, out object refnam, out object signam)
        {
            return ComObject.GetSheetReferenceInfo(out inout, out type, out refnam, out signam);
        }

        public int GetSlaveCount()
        {
            return ComObject.GetSlaveCount();
        }

        public int GetSlaveIds(ref object ids)
        {
            return ComObject.GetSlaveIds(ref ids);
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolExtend(ref object xarr, ref object yarr)
        {
            return ComObject.GetSymbolExtend(ref xarr, ref yarr);
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public string GetSymbolTypeName()
        {
            return ComObject.GetSymbolTypeName();
        }

        public int GetTargetObjectId()
        {
            return ComObject.GetTargetObjectId();
        }

        public int GetTextCount()
        {
            return ComObject.GetTextCount();
        }

        public int GetTextIds(ref object ids, int txttyp = 0, string search_string = "")
        {
            return ComObject.GetTextIds(ref ids, txttyp, search_string);
        }

        public int GetTransformationMatrix(ref object array)
        {
            return ComObject.GetTransformationMatrix(ref array);
        }

        public string GetTypeName()
        {
            return ComObject.GetTypeName();
        }

        public int GetValidCharacteristics(ref object characteristics)
        {
            return ComObject.GetValidCharacteristics(ref characteristics);
        }

        public string GetVersion()
        {
            return ComObject.GetVersion();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int HasNoGraphic()
        {
            return ComObject.HasNoGraphic();
        }

        public int HasPassWirePins()
        {
            return ComObject.HasPassWirePins();
        }

        public int IsBlock()
        {
            return ComObject.IsBlock();
        }

        public int IsBundle()
        {
            return ComObject.IsBundle();
        }

        public int IsConnected()
        {
            return ComObject.IsConnected();
        }

        public int IsConnectorMaster()
        {
            return ComObject.IsConnectorMaster();
        }

        public int IsDynamic()
        {
            return ComObject.IsDynamic();
        }

        public int IsDynamicFixed()
        {
            return ComObject.IsDynamicFixed();
        }

        public int IsFormboard()
        {
            return ComObject.IsFormboard();
        }

        public int IsMaster()
        {
            return ComObject.IsMaster();
        }

        public int IsOffline()
        {
            return ComObject.IsOffline();
        }

        public int IsPinView()
        {
            return ComObject.IsPinView();
        }

        public int IsProtection()
        {
            return ComObject.IsProtection();
        }

        public int IsShield()
        {
            return ComObject.IsShield();
        }

        public int IsTwisted()
        {
            return ComObject.IsTwisted();
        }

        public int Jump()
        {
            return ComObject.Jump();
        }

        public int Load(string name, string version)
        {
            return ComObject.Load(name, version);
        }

        public int Place(int shti, double x, double y, string rot = null, double scale = 0, int maintaintextsize = 0)
        {
            return ComObject.Place(shti, x, y, rot, scale, maintaintextsize);
        }

        public int PlaceAsGraphic(int shti, double x, double y, string rot, double scale, int maintaintextsize, int srcid)
        {
            return ComObject.PlaceAsGraphic(shti, x, y, rot, scale, maintaintextsize, srcid);
        }

        public int PlaceBlock(int shti, double x, double y, double width, double height, int parent = 0)
        {
            return ComObject.PlaceBlock(shti, x, y, width, height, parent);
        }

        public int PlaceDynamic(int shti, double x, double y, double height, double width, string texttemplate = null,
            short fitsymbol = 0)
        {
            return ComObject.PlaceDynamic(shti, x, y, height, width, texttemplate, fitsymbol);
        }

        public int PlaceInteractively()
        {
            return ComObject.PlaceInteractively();
        }

        public int PlacePins(ref object pinarray, string symname, string vers, int shti, double x, double y, string rot,
            double scale = 0)
        {
            return ComObject.PlacePins(ref pinarray, symname, vers, shti, x, y, rot, scale);
        }

        public int PlacePinView(int pinid, int shti, string symname, string version, double x, double y, string rot, double scale = 0,
            int maintaintextsize = 0)
        {
            return ComObject.PlacePinView(pinid, shti, symname, version, x, y, rot, scale, maintaintextsize);
        }

        public int PlaceTable(int fromID, double x, double y, string rot = null, double scale = 0, int maintaintextsize = 0)
        {
            return ComObject.PlaceTable(fromID, x, y, rot, scale, maintaintextsize);
        }

        public int SetAsMaster(int on)
        {
            return ComObject.SetAsMaster(on);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetBlockHatchColour(int value)
        {
            return ComObject.SetBlockHatchColour(value);
        }

        public double SetBlockHatchDistance(double value)
        {
            return ComObject.SetBlockHatchDistance(value);
        }

        public int SetBlockHatchPattern(int value, double angle1, double angle2)
        {
            return ComObject.SetBlockHatchPattern(value, angle1, angle2);
        }

        public int SetBlockHatchStyle(int value)
        {
            return ComObject.SetBlockHatchStyle(value);
        }

        public double SetBlockHatchWidth(double value)
        {
            return ComObject.SetBlockHatchWidth(value);
        }

        public int SetBlockOutlineColour(int value)
        {
            return ComObject.SetBlockOutlineColour(value);
        }

        public int SetBlockOutlineStyle(int value)
        {
            return ComObject.SetBlockOutlineStyle(value);
        }

        public double SetBlockOutlineWidth(double value)
        {
            return ComObject.SetBlockOutlineWidth(value);
        }

        public int SetCharacteristic(string characteristic)
        {
            return ComObject.SetCharacteristic(characteristic);
        }

        public int SetDBTextSize(int txtsiz)
        {
            return ComObject.SetDBTextSize(txtsiz);
        }

        public int SetDeviceAssignment(string name)
        {
            return ComObject.SetDeviceAssignment(name);
        }

        public int SetDeviceCompleteName(string name, string ass, string loc, int onlygiven = 1)
        {
            return ComObject.SetDeviceCompleteName(name, ass, loc, onlygiven);
        }

        public int SetDeviceLocation(string name)
        {
            return ComObject.SetDeviceLocation(name);
        }

        public int SetDeviceName(string name)
        {
            return ComObject.SetDeviceName(name);
        }

        public int SetDisplayLength(double length)
        {
            return ComObject.SetDisplayLength(length);
        }

        public int SetDisplayWidth(double width)
        {
            return ComObject.SetDisplayWidth(width);
        }

        public int SetGateId(int symid)
        {
            return ComObject.SetGateId(symid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetLevel(int level)
        {
            return ComObject.SetLevel(level);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public double SetScaling(double scale)
        {
            return ComObject.SetScaling(scale);
        }

        public int SetSharedPinGroupState(int newval)
        {
            return ComObject.SetSharedPinGroupState(newval);
        }

        public int SetType(string name, string version)
        {
            return ComObject.SetType(name, version);
        }

        public int UnGroup()
        {
            return ComObject.UnGroup();
        }
    }
}