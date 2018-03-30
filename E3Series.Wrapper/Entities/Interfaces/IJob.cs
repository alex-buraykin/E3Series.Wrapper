using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Job COM object
    /// </summary>
    public interface IJob : IComObjectProvider<E3JobProxy>
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
    }
}