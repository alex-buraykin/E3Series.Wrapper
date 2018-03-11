using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3JobProxy : E3ProxyBase
    {
        public E3JobProxy(object comObject) : base(comObject)
        {
        }

        public int ActivateOptionAlias(string alias)
        {
            return ComObject.ActivateOptionAlias(alias);
        }

        public int ActivateOptionIds(ref object ids)
        {
            return ComObject.ActivateOptionIds(ref ids);
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddOptionAlias(string name, string description)
        {
            return ComObject.AddOptionAlias(name, description);
        }

        public int ClearItemCollectors()
        {
            return ComObject.ClearItemCollectors();
        }

        public int Close()
        {
            return ComObject.Close();
        }

        public int ConvertMultiByteToWideChar(int code_page)
        {
            return ComObject.ConvertMultiByteToWideChar(code_page);
        }

        public int Create(string name)
        {
            return ComObject.Create(name);
        }

        public object CreateAttributeObject()
        {
            return ComObject.CreateAttributeObject();
        }

        public object CreateBinDataObject()
        {
            return ComObject.CreateBinDataObject();
        }

        public object CreateBoardObject()
        {
            return ComObject.CreateBoardObject();
        }

        public object CreateBundleObject()
        {
            return ComObject.CreateBundleObject();
        }

        public object CreateComponentObject()
        {
            return ComObject.CreateComponentObject();
        }

        public object CreateConnectionObject()
        {
            return ComObject.CreateConnectionObject();
        }

        public object CreateConnectLineObject()
        {
            return ComObject.CreateConnectLineObject();
        }

        public object CreateDebugObject()
        {
            return ComObject.CreateDebugObject();
        }

        public object CreateDeviceObject()
        {
            return ComObject.CreateDeviceObject();
        }

        public object CreateDimensionObject()
        {
            return ComObject.CreateDimensionObject();
        }

        public object CreateExternalDocumentObject()
        {
            return ComObject.CreateExternalDocumentObject();
        }

        public object CreateFieldObject()
        {
            return ComObject.CreateFieldObject();
        }

        public object CreateFunctionalPortObject()
        {
            return ComObject.CreateFunctionalPortObject();
        }

        public object CreateFunctionalUnitObject()
        {
            return ComObject.CreateFunctionalUnitObject();
        }

        public object CreateGraphObject()
        {
            return ComObject.CreateGraphObject();
        }

        public object CreateGroupObject()
        {
            return ComObject.CreateGroupObject();
        }

        public int CreateInlineConnectors(out object newCoreIDs, out object newDeviceIDs, int flags, ref object fromPinIDs,
            ref object toPinIDs, ref object viewNumbers, ref object fBSheetIDs, string CompName, string CompVersion)
        {
            return ComObject.CreateInlineConnectors(out newCoreIDs, out newDeviceIDs, flags, ref fromPinIDs, ref toPinIDs, ref viewNumbers, ref fBSheetIDs, CompName, CompVersion);
        }

        public int CreateInlineConnectorsEx(out object newCoreIDs, out object newDeviceIDs, int flags, ref object fromPinIDs,
            ref object toPinIDs, ref object viewNumbers, ref object fBSheetIDs, string CompName, string CompVersion,
            ref object newSymbolIDs)
        {
            return ComObject.CreateInlineConnectorsEx(out newCoreIDs, out newDeviceIDs, flags, ref fromPinIDs, ref toPinIDs, ref viewNumbers, ref fBSheetIDs, CompName, CompVersion, ref newSymbolIDs);
        }

        public object CreateLayerObject()
        {
            return ComObject.CreateLayerObject();
        }

        public object CreateModuleObject()
        {
            return ComObject.CreateModuleObject();
        }

        public object CreateModulePortObject()
        {
            return ComObject.CreateModulePortObject();
        }

        public object CreateNetObject()
        {
            return ComObject.CreateNetObject();
        }

        public object CreateNetSegmentObject()
        {
            return ComObject.CreateNetSegmentObject();
        }

        public object CreateOptionObject()
        {
            return ComObject.CreateOptionObject();
        }

        public object CreateOutlineObject()
        {
            return ComObject.CreateOutlineObject();
        }

        public object CreatePinObject()
        {
            return ComObject.CreatePinObject();
        }

        public object CreateSheetObject()
        {
            return ComObject.CreateSheetObject();
        }

        public object CreateSignalClassObject()
        {
            return ComObject.CreateSignalClassObject();
        }

        public object CreateSignalObject()
        {
            return ComObject.CreateSignalObject();
        }

        public object CreateSlotObject()
        {
            return ComObject.CreateSlotObject();
        }

        public object CreateStructureNodeObject()
        {
            return ComObject.CreateStructureNodeObject();
        }

        public object CreateSupplyObject()
        {
            return ComObject.CreateSupplyObject();
        }

        public object CreateSymbolObject()
        {
            return ComObject.CreateSymbolObject();
        }

        public object CreateTestpointObject()
        {
            return ComObject.CreateTestpointObject();
        }

        public object CreateTextObject()
        {
            return ComObject.CreateTextObject();
        }

        public object CreateTreeObject()
        {
            return ComObject.CreateTreeObject();
        }

        public object CreateVariantObject()
        {
            return ComObject.CreateVariantObject();
        }

        public int DeactivateOptionIds(ref object ids)
        {
            return ComObject.DeactivateOptionIds(ref ids);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteAttributeDefinition(string attnam)
        {
            return ComObject.DeleteAttributeDefinition(attnam);
        }

        public int DeleteMultiuser(string name)
        {
            return ComObject.DeleteMultiuser(name);
        }

        public int DeleteOptionAlias(string name)
        {
            return ComObject.DeleteOptionAlias(name);
        }

        public int DisablePointGridDisplay()
        {
            return ComObject.DisablePointGridDisplay();
        }

        public int DisableRulerGridDisplay()
        {
            return ComObject.DisableRulerGridDisplay();
        }

        public void DisableSuffixSuppression()
        {
            ComObject.DisableSuffixSuppression();
        }

        public int DumpItem(int id)
        {
            return ComObject.DumpItem(id);
        }

        public int EnablePointGridDisplay()
        {
            return ComObject.EnablePointGridDisplay();
        }

        public int EnableRulerGridDisplay()
        {
            return ComObject.EnableRulerGridDisplay();
        }

        public void EnableSuffixSuppression()
        {
            ComObject.EnableSuffixSuppression();
        }

        public int ExportAllComponentsToDB(int bOverwrite)
        {
            return ComObject.ExportAllComponentsToDB(bOverwrite);
        }

        public int ExportAllModelsToDB(int bOverwrite)
        {
            return ComObject.ExportAllModelsToDB(bOverwrite);
        }

        public int ExportAllSymbolsToDB(int bOverwrite)
        {
            return ComObject.ExportAllSymbolsToDB(bOverwrite);
        }

        public int ExportBoardLayout(string type, string file = null, int flags = 0, string map = null)
        {
            return ComObject.ExportBoardLayout(type, file, flags, map);
        }

        public int ExportBoardLayout(string type, string file, int flags, string map, ref object exclusions)
        {
            return ComObject.ExportBoardLayout(type, file, flags, map, ref exclusions);
        }

        public int ExportCGM(string file, ref object shtids, int options)
        {
            return ComObject.ExportCGM(file, ref shtids, options);
        }

        public int ExportComponentToDB(string CompName, string CompVersion, int bOverwrite)
        {
            return ComObject.ExportComponentToDB(CompName, CompVersion, bOverwrite);
        }

        public int ExportDrawing(string name, ref object shtids, int options)
        {
            return ComObject.ExportDrawing(name, ref shtids, options);
        }

        public int ExportForeign(string format, string file)
        {
            return ComObject.ExportForeign(format, file);
        }

        public int ExportImageItems(string format, int version, string file, ref object items, int percentage, int width, int height,
            int clrdepth, int gray, int dpiX, int dpiY, int compressionmode)
        {
            return ComObject.ExportImageItems(format, version, file, ref items, percentage, width, height, clrdepth, gray, dpiX, dpiY, compressionmode);
        }

        public int ExportModelToDB(string CompName, string CompVersion, int bOverwrite)
        {
            return ComObject.ExportModelToDB(CompName, CompVersion, bOverwrite);
        }

        public int ExportMultiuser(string file, uint fileformat, string name)
        {
            return ComObject.ExportMultiuser(file, fileformat, name);
        }

        public int ExportPDF(string file, ref object shtids, int options, string password = null)
        {
            return ComObject.ExportPDF(file, ref shtids, options, password);
        }

        public int ExportPDFEx(string file, ref object shtids, int options, int itemListType, ref object items, int alternativeColour,
            int imageBrightness, string password = null)
        {
            return ComObject.ExportPDFEx(file, ref shtids, options, itemListType, ref items, alternativeColour, imageBrightness, password);
        }

        public int ExportSVGByArea(string file, int shtId, double xMin, double yMin, double xMax, double yMax, double originX,
            double originY, int selectionMode)
        {
            return ComObject.ExportSVGByArea(file, shtId, xMin, yMin, xMax, yMax, originX, originY, selectionMode);
        }

        public int ExportSVGBySheet(string file, ref object shtids)
        {
            return ComObject.ExportSVGBySheet(file, ref shtids);
        }

        public int ExportSVGBySheetEx(string file, ref object shtids, int options)
        {
            return ComObject.ExportSVGBySheetEx(file, ref shtids, options);
        }

        public int ExportSymbolToDB(string SymbolName, string SymbolVersion, int bOverwrite)
        {
            return ComObject.ExportSymbolToDB(SymbolName, SymbolVersion, bOverwrite);
        }

        public int ExportTemplate(string filename)
        {
            return ComObject.ExportTemplate(filename);
        }

        public int ExportToDB(int bOverwrite)
        {
            return ComObject.ExportToDB(bOverwrite);
        }

        public int ExportXVL(string file, ref object ids)
        {
            return ComObject.ExportXVL(file, ref ids);
        }

        public int FinalizeTransaction()
        {
            return ComObject.FinalizeTransaction();
        }

        public int FindPanelPath()
        {
            return ComObject.FindPanelPath();
        }

        public int FreeWireNumber(int number)
        {
            return ComObject.FreeWireNumber(number);
        }

        public int GetActiveOptionCount()
        {
            return ComObject.GetActiveOptionCount();
        }

        public int GetActiveOptionIds(ref object ids)
        {
            return ComObject.GetActiveOptionIds(ref ids);
        }

        public int GetActiveSheetId()
        {
            return ComObject.GetActiveSheetId();
        }

        public int GetActiveSheetTreeID()
        {
            return ComObject.GetActiveSheetTreeID();
        }

        public int GetActiveTreeID()
        {
            return ComObject.GetActiveTreeID();
        }

        public int GetActiveVariantId()
        {
            return ComObject.GetActiveVariantId();
        }

        public int GetAddDeviceDesignationOfConnectionTarget()
        {
            return ComObject.GetAddDeviceDesignationOfConnectionTarget();
        }

        public int GetAllComponentCount()
        {
            return ComObject.GetAllComponentCount();
        }

        public int GetAllComponentIds(ref object ids)
        {
            return ComObject.GetAllComponentIds(ref ids);
        }

        public int GetAllConnectionCount(int flags = 0)
        {
            return ComObject.GetAllConnectionCount(flags);
        }

        public int GetAllConnectionIds(ref object ids, int flags = 0)
        {
            return ComObject.GetAllConnectionIds(ref ids, flags);
        }

        public int GetAllDeviceCount()
        {
            return ComObject.GetAllDeviceCount();
        }

        public int GetAllDeviceIds(ref object ids)
        {
            return ComObject.GetAllDeviceIds(ref ids);
        }

        public int GetAllOptionIds(ref object ids)
        {
            return ComObject.GetAllOptionIds(ref ids);
        }

        public int GetAllParentSheetIds(int flags, ref object ids)
        {
            return ComObject.GetAllParentSheetIds(flags, ref ids);
        }

        public int GetAllSheetIds(ref object ids)
        {
            return ComObject.GetAllSheetIds(ref ids);
        }

        public double GetAltGridSize()
        {
            return ComObject.GetAltGridSize();
        }

        public int GetAnyAttributeIds(string attnam, ref object ids)
        {
            return ComObject.GetAnyAttributeIds(attnam, ref ids);
        }

        public string GetAssignmentSeparator()
        {
            return ComObject.GetAssignmentSeparator();
        }

        public string GetAssignmentSuffixSeparator()
        {
            return ComObject.GetAssignmentSuffixSeparator();
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = null)
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public int GetAttributeNotInheritable(string attnam)
        {
            return ComObject.GetAttributeNotInheritable(attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetAvailableLanguages(ref object languages)
        {
            return ComObject.GetAvailableLanguages(ref languages);
        }

        public int GetBlockCopyGraphicInSplit()
        {
            return ComObject.GetBlockCopyGraphicInSplit();
        }

        public int GetBlockCount()
        {
            return ComObject.GetBlockCount();
        }

        public int GetBlockIds(ref object ids)
        {
            return ComObject.GetBlockIds(ref ids);
        }

        public int GetBlockReferenceTextDirection()
        {
            return ComObject.GetBlockReferenceTextDirection();
        }

        public double GetBlockReferenceTextGap()
        {
            return ComObject.GetBlockReferenceTextGap();
        }

        public int GetBlockReferenceTextLevel()
        {
            return ComObject.GetBlockReferenceTextLevel();
        }

        public int GetBlockReferenceTextRotate()
        {
            return ComObject.GetBlockReferenceTextRotate();
        }

        public int GetBlockReferenceType()
        {
            return ComObject.GetBlockReferenceType();
        }

        public int GetBlockTextAlignment()
        {
            return ComObject.GetBlockTextAlignment();
        }

        public int GetBlockTextColour()
        {
            return ComObject.GetBlockTextColour();
        }

        public string GetBlockTextFont()
        {
            return ComObject.GetBlockTextFont();
        }

        public int GetBlockTextRatio()
        {
            return ComObject.GetBlockTextRatio();
        }

        public double GetBlockTextSize()
        {
            return ComObject.GetBlockTextSize();
        }

        public int GetBlockTextStyle()
        {
            return ComObject.GetBlockTextStyle();
        }

        public int GetBoardIds(ref object ids)
        {
            return ComObject.GetBoardIds(ref ids);
        }

        public int GetBomPartList(string consumer, string outputFormatVersion, int flags, string keyAttribut, string quantityAttribut,
            string lengthAttribut, ref object additionalAttributes)
        {
            return ComObject.GetBomPartList(consumer, outputFormatVersion, flags, keyAttribut, quantityAttribut, lengthAttribut, ref additionalAttributes);
        }

        public int GetBomPartList(string consumer, string outputFormatVersion, int flags, string keyAttribut, string quantityAttribut,
            string lengthAttribut, ref object additionalAttributes, ref object result)
        {
            return ComObject.GetBomPartList(consumer, outputFormatVersion, flags, keyAttribut, quantityAttribut, lengthAttribut, ref additionalAttributes, ref result);
        }

        public int GetBooleanState(string expression)
        {
            return ComObject.GetBooleanState(expression);
        }

        public int GetBundleCount()
        {
            return ComObject.GetBundleCount();
        }

        public int GetBundleIds(ref object ids)
        {
            return ComObject.GetBundleIds(ref ids);
        }

        public int GetBusLineColour()
        {
            return ComObject.GetBusLineColour();
        }

        public int GetBusLineLevel()
        {
            return ComObject.GetBusLineLevel();
        }

        public int GetBusLineStyle()
        {
            return ComObject.GetBusLineStyle();
        }

        public int GetBusLineWidth()
        {
            return ComObject.GetBusLineWidth();
        }

        public double GetBusLineWidthEx()
        {
            return ComObject.GetBusLineWidthEx();
        }

        public int GetCableCount()
        {
            return ComObject.GetCableCount();
        }

        public int GetCableIds(ref object ids)
        {
            return ComObject.GetCableIds(ref ids);
        }

        public int GetCableTypeCount()
        {
            return ComObject.GetCableTypeCount();
        }

        public int GetCableTypeIds(ref object ids)
        {
            return ComObject.GetCableTypeIds(ref ids);
        }

        public int GetCadstarCrossProbing()
        {
            return ComObject.GetCadstarCrossProbing();
        }

        public int GetComponentCount()
        {
            return ComObject.GetComponentCount();
        }

        public int GetComponentIds(ref object ids)
        {
            return ComObject.GetComponentIds(ref ids);
        }

        public int GetConnectionCount()
        {
            return ComObject.GetConnectionCount();
        }

        public int GetConnectionIds(ref object ids)
        {
            return ComObject.GetConnectionIds(ref ids);
        }

        public double GetConnectionInclinationAngle()
        {
            return ComObject.GetConnectionInclinationAngle();
        }

        public double GetConnectionInclinationDistance()
        {
            return ComObject.GetConnectionInclinationDistance();
        }

        public int GetConnectionMode()
        {
            return ComObject.GetConnectionMode();
        }

        public int GetConnectionTargetFormat(int txttyp, out object flags, out object entire_prefix, out object entire_suffix,
            out object count, out object prefix, out object name, out object funct)
        {
            return ComObject.GetConnectionTargetFormat(txttyp, out flags, out entire_prefix, out entire_suffix, out count, out prefix, out name, out funct);
        }

        public int GetConnectorCount()
        {
            return ComObject.GetConnectorCount();
        }

        public int GetConnectorIds(ref object ids)
        {
            return ComObject.GetConnectorIds(ref ids);
        }

        public int GetConnectorPinTerminalParameterOverwriteModelPin()
        {
            return ComObject.GetConnectorPinTerminalParameterOverwriteModelPin();
        }

        public int GetConnectorSymbolFormat(out object texttypes, out object dispflags)
        {
            return ComObject.GetConnectorSymbolFormat(out texttypes, out dispflags);
        }

        public int GetCreateUniqueSheetNames()
        {
            return ComObject.GetCreateUniqueSheetNames();
        }

        public string GetCurrentUserName()
        {
            return ComObject.GetCurrentUserName();
        }

        public int GetCurrentUserNames(ref object names)
        {
            return ComObject.GetCurrentUserNames(ref names);
        }

        public int GetCursorPosition(ref object xpos, ref object ypos)
        {
            return ComObject.GetCursorPosition(ref xpos, ref ypos);
        }

        public int GetDefaultHoseTube(out object HoseTube)
        {
            return ComObject.GetDefaultHoseTube(out HoseTube);
        }

        public int GetDefaultJumper(out object jumpergroup, out object jumpername)
        {
            return ComObject.GetDefaultJumper(out jumpergroup, out jumpername);
        }

        public int GetDefaultWire(out object wiregroup, out object wirename)
        {
            return ComObject.GetDefaultWire(out wiregroup, out wirename);
        }

        public int GetDeleteCoresOnDelCline()
        {
            return ComObject.GetDeleteCoresOnDelCline();
        }

        public int GetDeletePinAttributesOnUnplace()
        {
            return ComObject.GetDeletePinAttributesOnUnplace();
        }

        public int GetDeleteSignalOnDelCline()
        {
            return ComObject.GetDeleteSignalOnDelCline();
        }

        public int GetDetermineConnectorSymbol()
        {
            return ComObject.GetDetermineConnectorSymbol();
        }

        public int GetDetermineConnectorViewSymbol()
        {
            return ComObject.GetDetermineConnectorViewSymbol();
        }

        public int GetDeviceCount()
        {
            return ComObject.GetDeviceCount();
        }

        public int GetDeviceIds(ref object ids)
        {
            return ComObject.GetDeviceIds(ref ids);
        }

        public string GetDeviceNameSeparator()
        {
            return ComObject.GetDeviceNameSeparator();
        }

        public string GetDeviceNameSuffixSeparator()
        {
            return ComObject.GetDeviceNameSuffixSeparator();
        }

        public string GetDisplayAltCompCode()
        {
            return ComObject.GetDisplayAltCompCode();
        }

        public int GetDisplayAppendFormboardNameToDeviceName()
        {
            return ComObject.GetDisplayAppendFormboardNameToDeviceName();
        }

        public int GetDisplayConnectionMode()
        {
            return ComObject.GetDisplayConnectionMode();
        }

        public int GetDisplayConnectionType()
        {
            return ComObject.GetDisplayConnectionType();
        }

        public int GetDisplayConnectPoints()
        {
            return ComObject.GetDisplayConnectPoints();
        }

        public int GetDisplayDuctDockingPoints()
        {
            return ComObject.GetDisplayDuctDockingPoints();
        }

        public int GetDisplayDuctFillSize()
        {
            return ComObject.GetDisplayDuctFillSize();
        }

        public int GetDisplayFormboardEffectiveDirection()
        {
            return ComObject.GetDisplayFormboardEffectiveDirection();
        }

        public int GetDisplayFormboardMarkDifferenLength()
        {
            return ComObject.GetDisplayFormboardMarkDifferenLength();
        }

        public int GetDisplayFormboardNodes()
        {
            return ComObject.GetDisplayFormboardNodes();
        }

        public int GetDisplayFormboardTableSubsidiaryLines()
        {
            return ComObject.GetDisplayFormboardTableSubsidiaryLines();
        }

        public int GetDisplayFormboardUnconnectedCores()
        {
            return ComObject.GetDisplayFormboardUnconnectedCores();
        }

        public int GetDisplayIntExtRepresentation()
        {
            return ComObject.GetDisplayIntExtRepresentation();
        }

        public int GetDisplayMILStandard()
        {
            return ComObject.GetDisplayMILStandard();
        }

        public int GetDisplayOptionsAll()
        {
            return ComObject.GetDisplayOptionsAll();
        }

        public int GetDisplayOptionsColoured()
        {
            return ComObject.GetDisplayOptionsColoured();
        }

        public int GetDisplayOptionsNone()
        {
            return ComObject.GetDisplayOptionsNone();
        }

        public int GetDisplayRotatedTextAccStandard()
        {
            return ComObject.GetDisplayRotatedTextAccStandard();
        }

        public int GetDisplayUnconnectedNodes()
        {
            return ComObject.GetDisplayUnconnectedNodes();
        }

        public int GetDisplayViewNumbers()
        {
            return ComObject.GetDisplayViewNumbers();
        }

        public int GetExclusiveMode(string name, out object user)
        {
            return ComObject.GetExclusiveMode(name, out user);
        }

        public int GetExportWithCablesAndWires()
        {
            return ComObject.GetExportWithCablesAndWires();
        }

        public int GetExportWithCablesAndWiresOption()
        {
            return ComObject.GetExportWithCablesAndWiresOption();
        }

        public int GetExternalDocumentCount()
        {
            return ComObject.GetExternalDocumentCount();
        }

        public int GetExternalDocumentIds(ref object ids)
        {
            return ComObject.GetExternalDocumentIds(ref ids);
        }

        public int GetFieldCount()
        {
            return ComObject.GetFieldCount();
        }

        public int GetFieldHatchColour()
        {
            return ComObject.GetFieldHatchColour();
        }

        public double GetFieldHatchLineDistance()
        {
            return ComObject.GetFieldHatchLineDistance();
        }

        public double GetFieldHatchLineWidth()
        {
            return ComObject.GetFieldHatchLineWidth();
        }

        public int GetFieldHatchPattern()
        {
            return ComObject.GetFieldHatchPattern();
        }

        public int GetFieldIds(ref object ids)
        {
            return ComObject.GetFieldIds(ref ids);
        }

        public int GetFieldOutlineColour()
        {
            return ComObject.GetFieldOutlineColour();
        }

        public int GetFieldOutlineStyle()
        {
            return ComObject.GetFieldOutlineStyle();
        }

        public double GetFieldOutlineWidth()
        {
            return ComObject.GetFieldOutlineWidth();
        }

        public string GetFieldTextTemplate()
        {
            return ComObject.GetFieldTextTemplate();
        }

        public int GetFileVersion(string filename)
        {
            return ComObject.GetFileVersion(filename);
        }

        public int GetFormboardAutoplaceTableSymbol()
        {
            return ComObject.GetFormboardAutoplaceTableSymbol();
        }

        public int GetFormboardAutorotateConnectorSymbols()
        {
            return ComObject.GetFormboardAutorotateConnectorSymbols();
        }

        public int GetFormboardBranchAngleStep()
        {
            return ComObject.GetFormboardBranchAngleStep();
        }

        public int GetFunctionalUnitIds(ref object ids)
        {
            return ComObject.GetFunctionalUnitIds(ref ids);
        }

        public double GetGapToPlaceSinglePins()
        {
            return ComObject.GetGapToPlaceSinglePins();
        }

        public int GetGeneratedWireNameFormat(out object prefix, out object separator, out object postfix, out object attPrefix,
            out object attType, out object attname)
        {
            return ComObject.GetGeneratedWireNameFormat(out prefix, out separator, out postfix, out attPrefix, out attType, out attname);
        }

        public int GetGetterOptionHandlingMode()
        {
            return ComObject.GetGetterOptionHandlingMode();
        }

        public string GetGidOfId(int id)
        {
            return ComObject.GetGidOfId(id);
        }

        public int GetGraphArrows()
        {
            return ComObject.GetGraphArrows();
        }

        public int GetGraphColour()
        {
            return ComObject.GetGraphColour();
        }

        public int GetGraphHatchColour()
        {
            return ComObject.GetGraphHatchColour();
        }

        public double GetGraphHatchDistance()
        {
            return ComObject.GetGraphHatchDistance();
        }

        public int GetGraphHatchPattern(ref object angle1, ref object angle2)
        {
            return ComObject.GetGraphHatchPattern(ref angle1, ref angle2);
        }

        public int GetGraphHatchStyle()
        {
            return ComObject.GetGraphHatchStyle();
        }

        public double GetGraphHatchWidth()
        {
            return ComObject.GetGraphHatchWidth();
        }

        public int GetGraphLevel()
        {
            return ComObject.GetGraphLevel();
        }

        public int GetGraphStyle()
        {
            return ComObject.GetGraphStyle();
        }

        public int GetGraphTextColour()
        {
            return ComObject.GetGraphTextColour();
        }

        public int GetGraphTextCount()
        {
            return ComObject.GetGraphTextCount();
        }

        public string GetGraphTextFontName()
        {
            return ComObject.GetGraphTextFontName();
        }

        public double GetGraphTextHeight()
        {
            return ComObject.GetGraphTextHeight();
        }

        public int GetGraphTextIds(ref object ids)
        {
            return ComObject.GetGraphTextIds(ref ids);
        }

        public int GetGraphTextLevel()
        {
            return ComObject.GetGraphTextLevel();
        }

        public int GetGraphTextMode()
        {
            return ComObject.GetGraphTextMode();
        }

        public double GetGraphTextSize()
        {
            return ComObject.GetGraphTextSize();
        }

        public int GetGraphTextStyle()
        {
            return ComObject.GetGraphTextStyle();
        }

        public double GetGraphWidth()
        {
            return ComObject.GetGraphWidth();
        }

        public double GetGridSize()
        {
            return ComObject.GetGridSize();
        }

        public int GetGroupIds(ref object ids)
        {
            return ComObject.GetGroupIds(ref ids);
        }

        public int GetHarnessIds(ref object ids)
        {
            return ComObject.GetHarnessIds(ref ids);
        }

        public int GetHighlightColour()
        {
            return ComObject.GetHighlightColour();
        }

        public int GetHighlightKeep()
        {
            return ComObject.GetHighlightKeep();
        }

        public double GetHighlightLineWidth()
        {
            return ComObject.GetHighlightLineWidth();
        }

        public int GetHoseIds(ref object ids)
        {
            return ComObject.GetHoseIds(ref ids);
        }

        public int GetHyperlinkTextIds(ref object ids)
        {
            return ComObject.GetHyperlinkTextIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetIdOfGid(string gid)
        {
            return ComObject.GetIdOfGid(gid);
        }

        public int GetIEC61346Setting()
        {
            return ComObject.GetIEC61346Setting();
        }

        public string GetImportItemDesignationSuffix()
        {
            return ComObject.GetImportItemDesignationSuffix();
        }

        public int GetImportMergeAttributes()
        {
            return ComObject.GetImportMergeAttributes();
        }

        public int GetImportMergeConnectLines()
        {
            return ComObject.GetImportMergeConnectLines();
        }

        public int GetImportMergeExistingAssemblies()
        {
            return ComObject.GetImportMergeExistingAssemblies();
        }

        public int GetImportMergeExistingDevices()
        {
            return ComObject.GetImportMergeExistingDevices();
        }

        public int GetImportMergeExistingTerminalStrips()
        {
            return ComObject.GetImportMergeExistingTerminalStrips();
        }

        public int GetImportMergeOptions()
        {
            return ComObject.GetImportMergeOptions();
        }

        public int GetImportUseItemDesignationSuffix()
        {
            return ComObject.GetImportUseItemDesignationSuffix();
        }

        public int GetItemSheetIds(int item, out object ids)
        {
            return ComObject.GetItemSheetIds(item, out ids);
        }

        public int GetItemType(int id)
        {
            return ComObject.GetItemType(id);
        }

        public int GetKeepActiveConnectorPinTerminalOnUpdate()
        {
            return ComObject.GetKeepActiveConnectorPinTerminalOnUpdate();
        }

        public int GetKeepActiveCounterpartOnUpdate()
        {
            return ComObject.GetKeepActiveCounterpartOnUpdate();
        }

        public int GetKeepActiveFittingOnUpdate()
        {
            return ComObject.GetKeepActiveFittingOnUpdate();
        }

        public int GetKeepConnectorSymbolsOnUpdate()
        {
            return ComObject.GetKeepConnectorSymbolsOnUpdate();
        }

        public int GetKeepModelTextParametersOnUpdate()
        {
            return ComObject.GetKeepModelTextParametersOnUpdate();
        }

        public int GetKeepModelTextVisibilityOnUpdate()
        {
            return ComObject.GetKeepModelTextVisibilityOnUpdate();
        }

        public int GetKeepSymbolTextParametersOnUpdate()
        {
            return ComObject.GetKeepSymbolTextParametersOnUpdate();
        }

        public int GetKeepSymbolTextVisibilityOnUpdate()
        {
            return ComObject.GetKeepSymbolTextVisibilityOnUpdate();
        }

        public int GetLanguages(ref object languages)
        {
            return ComObject.GetLanguages(ref languages);
        }

        public int GetLastAddedItems(ref object ids, int type = 0)
        {
            return ComObject.GetLastAddedItems(ref ids, type);
        }

        public int GetLastDeletedAttributeValues(ref object owner_ids, ref object attribute_names, ref object attribute_values)
        {
            return ComObject.GetLastDeletedAttributeValues(ref owner_ids, ref attribute_names, ref attribute_values);
        }

        public int GetLastDeletedItems(ref object items, int type)
        {
            return ComObject.GetLastDeletedItems(ref items, type);
        }

        public int GetLastModifiedItems(ref object ids, int type = 0)
        {
            return ComObject.GetLastModifiedItems(ref ids, type);
        }

        public int GetLayerIds(ref object ids)
        {
            return ComObject.GetLayerIds(ref ids);
        }

        public int GetLevelIndex(string value)
        {
            return ComObject.GetLevelIndex(value);
        }

        public string GetLevelName(int level)
        {
            return ComObject.GetLevelName(level);
        }

        public int GetLevels(ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr)
        {
            return ComObject.GetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr);
        }

        public int GetLevels(ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr, ref object names)
        {
            return ComObject.GetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr, ref names);
        }

        public int GetLineColour()
        {
            return ComObject.GetLineColour();
        }

        public int GetLineLevel()
        {
            return ComObject.GetLineLevel();
        }

        public int GetLineStyle()
        {
            return ComObject.GetLineStyle();
        }

        public int GetLineWidth()
        {
            return ComObject.GetLineWidth();
        }

        public double GetLineWidthEx()
        {
            return ComObject.GetLineWidthEx();
        }

        public string GetLocationSeparator()
        {
            return ComObject.GetLocationSeparator();
        }

        public string GetLocationSuffixSeparator()
        {
            return ComObject.GetLocationSuffixSeparator();
        }

        public string GetMeasure()
        {
            return ComObject.GetMeasure();
        }

        public int GetMergeAlphanumericReferences()
        {
            return ComObject.GetMergeAlphanumericReferences();
        }

        public int GetMergeSheetReferences()
        {
            return ComObject.GetMergeSheetReferences();
        }

        public int GetMergeUsingExactCoreConnectionOnImport()
        {
            return ComObject.GetMergeUsingExactCoreConnectionOnImport();
        }

        public int GetMILGraphicLineColour()
        {
            return ComObject.GetMILGraphicLineColour();
        }

        public int GetMILGraphicLineStyle()
        {
            return ComObject.GetMILGraphicLineStyle();
        }

        public double GetMILGraphicLineWidth()
        {
            return ComObject.GetMILGraphicLineWidth();
        }

        public int GetModuleIds(ref object ids)
        {
            return ComObject.GetModuleIds(ref ids);
        }

        public string GetMultiuserPath()
        {
            return ComObject.GetMultiuserPath();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNetIds(ref object ids)
        {
            return ComObject.GetNetIds(ref ids);
        }

        public int GetNetSegmentAttributeSplittingRule()
        {
            return ComObject.GetNetSegmentAttributeSplittingRule();
        }

        public int GetNetSegmentLengthSplittingRule()
        {
            return ComObject.GetNetSegmentLengthSplittingRule();
        }

        public int GetNewAllDeviceIds(ref object ids)
        {
            return ComObject.GetNewAllDeviceIds(ref ids);
        }

        public int GetNewBlockIds(ref object ids)
        {
            return ComObject.GetNewBlockIds(ref ids);
        }

        public int GetNewBundleIds(ref object ids)
        {
            return ComObject.GetNewBundleIds(ref ids);
        }

        public int GetNewCableIds(ref object ids)
        {
            return ComObject.GetNewCableIds(ref ids);
        }

        public int GetNewConnectionIds(ref object ids)
        {
            return ComObject.GetNewConnectionIds(ref ids);
        }

        public int GetNewConnectorIds(ref object ids)
        {
            return ComObject.GetNewConnectorIds(ref ids);
        }

        public int GetNewCoreIds(ref object ids)
        {
            return ComObject.GetNewCoreIds(ref ids);
        }

        public int GetNewDeviceIds(ref object ids)
        {
            return ComObject.GetNewDeviceIds(ref ids);
        }

        public int GetNewFieldIds(ref object ids)
        {
            return ComObject.GetNewFieldIds(ref ids);
        }

        public int GetNewGraphIds(ref object ids)
        {
            return ComObject.GetNewGraphIds(ref ids);
        }

        public int GetNewNetSegmentIds(ref object ids)
        {
            return ComObject.GetNewNetSegmentIds(ref ids);
        }

        public int GetNewSheetIds(ref object ids)
        {
            return ComObject.GetNewSheetIds(ref ids);
        }

        public int GetNewSignalIds(ref object ids)
        {
            return ComObject.GetNewSignalIds(ref ids);
        }

        public int GetNewSymbolIds(ref object ids)
        {
            return ComObject.GetNewSymbolIds(ref ids);
        }

        public int GetNewTerminalIds(ref object ids)
        {
            return ComObject.GetNewTerminalIds(ref ids);
        }

        public int GetNewTextIds(ref object ids, int txttyp = 0, string search_string = "")
        {
            return ComObject.GetNewTextIds(ref ids, txttyp, search_string);
        }

        public int GetNextWireNumber()
        {
            return ComObject.GetNextWireNumber();
        }

        public string GetNextWireNumberFormatted()
        {
            return ComObject.GetNextWireNumberFormatted();
        }

        public int GetOptionAliases(ref object ids)
        {
            return ComObject.GetOptionAliases(ref ids);
        }

        public int GetOptionCount()
        {
            return ComObject.GetOptionCount();
        }

        public int GetOptionIds(ref object ids)
        {
            return ComObject.GetOptionIds(ref ids);
        }

        public int GetOptionLockID()
        {
            return ComObject.GetOptionLockID();
        }

        public int GetOptionLockIDs(ref object ids)
        {
            return ComObject.GetOptionLockIDs(ref ids);
        }

        public string GetOptionTermDescription(string alias)
        {
            return ComObject.GetOptionTermDescription(alias);
        }

        public int GetOptionTerms(ref object ids)
        {
            return ComObject.GetOptionTerms(ref ids);
        }

        public int GetOutbarText(int index, ref object lst)
        {
            return ComObject.GetOutbarText(index, ref lst);
        }

        public int GetOutdatedAllComponentIds(ref object ids)
        {
            return ComObject.GetOutdatedAllComponentIds(ref ids);
        }

        public int GetOutdatedCableTypeIds(ref object ids)
        {
            return ComObject.GetOutdatedCableTypeIds(ref ids);
        }

        public int GetOutdatedComponentIds(ref object ids)
        {
            return ComObject.GetOutdatedComponentIds(ref ids);
        }

        public int GetOutdatedSymbolTypeIds(ref object ids)
        {
            return ComObject.GetOutdatedSymbolTypeIds(ref ids);
        }

        public double GetOuterDiameter(ref object ids)
        {
            return ComObject.GetOuterDiameter(ref ids);
        }

        public double GetPanelAltGridSize()
        {
            return ComObject.GetPanelAltGridSize();
        }

        public double GetPanelGridSize()
        {
            return ComObject.GetPanelGridSize();
        }

        public double GetPanelTrapSize()
        {
            return ComObject.GetPanelTrapSize();
        }

        public int GetParentSheetIds(int flags, ref object ids)
        {
            return ComObject.GetParentSheetIds(flags, ref ids);
        }

        public int GetPartExtension(string part, string vers, ref object xl, ref object yl, ref object xh, ref object yh,
            ref object shtcnt, ref object xp, ref object yp, ref object subcircuitType)
        {
            return ComObject.GetPartExtension(part, vers, ref xl, ref yl, ref xh, ref yh, ref shtcnt, ref xp, ref yp, ref subcircuitType);
        }

        public string GetPath()
        {
            return ComObject.GetPath();
        }

        public string GetPinViewSymbolForBlockConnectorPins()
        {
            return ComObject.GetPinViewSymbolForBlockConnectorPins();
        }

        public string GetPinViewSymbolForConnectorPins()
        {
            return ComObject.GetPinViewSymbolForConnectorPins();
        }

        public string GetPinViewSymbolForDevicePins()
        {
            return ComObject.GetPinViewSymbolForDevicePins();
        }

        public double GetPointGridSize()
        {
            return ComObject.GetPointGridSize();
        }

        public string GetPortNameSeparator()
        {
            return ComObject.GetPortNameSeparator();
        }

        public object GetProjectProperty(string what)
        {
            return ComObject.GetProjectProperty(what);
        }

        public int GetPurgeUnplacedPinViewsBeforeSave()
        {
            return ComObject.GetPurgeUnplacedPinViewsBeforeSave();
        }

        public int GetPurgeUnusedBeforeSave()
        {
            return ComObject.GetPurgeUnusedBeforeSave();
        }

        public int GetRedlinedGraphIds(ref object ids)
        {
            return ComObject.GetRedlinedGraphIds(ref ids);
        }

        public int GetRedlinedGraphTextIds(ref object ids)
        {
            return ComObject.GetRedlinedGraphTextIds(ref ids);
        }

        public int GetReloadAttributesOnUpdate()
        {
            return ComObject.GetReloadAttributesOnUpdate();
        }

        public int GetRestoreChangedPinNamesOnUpdate()
        {
            return ComObject.GetRestoreChangedPinNamesOnUpdate();
        }

        public int GetResultText(int index, ref object lst)
        {
            return ComObject.GetResultText(index, ref lst);
        }

        public int GetRGBValue(int index, ref object r, ref object g, ref object b)
        {
            return ComObject.GetRGBValue(index, ref r, ref g, ref b);
        }

        public int GetRootModuleId()
        {
            return ComObject.GetRootModuleId();
        }

        public double GetRulerGridSize()
        {
            return ComObject.GetRulerGridSize();
        }

        public string GetSchematicTypeDescription(int type)
        {
            return ComObject.GetSchematicTypeDescription(type);
        }

        public int GetSelectedAllDeviceCount()
        {
            return ComObject.GetSelectedAllDeviceCount();
        }

        public int GetSelectedAllDeviceIds(ref object ids)
        {
            return ComObject.GetSelectedAllDeviceIds(ref ids);
        }

        public int GetSelectedBlockCount()
        {
            return ComObject.GetSelectedBlockCount();
        }

        public int GetSelectedBlockIds(ref object ids)
        {
            return ComObject.GetSelectedBlockIds(ref ids);
        }

        public int GetSelectedBundleCount()
        {
            return ComObject.GetSelectedBundleCount();
        }

        public int GetSelectedBundleIds(ref object ids)
        {
            return ComObject.GetSelectedBundleIds(ref ids);
        }

        public int GetSelectedCableCount()
        {
            return ComObject.GetSelectedCableCount();
        }

        public int GetSelectedCableIds(ref object ids)
        {
            return ComObject.GetSelectedCableIds(ref ids);
        }

        public int GetSelectedConnectionCount(int flags = 0)
        {
            return ComObject.GetSelectedConnectionCount(flags);
        }

        public int GetSelectedConnectionIds(ref object ids, int flags = 0)
        {
            return ComObject.GetSelectedConnectionIds(ref ids, flags);
        }

        public int GetSelectedConnectorCount()
        {
            return ComObject.GetSelectedConnectorCount();
        }

        public int GetSelectedConnectorIds(ref object ids)
        {
            return ComObject.GetSelectedConnectorIds(ref ids);
        }

        public int GetSelectedDeviceCount()
        {
            return ComObject.GetSelectedDeviceCount();
        }

        public int GetSelectedDeviceIds(ref object ids)
        {
            return ComObject.GetSelectedDeviceIds(ref ids);
        }

        public int GetSelectedDimensionIds(ref object ids)
        {
            return ComObject.GetSelectedDimensionIds(ref ids);
        }

        public int GetSelectedGraphCount()
        {
            return ComObject.GetSelectedGraphCount();
        }

        public int GetSelectedGraphIds(ref object ids)
        {
            return ComObject.GetSelectedGraphIds(ref ids);
        }

        public int GetSelectedNetSegmentCount()
        {
            return ComObject.GetSelectedNetSegmentCount();
        }

        public int GetSelectedNetSegmentIds(ref object ids)
        {
            return ComObject.GetSelectedNetSegmentIds(ref ids);
        }

        public int GetSelectedSheetCount()
        {
            return ComObject.GetSelectedSheetCount();
        }

        public int GetSelectedSheetIds(ref object ids)
        {
            return ComObject.GetSelectedSheetIds(ref ids);
        }

        public int GetSelectedSignalCount()
        {
            return ComObject.GetSelectedSignalCount();
        }

        public int GetSelectedSignalIds(ref object ids)
        {
            return ComObject.GetSelectedSignalIds(ref ids);
        }

        public int GetSelectedSymbolCount()
        {
            return ComObject.GetSelectedSymbolCount();
        }

        public int GetSelectedSymbolIds(ref object ids)
        {
            return ComObject.GetSelectedSymbolIds(ref ids);
        }

        public int GetSelectedTerminalCount()
        {
            return ComObject.GetSelectedTerminalCount();
        }

        public int GetSelectedTerminalIds(ref object ids)
        {
            return ComObject.GetSelectedTerminalIds(ref ids);
        }

        public int GetSelectedTextCount()
        {
            return ComObject.GetSelectedTextCount();
        }

        public int GetSelectedTextIds(ref object ids)
        {
            return ComObject.GetSelectedTextIds(ref ids);
        }

        public object GetSettingValue(string name)
        {
            return ComObject.GetSettingValue(name);
        }

        public int GetSheetCount()
        {
            return ComObject.GetSheetCount();
        }

        public int GetSheetIds(ref object ids)
        {
            return ComObject.GetSheetIds(ref ids);
        }

        public int GetSheetTreeStructure(ref object structarr, ref object info)
        {
            return ComObject.GetSheetTreeStructure(ref structarr, ref info);
        }

        public int GetShortcutPosition(ref object xpos, ref object ypos)
        {
            return ComObject.GetShortcutPosition(ref xpos, ref ypos);
        }

        public int GetSignalClassIds(ref object ids)
        {
            return ComObject.GetSignalClassIds(ref ids);
        }

        public int GetSignalCount()
        {
            return ComObject.GetSignalCount();
        }

        public int GetSignalIds(ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public int GetSignalStructureNodeId()
        {
            return ComObject.GetSignalStructureNodeId();
        }

        public int GetStructureNodeIds(ref object ids)
        {
            return ComObject.GetStructureNodeIds(ref ids);
        }

        public int GetSupplyIds(ref object ids)
        {
            return ComObject.GetSupplyIds(ref ids);
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public string GetSymbolForBlockConnectorsWithoutCompcode()
        {
            return ComObject.GetSymbolForBlockConnectorsWithoutCompcode();
        }

        public string GetSymbolForConnectorsWithoutCompcode()
        {
            return ComObject.GetSymbolForConnectorsWithoutCompcode();
        }

        public int GetSymbolIds(ref object ids, string symnam = null, int level = -1, int view = -1)
        {
            return ComObject.GetSymbolIds(ref ids, symnam, level, view);
        }

        public int GetSymbolTypeIds(ref object ids)
        {
            return ComObject.GetSymbolTypeIds(ref ids);
        }

        public string GetTableSymbol()
        {
            return ComObject.GetTableSymbol();
        }

        public int GetTerminalCount()
        {
            return ComObject.GetTerminalCount();
        }

        public int GetTerminalIds(ref object ids)
        {
            return ComObject.GetTerminalIds(ref ids);
        }

        public int GetTerminalPlanSettings(ref object settings)
        {
            return ComObject.GetTerminalPlanSettings(ref settings);
        }

        public int GetTerminalPlanSheetIds(ref object ids)
        {
            return ComObject.GetTerminalPlanSheetIds(ref ids);
        }

        public int GetTestpointIds(ref object ids)
        {
            return ComObject.GetTestpointIds(ref ids);
        }

        public int GetTextCount()
        {
            return ComObject.GetTextCount();
        }

        public int GetTextIds(ref object ids, int txttyp = 0, string search_string = "")
        {
            return ComObject.GetTextIds(ref ids, txttyp, search_string);
        }

        public double GetTrapSize()
        {
            return ComObject.GetTrapSize();
        }

        public int GetTreeIds(ref object ids)
        {
            return ComObject.GetTreeIds(ref ids);
        }

        public int GetTreeSelectedAllDeviceIds(ref object ids)
        {
            return ComObject.GetTreeSelectedAllDeviceIds(ref ids);
        }

        public int GetTreeSelectedAllDeviceIdsByFolder(ref object ids)
        {
            return ComObject.GetTreeSelectedAllDeviceIdsByFolder(ref ids);
        }

        public int GetTreeSelectedBlockIds(ref object ids)
        {
            return ComObject.GetTreeSelectedBlockIds(ref ids);
        }

        public int GetTreeSelectedBundleIds(ref object ids)
        {
            return ComObject.GetTreeSelectedBundleIds(ref ids);
        }

        public int GetTreeSelectedCableIds(ref object ids)
        {
            return ComObject.GetTreeSelectedCableIds(ref ids);
        }

        public int GetTreeSelectedConnectorIds(ref object ids)
        {
            return ComObject.GetTreeSelectedConnectorIds(ref ids);
        }

        public int GetTreeSelectedDeviceIds(ref object ids)
        {
            return ComObject.GetTreeSelectedDeviceIds(ref ids);
        }

        public int GetTreeSelectedExternalDocumentIds(ref object ids)
        {
            return ComObject.GetTreeSelectedExternalDocumentIds(ref ids);
        }

        public int GetTreeSelectedExternalDocumentIdsByFolder(ref object ids)
        {
            return ComObject.GetTreeSelectedExternalDocumentIdsByFolder(ref ids);
        }

        public int GetTreeSelectedPinIds(ref object ids)
        {
            return ComObject.GetTreeSelectedPinIds(ref ids);
        }

        public int GetTreeSelectedSheetIds(ref object ids)
        {
            return ComObject.GetTreeSelectedSheetIds(ref ids);
        }

        public int GetTreeSelectedSheetIdsByFolder(ref object ids)
        {
            return ComObject.GetTreeSelectedSheetIdsByFolder(ref ids);
        }

        public int GetTreeSelectedStructureNodeIds(ref object ids)
        {
            return ComObject.GetTreeSelectedStructureNodeIds(ref ids);
        }

        public int GetTreeSelectedSymbolIds(ref object ids)
        {
            return ComObject.GetTreeSelectedSymbolIds(ref ids);
        }

        public int GetTreeSelectedTerminalIds(ref object ids)
        {
            return ComObject.GetTreeSelectedTerminalIds(ref ids);
        }

        public int GetTubeIds(ref object ids)
        {
            return ComObject.GetTubeIds(ref ids);
        }

        public string GetTypeName()
        {
            return ComObject.GetTypeName();
        }

        public int GetUnconnectCoresOnDelCline()
        {
            return ComObject.GetUnconnectCoresOnDelCline();
        }

        public int GetUnplacedGroupIds(ref object ids)
        {
            return ComObject.GetUnplacedGroupIds(ref ids);
        }

        public int GetUseBlockDesignation()
        {
            return ComObject.GetUseBlockDesignation();
        }

        public int GetUsePinAttributesOnAssign()
        {
            return ComObject.GetUsePinAttributesOnAssign();
        }

        public int GetUsePinAttributesOnImport()
        {
            return ComObject.GetUsePinAttributesOnImport();
        }

        public int GetVariantCount()
        {
            return ComObject.GetVariantCount();
        }

        public int GetVariantIds(ref object ids)
        {
            return ComObject.GetVariantIds(ref ids);
        }

        public string GetViewSymbolForTerminalStrips()
        {
            return ComObject.GetViewSymbolForTerminalStrips();
        }

        public int GetWireRange(ref object from, ref object to)
        {
            return ComObject.GetWireRange(ref from, ref to);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int HighlightAttribute(string attnam, string attvalue, int colour, double width)
        {
            return ComObject.HighlightAttribute(attnam, attvalue, colour, width);
        }

        public int ImportBoardLayout(string type, string file = null, int flags = 0, string map = null)
        {
            return ComObject.ImportBoardLayout(type, file, flags, map);
        }

        public int ImportBoardLayout(string type, string file, int flags, string map, ref object exclusions)
        {
            return ComObject.ImportBoardLayout(type, file, flags, map, ref exclusions);
        }

        public int ImportDDSC(string file, int options, int level = 0)
        {
            return ComObject.ImportDDSC(file, options, level);
        }

        public int ImportDrawing(string name, int unique, double posx = -950309, double posy = -950309)
        {
            return ComObject.ImportDrawing(name, unique, posx, posy);
        }

        public int ImportDrawingEx(string name, int unique, int flags, double posx = -950309, double posy = -950309)
        {
            return ComObject.ImportDrawingEx(name, unique, flags, posx, posy);
        }

        public int ImportELCAD(ref object parameters)
        {
            return ComObject.ImportELCAD(ref parameters);
        }

        public int ImportForeignProject(ref object parameters)
        {
            return ComObject.ImportForeignProject(ref parameters);
        }

        public int ImportMultiuser(string file, string name)
        {
            return ComObject.ImportMultiuser(file, name);
        }

        public int ImportPanlib(ref object parameters)
        {
            return ComObject.ImportPanlib(ref parameters);
        }

        public int ImportRuplan(ref object parameters)
        {
            return ComObject.ImportRuplan(ref parameters);
        }

        public int ImportWESPE(ref object parameters)
        {
            return ComObject.ImportWESPE(ref parameters);
        }

        public int IsChanged()
        {
            return ComObject.IsChanged();
        }

        public int IsFileReadonly()
        {
            return ComObject.IsFileReadonly();
        }

        public int IsMultiuserProject()
        {
            return ComObject.IsMultiuserProject();
        }

        public int IsOfflineId(int id)
        {
            return ComObject.IsOfflineId(id);
        }

        public int JumpToID(int jumpid)
        {
            return ComObject.JumpToID(jumpid);
        }

        public int LoadLevelConfiguration(string file)
        {
            return ComObject.LoadLevelConfiguration(file);
        }

        public int LoadOptionStructure(string filename)
        {
            return ComObject.LoadOptionStructure(filename);
        }

        public int LoadOptionStructureEx(string filename, int flags)
        {
            return ComObject.LoadOptionStructureEx(filename, flags);
        }

        public int LoadPart(string name, string version, int unique)
        {
            return ComObject.LoadPart(name, version, unique);
        }

        public int LoadSignalStructure(string filename)
        {
            return ComObject.LoadSignalStructure(filename);
        }

        public int LoadStructureTemplate(string structure_file)
        {
            return ComObject.LoadStructureTemplate(structure_file);
        }

        public int LockVariantStructure(string password)
        {
            return ComObject.LockVariantStructure(password);
        }

        public int New(string name)
        {
            return ComObject.New(name);
        }

        public int NewMultiuser(string name, string description, string filename, int checkin, int unlock = 0)
        {
            return ComObject.NewMultiuser(name, description, filename, checkin, unlock);
        }

        public int Open(string name)
        {
            return ComObject.Open(name);
        }

        public int OpenMultiuser(string name)
        {
            return ComObject.OpenMultiuser(name);
        }

        public int PlacePartInteractively(string name, string version, out object x, out object y, out object rot)
        {
            return ComObject.PlacePartInteractively(name, version, out x, out y, out rot);
        }

        public int PlacePartInteractivelyEx(string name, string version, int flags, out object x, out object y, out object rot)
        {
            return ComObject.PlacePartInteractivelyEx(name, version, flags, out x, out y, out rot);
        }

        public int PrintOut(double scale, ref object shtids)
        {
            return ComObject.PrintOut(scale, ref shtids);
        }

        public int PurgeUnplacedPinViews()
        {
            return ComObject.PurgeUnplacedPinViews();
        }

        public int PurgeUnused()
        {
            return ComObject.PurgeUnused();
        }

        public int QuitFrameTransaction()
        {
            return ComObject.QuitFrameTransaction();
        }

        public int RecalcWireLength(string bundlesequence_attribute, string length_attribute)
        {
            return ComObject.RecalcWireLength(bundlesequence_attribute, length_attribute);
        }

        public int ReloadSettings(string filename)
        {
            return ComObject.ReloadSettings(filename);
        }

        public int RemoveUndoInformation()
        {
            return ComObject.RemoveUndoInformation();
        }

        public int RenameMultiuser(string oldname, string newname, string newdesc = null)
        {
            return ComObject.RenameMultiuser(oldname, newname, newdesc);
        }

        public int RepairCheckExtended(int mode)
        {
            return ComObject.RepairCheckExtended(mode);
        }

        public int ResetAttributeHighWaterMark(string attname)
        {
            return ComObject.ResetAttributeHighWaterMark(attname);
        }

        public int ResetHighlight()
        {
            return ComObject.ResetHighlight();
        }

        public int ResetHighlightAttribute(string attnam, string attvalue)
        {
            return ComObject.ResetHighlightAttribute(attnam, attvalue);
        }

        public int RestoreOptionVisibility(string filename)
        {
            return ComObject.RestoreOptionVisibility(filename);
        }

        public int RestoreVariantVisibility(string filename)
        {
            return ComObject.RestoreVariantVisibility(filename);
        }

        public int RunUnitTests(ref object tests, out object fixtures, out object testcases, out object succeeded, out object failed,
            out object inconclusive)
        {
            return ComObject.RunUnitTests(ref tests, out fixtures, out testcases, out succeeded, out failed, out inconclusive);
        }

        public int Save()
        {
            return ComObject.Save();
        }

        public int SaveAs(string name, int compressed = -1)
        {
            return ComObject.SaveAs(name, compressed);
        }

        public int SaveLevelConfiguration(string file)
        {
            return ComObject.SaveLevelConfiguration(file);
        }

        public int SaveMultiuser(uint mode)
        {
            return ComObject.SaveMultiuser(mode);
        }

        public int SaveOptionStructure(string filename)
        {
            return ComObject.SaveOptionStructure(filename);
        }

        public int SaveSheetsAsSingleUser(string name, ref object shtids, int compressed = -1, string completeName = "",
            int completeCompressed = -1)
        {
            return ComObject.SaveSheetsAsSingleUser(name, ref shtids, compressed, completeName, completeCompressed);
        }

        public int SetActiveOptionIds(ref object ids)
        {
            return ComObject.SetActiveOptionIds(ref ids);
        }

        public int SetActiveSheetTreeID(int treeid)
        {
            return ComObject.SetActiveSheetTreeID(treeid);
        }

        public int SetActiveVariantId(int vari)
        {
            return ComObject.SetActiveVariantId(vari);
        }

        public int SetAddDeviceDesignationOfConnectionTarget(int bMerge)
        {
            return ComObject.SetAddDeviceDesignationOfConnectionTarget(bMerge);
        }

        public double SetAltGridSize(double newsize)
        {
            return ComObject.SetAltGridSize(newsize);
        }

        public string SetAssignmentSeparator(string newsep)
        {
            return ComObject.SetAssignmentSeparator(newsep);
        }

        public void SetAssignmentSuffixSeparator(string newsep)
        {
            ComObject.SetAssignmentSuffixSeparator(newsep);
        }

        public int SetAttributeNotInheritable(string attnam, int newval)
        {
            return ComObject.SetAttributeNotInheritable(attnam, newval);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetBlockCopyGraphicInSplit(int copy)
        {
            return ComObject.SetBlockCopyGraphicInSplit(copy);
        }

        public int SetBlockReferenceTextDirection(int newdir)
        {
            return ComObject.SetBlockReferenceTextDirection(newdir);
        }

        public double SetBlockReferenceTextGap(double newgap)
        {
            return ComObject.SetBlockReferenceTextGap(newgap);
        }

        public int SetBlockReferenceTextLevel(int newlev)
        {
            return ComObject.SetBlockReferenceTextLevel(newlev);
        }

        public int SetBlockReferenceTextRotate(int rotate)
        {
            return ComObject.SetBlockReferenceTextRotate(rotate);
        }

        public int SetBlockReferenceType(int newtype)
        {
            return ComObject.SetBlockReferenceType(newtype);
        }

        public int SetBlockTextAlignment(int newalign)
        {
            return ComObject.SetBlockTextAlignment(newalign);
        }

        public int SetBlockTextColour(int newcol)
        {
            return ComObject.SetBlockTextColour(newcol);
        }

        public string SetBlockTextFont(string newfont)
        {
            return ComObject.SetBlockTextFont(newfont);
        }

        public int SetBlockTextRatio(int newratio)
        {
            return ComObject.SetBlockTextRatio(newratio);
        }

        public double SetBlockTextSize(double newsize)
        {
            return ComObject.SetBlockTextSize(newsize);
        }

        public int SetBlockTextStyle(int newstyle)
        {
            return ComObject.SetBlockTextStyle(newstyle);
        }

        public int SetBusLineColour(int newcol)
        {
            return ComObject.SetBusLineColour(newcol);
        }

        public int SetBusLineLevel(int newlev)
        {
            return ComObject.SetBusLineLevel(newlev);
        }

        public int SetBusLineStyle(int newstl)
        {
            return ComObject.SetBusLineStyle(newstl);
        }

        public int SetBusLineWidth(double newwid)
        {
            return ComObject.SetBusLineWidth(newwid);
        }

        public int SetCadstarCrossProbing(int probe)
        {
            return ComObject.SetCadstarCrossProbing(probe);
        }

        public int SetChanged(int newval)
        {
            return ComObject.SetChanged(newval);
        }

        public double SetConnectionInclinationAngle(double angle)
        {
            return ComObject.SetConnectionInclinationAngle(angle);
        }

        public double SetConnectionInclinationDistance(double destination)
        {
            return ComObject.SetConnectionInclinationDistance(destination);
        }

        public int SetConnectionMode(int mode)
        {
            return ComObject.SetConnectionMode(mode);
        }

        public int SetConnectionTargetFormat(int txttyp, int flags, string entire_prefix, string entire_suffix, int count,
            ref object prefix, ref object name, ref object funct)
        {
            return ComObject.SetConnectionTargetFormat(txttyp, flags, entire_prefix, entire_suffix, count, ref prefix, ref name, ref funct);
        }

        public int SetConnectorPinTerminalParameterOverwriteModelPin(int bValue)
        {
            return ComObject.SetConnectorPinTerminalParameterOverwriteModelPin(bValue);
        }

        public int SetConnectorSymbolFormat(ref object texttypes, ref object dispflags)
        {
            return ComObject.SetConnectorSymbolFormat(ref texttypes, ref dispflags);
        }

        public int SetCreateUniqueSheetNames(int uniquenames)
        {
            return ComObject.SetCreateUniqueSheetNames(uniquenames);
        }

        public int SetDefaultHoseTube(string HoseTube)
        {
            return ComObject.SetDefaultHoseTube(HoseTube);
        }

        public int SetDefaultJumper(string jumpergroup, string jumpername)
        {
            return ComObject.SetDefaultJumper(jumpergroup, jumpername);
        }

        public int SetDefaultWire(string wiregroup, string wirename)
        {
            return ComObject.SetDefaultWire(wiregroup, wirename);
        }

        public int SetDeleteCoresOnDelCline(int newval)
        {
            return ComObject.SetDeleteCoresOnDelCline(newval);
        }

        public int SetDeletePinAttributesOnUnplace(int newval)
        {
            return ComObject.SetDeletePinAttributesOnUnplace(newval);
        }

        public int SetDeleteSignalOnDelCline(int newval)
        {
            return ComObject.SetDeleteSignalOnDelCline(newval);
        }

        public int SetDetermineConnectorSymbol(int determine)
        {
            return ComObject.SetDetermineConnectorSymbol(determine);
        }

        public int SetDetermineConnectorViewSymbol(int determine)
        {
            return ComObject.SetDetermineConnectorViewSymbol(determine);
        }

        public string SetDeviceNameSeparator(string newsep)
        {
            return ComObject.SetDeviceNameSeparator(newsep);
        }

        public void SetDeviceNameSuffixSeparator(string newsep)
        {
            ComObject.SetDeviceNameSuffixSeparator(newsep);
        }

        public string SetDisplayAltCompCode(string newval)
        {
            return ComObject.SetDisplayAltCompCode(newval);
        }

        public int SetDisplayAppendFormboardNameToDeviceName(int newval)
        {
            return ComObject.SetDisplayAppendFormboardNameToDeviceName(newval);
        }

        public int SetDisplayConnectionMode(int value)
        {
            return ComObject.SetDisplayConnectionMode(value);
        }

        public int SetDisplayConnectionType(int newval)
        {
            return ComObject.SetDisplayConnectionType(newval);
        }

        public int SetDisplayConnectPoints(int newval)
        {
            return ComObject.SetDisplayConnectPoints(newval);
        }

        public int SetDisplayDuctDockingPoints(int newval)
        {
            return ComObject.SetDisplayDuctDockingPoints(newval);
        }

        public int SetDisplayDuctFillSize(int newval)
        {
            return ComObject.SetDisplayDuctFillSize(newval);
        }

        public int SetDisplayFormboardEffectiveDirection(int newval)
        {
            return ComObject.SetDisplayFormboardEffectiveDirection(newval);
        }

        public int SetDisplayFormboardMarkDifferenLength(int newval)
        {
            return ComObject.SetDisplayFormboardMarkDifferenLength(newval);
        }

        public int SetDisplayFormboardNodes(int newval)
        {
            return ComObject.SetDisplayFormboardNodes(newval);
        }

        public int SetDisplayFormboardTableSubsidiaryLines(int newval)
        {
            return ComObject.SetDisplayFormboardTableSubsidiaryLines(newval);
        }

        public int SetDisplayFormboardUnconnectedCores(int newval)
        {
            return ComObject.SetDisplayFormboardUnconnectedCores(newval);
        }

        public int SetDisplayIntExtRepresentation(int newval)
        {
            return ComObject.SetDisplayIntExtRepresentation(newval);
        }

        public int SetDisplayMILStandard(int newval)
        {
            return ComObject.SetDisplayMILStandard(newval);
        }

        public int SetDisplayOptionsAll(int newval)
        {
            return ComObject.SetDisplayOptionsAll(newval);
        }

        public int SetDisplayOptionsColoured(int newval)
        {
            return ComObject.SetDisplayOptionsColoured(newval);
        }

        public int SetDisplayOptionsNone(int newval)
        {
            return ComObject.SetDisplayOptionsNone(newval);
        }

        public int SetDisplayRotatedTextAccStandard(int newval)
        {
            return ComObject.SetDisplayRotatedTextAccStandard(newval);
        }

        public int SetDisplayUnconnectedNodes(int newval)
        {
            return ComObject.SetDisplayUnconnectedNodes(newval);
        }

        public int SetDisplayViewNumbers(int newval)
        {
            return ComObject.SetDisplayViewNumbers(newval);
        }

        public int SetDynamicSymbolOriginInUpperLeft(int bTopLeft)
        {
            return ComObject.SetDynamicSymbolOriginInUpperLeft(bTopLeft);
        }

        public int SetExclusiveMode(int mode)
        {
            return ComObject.SetExclusiveMode(mode);
        }

        public int SetExportWithCablesAndWires(int cablesandwires)
        {
            return ComObject.SetExportWithCablesAndWires(cablesandwires);
        }

        public int SetExportWithCablesAndWiresOption(int option)
        {
            return ComObject.SetExportWithCablesAndWiresOption(option);
        }

        public int SetFieldHatchColour(int newcol)
        {
            return ComObject.SetFieldHatchColour(newcol);
        }

        public double SetFieldHatchLineDistance(double newdist)
        {
            return ComObject.SetFieldHatchLineDistance(newdist);
        }

        public double SetFieldHatchLineWidth(double newwid)
        {
            return ComObject.SetFieldHatchLineWidth(newwid);
        }

        public int SetFieldHatchPattern(int newpat)
        {
            return ComObject.SetFieldHatchPattern(newpat);
        }

        public int SetFieldOriginInUpperLeft(int bTopLeft)
        {
            return ComObject.SetFieldOriginInUpperLeft(bTopLeft);
        }

        public int SetFieldOutlineColour(int newcol)
        {
            return ComObject.SetFieldOutlineColour(newcol);
        }

        public int SetFieldOutlineStyle(int newstyle)
        {
            return ComObject.SetFieldOutlineStyle(newstyle);
        }

        public double SetFieldOutlineWidth(double width)
        {
            return ComObject.SetFieldOutlineWidth(width);
        }

        public string SetFieldTextTemplate(string newname)
        {
            return ComObject.SetFieldTextTemplate(newname);
        }

        public int SetFormboardAutoplaceTableSymbol(int newval)
        {
            return ComObject.SetFormboardAutoplaceTableSymbol(newval);
        }

        public int SetFormboardAutorotateConnectorSymbols(int newval)
        {
            return ComObject.SetFormboardAutorotateConnectorSymbols(newval);
        }

        public int SetFormboardBranchAngleStep(int newval)
        {
            return ComObject.SetFormboardBranchAngleStep(newval);
        }

        public double SetGapToPlaceSinglePins(double new_gap)
        {
            return ComObject.SetGapToPlaceSinglePins(new_gap);
        }

        public int SetGeneratedWireNameFormat(string prefix, string separator, string postfix, ref object attPrefix,
            ref object attType, ref object attname)
        {
            return ComObject.SetGeneratedWireNameFormat(prefix, separator, postfix, ref attPrefix, ref attType, ref attname);
        }

        public int SetGetterOptionHandlingMode(int mode)
        {
            return ComObject.SetGetterOptionHandlingMode(mode);
        }

        public int SetGraphArrows(int value)
        {
            return ComObject.SetGraphArrows(value);
        }

        public int SetGraphColour(int value)
        {
            return ComObject.SetGraphColour(value);
        }

        public int SetGraphHatchColour(int value)
        {
            return ComObject.SetGraphHatchColour(value);
        }

        public double SetGraphHatchDistance(double value)
        {
            return ComObject.SetGraphHatchDistance(value);
        }

        public int SetGraphHatchPattern(int value, double angle1, double angle2)
        {
            return ComObject.SetGraphHatchPattern(value, angle1, angle2);
        }

        public int SetGraphHatchStyle(int value)
        {
            return ComObject.SetGraphHatchStyle(value);
        }

        public double SetGraphHatchWidth(double value)
        {
            return ComObject.SetGraphHatchWidth(value);
        }

        public int SetGraphLevel(int value)
        {
            return ComObject.SetGraphLevel(value);
        }

        public int SetGraphStyle(int value)
        {
            return ComObject.SetGraphStyle(value);
        }

        public int SetGraphTextColour(int value)
        {
            return ComObject.SetGraphTextColour(value);
        }

        public string SetGraphTextFontName(string newname)
        {
            return ComObject.SetGraphTextFontName(newname);
        }

        public double SetGraphTextHeight(double value)
        {
            return ComObject.SetGraphTextHeight(value);
        }

        public int SetGraphTextLevel(int value)
        {
            return ComObject.SetGraphTextLevel(value);
        }

        public int SetGraphTextMode(int value)
        {
            return ComObject.SetGraphTextMode(value);
        }

        public double SetGraphTextSize(double value)
        {
            return ComObject.SetGraphTextSize(value);
        }

        public int SetGraphTextStyle(int value)
        {
            return ComObject.SetGraphTextStyle(value);
        }

        public double SetGraphWidth(double value)
        {
            return ComObject.SetGraphWidth(value);
        }

        public double SetGridSize(double newsize)
        {
            return ComObject.SetGridSize(newsize);
        }

        public int SetHighlightColour(int colour)
        {
            return ComObject.SetHighlightColour(colour);
        }

        public int SetHighlightKeep(int keep)
        {
            return ComObject.SetHighlightKeep(keep);
        }

        public double SetHighlightLineWidth(double width)
        {
            return ComObject.SetHighlightLineWidth(width);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetIEC61346Setting(int newval)
        {
            return ComObject.SetIEC61346Setting(newval);
        }

        public string SetImportItemDesignationSuffix(string newsuffix)
        {
            return ComObject.SetImportItemDesignationSuffix(newsuffix);
        }

        public int SetImportMergeAttributes(int merge)
        {
            return ComObject.SetImportMergeAttributes(merge);
        }

        public int SetImportMergeConnectLines(int merge)
        {
            return ComObject.SetImportMergeConnectLines(merge);
        }

        public int SetImportMergeExistingAssemblies(int merge)
        {
            return ComObject.SetImportMergeExistingAssemblies(merge);
        }

        public int SetImportMergeExistingDevices(int merge)
        {
            return ComObject.SetImportMergeExistingDevices(merge);
        }

        public int SetImportMergeExistingTerminalStrips(int merge)
        {
            return ComObject.SetImportMergeExistingTerminalStrips(merge);
        }

        public int SetImportMergeOptions(int newval)
        {
            return ComObject.SetImportMergeOptions(newval);
        }

        public int SetImportUseItemDesignationSuffix(int use)
        {
            return ComObject.SetImportUseItemDesignationSuffix(use);
        }

        public int SetKeepActiveConnectorPinTerminalOnUpdate(int keep)
        {
            return ComObject.SetKeepActiveConnectorPinTerminalOnUpdate(keep);
        }

        public int SetKeepActiveCounterpartOnUpdate(int keep)
        {
            return ComObject.SetKeepActiveCounterpartOnUpdate(keep);
        }

        public int SetKeepActiveFittingOnUpdate(int keep)
        {
            return ComObject.SetKeepActiveFittingOnUpdate(keep);
        }

        public int SetKeepConnectorSymbolsOnUpdate(int keep)
        {
            return ComObject.SetKeepConnectorSymbolsOnUpdate(keep);
        }

        public int SetKeepModelTextParametersOnUpdate(int keep)
        {
            return ComObject.SetKeepModelTextParametersOnUpdate(keep);
        }

        public int SetKeepModelTextVisibilityOnUpdate(int keep)
        {
            return ComObject.SetKeepModelTextVisibilityOnUpdate(keep);
        }

        public int SetKeepSymbolTextParametersOnUpdate(int keep)
        {
            return ComObject.SetKeepSymbolTextParametersOnUpdate(keep);
        }

        public int SetKeepSymbolTextVisibilityOnUpdate(int keep)
        {
            return ComObject.SetKeepSymbolTextVisibilityOnUpdate(keep);
        }

        public int SetLanguages(ref object languages)
        {
            return ComObject.SetLanguages(ref languages);
        }

        public int SetLevel(int lev, int onoff)
        {
            return ComObject.SetLevel(lev, onoff);
        }

        public int SetLevels(ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr)
        {
            return ComObject.SetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr);
        }

        public int SetLevels(ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr,
            ref object txtarr, ref object cxarr, ref object names)
        {
            return ComObject.SetLevels(ref symarr, ref sgraarr, ref stxtarr, ref semtarr, ref graarr, ref txtarr, ref cxarr, ref names);
        }

        public int SetLineColour(int newcol)
        {
            return ComObject.SetLineColour(newcol);
        }

        public int SetLineLevel(int newlev)
        {
            return ComObject.SetLineLevel(newlev);
        }

        public int SetLineStyle(int newstl)
        {
            return ComObject.SetLineStyle(newstl);
        }

        public int SetLineWidth(double newwid)
        {
            return ComObject.SetLineWidth(newwid);
        }

        public string SetLocationSeparator(string newsep)
        {
            return ComObject.SetLocationSeparator(newsep);
        }

        public void SetLocationSuffixSeparator(string newsep)
        {
            ComObject.SetLocationSuffixSeparator(newsep);
        }

        public int SetMeasure(string measure)
        {
            return ComObject.SetMeasure(measure);
        }

        public int SetMergeAlphanumericReferences(int bMerge)
        {
            return ComObject.SetMergeAlphanumericReferences(bMerge);
        }

        public int SetMergeSheetReferences(int bMerge)
        {
            return ComObject.SetMergeSheetReferences(bMerge);
        }

        public int SetMergeUsingExactCoreConnectionOnImport(int newval)
        {
            return ComObject.SetMergeUsingExactCoreConnectionOnImport(newval);
        }

        public int SetMILGraphicLineColour(int newcol)
        {
            return ComObject.SetMILGraphicLineColour(newcol);
        }

        public int SetMILGraphicLineStyle(int newstyle)
        {
            return ComObject.SetMILGraphicLineStyle(newstyle);
        }

        public double SetMILGraphicLineWidth(double width)
        {
            return ComObject.SetMILGraphicLineWidth(width);
        }

        public int SetNetSegmentAttributeSplittingRule(int newval)
        {
            return ComObject.SetNetSegmentAttributeSplittingRule(newval);
        }

        public int SetNetSegmentLengthSplittingRule(int newval)
        {
            return ComObject.SetNetSegmentLengthSplittingRule(newval);
        }

        public double SetPanelAltGridSize(double newsize)
        {
            return ComObject.SetPanelAltGridSize(newsize);
        }

        public double SetPanelGridSize(double newsize)
        {
            return ComObject.SetPanelGridSize(newsize);
        }

        public double SetPanelTrapSize(double newsize)
        {
            return ComObject.SetPanelTrapSize(newsize);
        }

        public int SetPinViewSymbolForBlockConnectorPins(string new_sym)
        {
            return ComObject.SetPinViewSymbolForBlockConnectorPins(new_sym);
        }

        public int SetPinViewSymbolForConnectorPins(string new_sym)
        {
            return ComObject.SetPinViewSymbolForConnectorPins(new_sym);
        }

        public int SetPinViewSymbolForDevicePins(string new_sym)
        {
            return ComObject.SetPinViewSymbolForDevicePins(new_sym);
        }

        public double SetPointGridSize(double newsize)
        {
            return ComObject.SetPointGridSize(newsize);
        }

        public string SetPortNameSeparator(string newsep)
        {
            return ComObject.SetPortNameSeparator(newsep);
        }

        public int SetPurgeUnplacedPinViewsBeforeSave(int purge)
        {
            return ComObject.SetPurgeUnplacedPinViewsBeforeSave(purge);
        }

        public int SetPurgeUnusedBeforeSave(int purge)
        {
            return ComObject.SetPurgeUnusedBeforeSave(purge);
        }

        public int SetReloadAttributesOnUpdate(int reload)
        {
            return ComObject.SetReloadAttributesOnUpdate(reload);
        }

        public int SetRestoreChangedPinNamesOnUpdate(int restore)
        {
            return ComObject.SetRestoreChangedPinNamesOnUpdate(restore);
        }

        public int SetRGBValue(ref object index, ref object r, ref object g, ref object b)
        {
            return ComObject.SetRGBValue(ref index, ref r, ref g, ref b);
        }

        public double SetRulerGridSize(double newsize)
        {
            return ComObject.SetRulerGridSize(newsize);
        }

        public object SetSettingValue(string name, ref object value)
        {
            return ComObject.SetSettingValue(name, ref value);
        }

        public int SetSheetTreeStructure(ref object structarr, ref object info)
        {
            return ComObject.SetSheetTreeStructure(ref structarr, ref info);
        }

        public int SetSymbolForBlockConnectorsWithoutCompcode(string new_sym)
        {
            return ComObject.SetSymbolForBlockConnectorsWithoutCompcode(new_sym);
        }

        public int SetSymbolForConnectorsWithoutCompcode(string new_sym)
        {
            return ComObject.SetSymbolForConnectorsWithoutCompcode(new_sym);
        }

        public string SetTableSymbol(string newval)
        {
            return ComObject.SetTableSymbol(newval);
        }

        public int SetTerminalPlanSettings(ref object settings)
        {
            return ComObject.SetTerminalPlanSettings(ref settings);
        }

        public double SetTrapSize(double newsize)
        {
            return ComObject.SetTrapSize(newsize);
        }

        public int SetUnconnectCoresOnDelCline(int newval)
        {
            return ComObject.SetUnconnectCoresOnDelCline(newval);
        }

        public int SetUnlockPassword(string oldval, string newval)
        {
            return ComObject.SetUnlockPassword(oldval, newval);
        }

        public int SetUnlockVariantStructurePassword(string oldval, string newval)
        {
            return ComObject.SetUnlockVariantStructurePassword(oldval, newval);
        }

        public int SetUseBlockDesignation(int newval)
        {
            return ComObject.SetUseBlockDesignation(newval);
        }

        public int SetUsePinAttributesOnAssign(int newval)
        {
            return ComObject.SetUsePinAttributesOnAssign(newval);
        }

        public int SetUsePinAttributesOnImport(int newval)
        {
            return ComObject.SetUsePinAttributesOnImport(newval);
        }

        public int SetViewSymbolForTerminalStrips(string new_sym)
        {
            return ComObject.SetViewSymbolForTerminalStrips(new_sym);
        }

        public int SetWireRange(int @from, int to)
        {
            return ComObject.SetWireRange(@from, to);
        }

        public int ShowPartPreview(string name)
        {
            return ComObject.ShowPartPreview(name);
        }

        public int StartFrameTransaction()
        {
            return ComObject.StartFrameTransaction();
        }

        public int StoreOptionVisibility(string filename)
        {
            return ComObject.StoreOptionVisibility(filename);
        }

        public int StoreVariantVisibility(string filename)
        {
            return ComObject.StoreVariantVisibility(filename);
        }

        public int UnlockVariantStructure(string password)
        {
            return ComObject.UnlockVariantStructure(password);
        }

        public int UpdateAllComponents(int withSymbol = 1)
        {
            return ComObject.UpdateAllComponents(withSymbol);
        }

        public int UpdateAllParts()
        {
            return ComObject.UpdateAllParts();
        }

        public int UpdateAllSubCircuits()
        {
            return ComObject.UpdateAllSubCircuits();
        }

        public int UpdateAllSymbols()
        {
            return ComObject.UpdateAllSymbols();
        }

        public int UpdateAllTerminalPlans()
        {
            return ComObject.UpdateAllTerminalPlans();
        }

        public int UpdateAutoShtrefs()
        {
            return ComObject.UpdateAutoShtrefs();
        }

        public int UpdateCompleteProject()
        {
            return ComObject.UpdateCompleteProject();
        }

        public int UpdateComponent(string cmpnam, int withSymbol = 1)
        {
            return ComObject.UpdateComponent(cmpnam, withSymbol);
        }

        public int UpdateConfiguration()
        {
            return ComObject.UpdateConfiguration();
        }

        public int UpdateConnectionTargets()
        {
            return ComObject.UpdateConnectionTargets();
        }

        public int UpdateCores()
        {
            return ComObject.UpdateCores();
        }

        public int UpdateLanguageDatabase()
        {
            return ComObject.UpdateLanguageDatabase();
        }

        public int UpdateMultiuser()
        {
            return ComObject.UpdateMultiuser();
        }

        public int UpdatePart(string filename)
        {
            return ComObject.UpdatePart(filename);
        }

        public int UpdateSubCircuit(string cmpnam)
        {
            return ComObject.UpdateSubCircuit(cmpnam);
        }

        public int UpdateSymbol(string symnam)
        {
            return ComObject.UpdateSymbol(symnam);
        }

        public int UpdateTextsInProject()
        {
            return ComObject.UpdateTextsInProject();
        }

        public int Verify(int mode, string logfile = "")
        {
            return ComObject.Verify(mode, logfile);
        }
    }
}