using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3SheetProxy : E3ProxyBase
    {
        public E3SheetProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int checkin(int unlock = 1)
        {
            return ComObject.checkin(unlock);
        }

        public int checkin(int unlock, ref object sheetids)
        {
            return ComObject.checkin(unlock, ref sheetids);
        }

        public int CheckInAll(int unlock = 1)
        {
            return ComObject.CheckInAll(unlock);
        }

        public int CheckOut(int @lock = 1)
        {
            return ComObject.CheckOut(@lock);
        }

        public int CheckOut(int @lock, ref object sheetids)
        {
            return ComObject.CheckOut(@lock, ref sheetids);
        }

        public int CheckOutAll(int @lock = 1)
        {
            return ComObject.CheckOutAll(@lock);
        }

        public int CheckoutReadonlyReferencedSheets()
        {
            return ComObject.CheckoutReadonlyReferencedSheets();
        }

        public int Create(int modi, string name, string symbol, int position, int before)
        {
            return ComObject.Create(modi, name, symbol, position, before);
        }

        public int CreateBoard(int brdi, string name, string symbol, int position, int before, double refx, double refy,
            double refscale)
        {
            return ComObject.CreateBoard(brdi, name, symbol, position, before, refx, refy, refscale);
        }

        public int CreateFormboard(int modi, string name, string symbol, int position, int before, int flags)
        {
            return ComObject.CreateFormboard(modi, name, symbol, position, before, flags);
        }

        public int CreateFormboardEx(int modi, string name, string symbol, int position, int before, double refx, double refy,
            double refscale)
        {
            return ComObject.CreateFormboardEx(modi, name, symbol, position, before, refx, refy, refscale);
        }

        public int CreateFunctionalDesign(int modi, string name, string symbol, int position, int before, int flags)
        {
            return ComObject.CreateFunctionalDesign(modi, name, symbol, position, before, flags);
        }

        public int CreatePanel(int modi, string name, string symbol, int position, int before, double refx, double refy,
            double refscale)
        {
            return ComObject.CreatePanel(modi, name, symbol, position, before, refx, refy, refscale);
        }

        public int CreateTopology(int modi, string name, string symbol, int position, int before, double refscale)
        {
            return ComObject.CreateTopology(modi, name, symbol, position, before, refscale);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int Display()
        {
            return ComObject.Display();
        }

        public int Export(string format, int version, string file, int flags = 0)
        {
            return ComObject.Export(format, version, file, flags);
        }

        public int ExportImage(string format, int version, string file, int dpi = 0, int compressionmode = 0)
        {
            return ComObject.ExportImage(format, version, file, dpi, compressionmode);
        }

        public int ExportImageArea(string format, int version, string file, double xl, double yl, double xr, double yr, int width,
            int height, int clrdepth, int gray, int dpiX, int dpiY, int compressionmode)
        {
            return ComObject.ExportImageArea(format, version, file, xl, yl, xr, yr, width, height, clrdepth, gray, dpiX, dpiY, compressionmode);
        }

        public int ExportImageSelection(string format, int version, string file, int percentage, int width, int height, int clrdepth,
            int gray, int dpiX, int dpiY, int compressionmode)
        {
            return ComObject.ExportImageSelection(format, version, file, percentage, width, height, clrdepth, gray, dpiX, dpiY, compressionmode);
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

        public int GetBaseId()
        {
            return ComObject.GetBaseId();
        }

        public string GetCharacteristic()
        {
            return ComObject.GetCharacteristic();
        }

        public int GetContentModified()
        {
            return ComObject.GetContentModified();
        }

        public int GetDimensionIds(ref object ids)
        {
            return ComObject.GetDimensionIds(ref ids);
        }

        public int GetDrawingArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetDrawingArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public int GetEmbeddedSheetIds(ref object ids)
        {
            return ComObject.GetEmbeddedSheetIds(ref ids);
        }

        public string GetFormat()
        {
            return ComObject.GetFormat();
        }

        public int GetGetterOptionHandlingMode()
        {
            return ComObject.GetGetterOptionHandlingMode();
        }

        public int GetGraphCount()
        {
            return ComObject.GetGraphCount();
        }

        public int GetGraphIds(ref object ids)
        {
            return ComObject.GetGraphIds(ref ids);
        }

        public int GetGroupIds(ref object ids)
        {
            return ComObject.GetGroupIds(ref ids);
        }

        public int GetHyperlinkTextIds(ref object ids)
        {
            return ComObject.GetHyperlinkTextIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInsideGraphIds(ref object ids)
        {
            return ComObject.GetInsideGraphIds(ref ids);
        }

        public int GetInsideNetSegmentIds(ref object ids)
        {
            return ComObject.GetInsideNetSegmentIds(ref ids);
        }

        public int GetInsidePanelConnectionIds(ref object ids)
        {
            return ComObject.GetInsidePanelConnectionIds(ref ids);
        }

        public int GetInsideSymbolIds(ref object ids)
        {
            return ComObject.GetInsideSymbolIds(ref ids);
        }

        public string GetLocation()
        {
            return ComObject.GetLocation();
        }

        public int GetModuleCount()
        {
            return ComObject.GetModuleCount();
        }

        public int GetModuleIds(ref object ids)
        {
            return ComObject.GetModuleIds(ref ids);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNetIds(ref object ids)
        {
            return ComObject.GetNetIds(ref ids);
        }

        public int GetNetSegmentCount()
        {
            return ComObject.GetNetSegmentCount();
        }

        public int GetNetSegmentIds(ref object ids)
        {
            return ComObject.GetNetSegmentIds(ref ids);
        }

        public int GetOpenNetsegmentIds(ref object ids)
        {
            return ComObject.GetOpenNetsegmentIds(ref ids);
        }

        public string GetOwner()
        {
            return ComObject.GetOwner();
        }

        public int GetPanelConnectionIds(ref object ids)
        {
            return ComObject.GetPanelConnectionIds(ref ids);
        }

        public int GetPanelRegion(ref object xoff, ref object yoff, ref object scale)
        {
            return ComObject.GetPanelRegion(ref xoff, ref yoff, ref scale);
        }

        public int GetParentSheetId()
        {
            return ComObject.GetParentSheetId();
        }

        public int GetRedlinedGraphIds(ref object ids)
        {
            return ComObject.GetRedlinedGraphIds(ref ids);
        }

        public int GetRedlinedGraphTextIds(ref object ids)
        {
            return ComObject.GetRedlinedGraphTextIds(ref ids);
        }

        public int GetRegionArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetRegionArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public int GetSchematicTypes(ref object types)
        {
            return ComObject.GetSchematicTypes(ref types);
        }

        public int GetSharedIds(ref object ids)
        {
            return ComObject.GetSharedIds(ref ids);
        }

        public int GetSheetRegion(ref object xoff, ref object yoff, ref object scale)
        {
            return ComObject.GetSheetRegion(ref xoff, ref yoff, ref scale);
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public int GetTextCount()
        {
            return ComObject.GetTextCount();
        }

        public int GetTextIds(ref object ids, int txttyp = 0, string search_string = "")
        {
            return ComObject.GetTextIds(ref ids, txttyp, search_string);
        }

        public int GetTopologyRegion(ref object xoff, ref object yoff, ref object scale)
        {
            return ComObject.GetTopologyRegion(ref xoff, ref yoff, ref scale);
        }

        public int GetValidCharacteristics(ref object characteristics)
        {
            return ComObject.GetValidCharacteristics(ref characteristics);
        }

        public int GetVisibleArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetVisibleArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public int GetWorkingArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetWorkingArea(ref xMin, ref yMin, ref xMax, ref yMax);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int ImportDGN(string filename, double scale, double x, double y, int rot, string font, int flags)
        {
            return ComObject.ImportDGN(filename, scale, x, y, rot, font, flags);
        }

        public int ImportDXF(string filename, double scale, double x, double y, int rot, string font, int inbox = 0)
        {
            return ComObject.ImportDXF(filename, scale, x, y, rot, font, inbox);
        }

        public int Is2DView()
        {
            return ComObject.Is2DView();
        }

        public int IsClipboardPart()
        {
            return ComObject.IsClipboardPart();
        }

        public int IsEmbedded()
        {
            return ComObject.IsEmbedded();
        }

        public int IsFormboard()
        {
            return ComObject.IsFormboard();
        }

        public int IsFunctionalDesign()
        {
            return ComObject.IsFunctionalDesign();
        }

        public int IsLocked()
        {
            return ComObject.IsLocked();
        }

        public int IsOffline()
        {
            return ComObject.IsOffline();
        }

        public int IsPanel()
        {
            return ComObject.IsPanel();
        }

        public int IsParentSheet(int flags)
        {
            return ComObject.IsParentSheet(flags);
        }

        public int IsReadOnly()
        {
            return ComObject.IsReadOnly();
        }

        public int IsShared()
        {
            return ComObject.IsShared();
        }

        public int IsTerminalPlan()
        {
            return ComObject.IsTerminalPlan();
        }

        public int IsTopology()
        {
            return ComObject.IsTopology();
        }

        public int LockObject()
        {
            return ComObject.LockObject();
        }

        public int MoveTo(int position, int before = 0)
        {
            return ComObject.MoveTo(position, before);
        }

        public int PlacePart(string name, string version, double x, double y, double rot)
        {
            return ComObject.PlacePart(name, version, x, y, rot);
        }

        public int PlacePartEx(string name, string version, int flags, double x, double y, double rot)
        {
            return ComObject.PlacePartEx(name, version, flags, x, y, rot);
        }

        public int PrintOut(double scale)
        {
            return ComObject.PrintOut(scale);
        }

        public int Remove()
        {
            return ComObject.Remove();
        }

        public int Search(int modi, string name)
        {
            return ComObject.Search(modi, name);
        }

        public int SetAssignment(string newass)
        {
            return ComObject.SetAssignment(newass);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetCharacteristic(string characteristic)
        {
            return ComObject.SetCharacteristic(characteristic);
        }

        public int SetCompleteName(string newnam, string newass, string newloc)
        {
            return ComObject.SetCompleteName(newnam, newass, newloc);
        }

        public int SetCompleteNameEx(string newnam, string newass, string newloc, int onlygiven)
        {
            return ComObject.SetCompleteNameEx(newnam, newass, newloc, onlygiven);
        }

        public int SetContentModified(int value)
        {
            return ComObject.SetContentModified(value);
        }

        public int SetFormat(string sym, string rot = null)
        {
            return ComObject.SetFormat(sym, rot);
        }

        public int SetGetterOptionHandlingMode(int mode)
        {
            return ComObject.SetGetterOptionHandlingMode(mode);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetLocation(string newloc)
        {
            return ComObject.SetLocation(newloc);
        }

        public string SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public int SetPanelRegion(double xoff, double yoff, double scale)
        {
            return ComObject.SetPanelRegion(xoff, yoff, scale);
        }

        public int SetSchematicTypes(ref object types)
        {
            return ComObject.SetSchematicTypes(ref types);
        }

        public int SetSheetRegion(double xoff, double yoff, double scale)
        {
            return ComObject.SetSheetRegion(xoff, yoff, scale);
        }

        public int SetTopologyRegion(double xoff, double yoff, double scale)
        {
            return ComObject.SetTopologyRegion(xoff, yoff, scale);
        }

        public int SetVisibleArea(double xMin, double yMin, double xMax, double yMax)
        {
            return ComObject.SetVisibleArea(xMin, yMin, xMax, yMax);
        }

        public int ShareWithID(int id)
        {
            return ComObject.ShareWithID(id);
        }

        public int ToGrid(ref object xpos, ref object ypos)
        {
            return ComObject.ToGrid(ref xpos, ref ypos);
        }

        public int UnlockObject(string password)
        {
            return ComObject.UnlockObject(password);
        }

        public int Visible()
        {
            return ComObject.Visible();
        }
    }
}