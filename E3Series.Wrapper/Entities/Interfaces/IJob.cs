using System.Collections.Generic;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Job COM object
    /// </summary>
    public interface IJob : IProxyProvider<E3JobProxy>,
        IE3NamedReadonly,
        IE3Attributed
    {
        /// <summary>
        /// Create object for working with attributes
        /// </summary>
        /// <returns></returns>
        IAttribute CreateAttributeObject();

        /// <summary>
        /// Create object for working with bin datas
        /// </summary>
        /// <returns></returns>
        IBinData CreateBinDataObject();

        /// <summary>
        /// Create object for working with boards
        /// </summary>
        /// <returns></returns>
        IBoard CreateBoardObject();

        /// <summary>
        /// Create object for working with bundles
        /// </summary>
        /// <returns></returns>
        IBundle CreateBundleObject();

        /// <summary>
        /// Create object for working with components
        /// </summary>
        /// <returns></returns>
        IComponent CreateComponentObject();

        /// <summary>
        /// Create object for working with connections
        /// </summary>
        /// <returns></returns>
        IConnection CreateConnectionObject();

        /// <summary>
        /// Create object for working with connect lines
        /// </summary>
        /// <returns></returns>
        IConnectLine CreateConnectLineObject();

        /// <summary>
        /// Create object for working with devices
        /// </summary>
        /// <returns></returns>
        IDevice CreateDeviceObject();

        /// <summary>
        /// Create object for working with dimensions
        /// </summary>
        /// <returns></returns>
        IDimension CreateDimensionObject();

        /// <summary>
        /// Create object for working with external documents
        /// </summary>
        /// <returns></returns>
        IExternalDocument CreateExternalDocumentObject();

        /// <summary>
        /// Create object for working with fields
        /// </summary>
        /// <returns></returns>
        IField CreateFieldObject();

        /// <summary>
        /// Create object for working with functional ports
        /// </summary>
        /// <returns></returns>
        IFunctionalPort CreateFunctionalPortObject();

        /// <summary>
        /// Create object for working with functional units
        /// </summary>
        /// <returns></returns>
        IFunctionalUnit CreateFunctionalUnitObject();

        /// <summary>
        /// Create object for working with graphs
        /// </summary>
        /// <returns></returns>
        IGraph CreateGraphObject();

        /// <summary>
        /// Create object for working with groups
        /// </summary>
        /// <returns></returns>
        IGroup CreateGroupObject();

        /// <summary>
        /// Create object for working with layers
        /// </summary>
        /// <returns></returns>
        ILayer CreateLayerObject();

        /// <summary>
        /// Create object for working with modules
        /// </summary>
        /// <returns></returns>
        IModule CreateModuleObject();

        /// <summary>
        /// Create object for working with module ports
        /// </summary>
        /// <returns></returns>
        IModulePort CreateModulePortObject();

        /// <summary>
        /// Create object for working with nets
        /// </summary>
        /// <returns></returns>
        INet CreateNetObject();

        /// <summary>
        /// Create object for working with net segments
        /// </summary>
        /// <returns></returns>
        INetSegment CreateNetSegmentObject();

        /// <summary>
        /// Create object for working with options
        /// </summary>
        /// <returns></returns>
        IOption CreateOptionObject();

        /// <summary>
        /// Create object for working with outlines
        /// </summary>
        /// <returns></returns>
        IOutline CreateOutlineObject();

        /// <summary>
        /// Create object for working with pins
        /// </summary>
        /// <returns></returns>
        IPin CreatePinObject();

        /// <summary>
        /// Create object for working with sheets
        /// </summary>
        /// <returns></returns>
        ISheet CreateSheetObject();

        /// <summary>
        /// Create object for working with signals
        /// </summary>
        /// <returns></returns>
        ISignal CreateSignalObject();

        /// <summary>
        /// Create object for working with signal classes
        /// </summary>
        /// <returns></returns>
        ISignalClass CreateSignalClassObject();

        /// <summary>
        /// Create object for working with slots
        /// </summary>
        /// <returns></returns>
        ISlot CreateSlotObject();

        /// <summary>
        /// Create object for working with structure nodes
        /// </summary>
        /// <returns></returns>
        IStructureNode CreateStructureNodeObject();

        /// <summary>
        /// Create object for working with supplies
        /// </summary>
        /// <returns></returns>
        ISupply CreateSupplyObject();

        /// <summary>
        /// Create object for working with symbols
        /// </summary>
        /// <returns></returns>
        ISymbol CreateSymbolObject();

        /// <summary>
        /// Create object for working with testpoints
        /// </summary>
        /// <returns></returns>
        ITestpoint CreateTestpointObject();

        /// <summary>
        /// Create object for working with texts
        /// </summary>
        /// <returns></returns>
        IText CreateTextObject();

        /// <summary>
        /// Create object for working with trees
        /// </summary>
        /// <returns></returns>
        ITree CreateTreeObject();

        /// <summary>
        /// Create object for working with variants
        /// </summary>
        /// <returns></returns>
        IVariant CreateVariantObject();

        /// <summary>
        /// Get global identifier by object identifier
        /// </summary>
        /// <param name="id">Object identifier</param>
        /// <returns></returns>
        string GetGidOfId(int id);

        /// <summary>
        /// Get object identifier by global identifier
        /// </summary>
        /// <param name="gid">Global identifier</param>
        /// <returns></returns>
        int GetIdOfGid(string gid);

        /// <summary>
        /// Returns iterator of all selected net segments
        /// </summary>
        /// <param name="iterator">INetSegment iterator</param>
        /// <returns></returns>
        IEnumerable<INetSegment> GetSelectedNetSegments(INetSegment iterator);

        /// <summary>
        /// Check project is Multiuser
        /// </summary>
        /// <returns></returns>
        bool IsMultiuserProject();
    }
}