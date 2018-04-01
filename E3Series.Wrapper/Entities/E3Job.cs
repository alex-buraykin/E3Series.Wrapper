using System;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Extensions;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IJob" />
    /// <summary>
    /// Implementation of IJob interface
    /// </summary>
    public class E3Job : ComWrapperBase<E3JobProxy>, IJob
    {
        public E3Job(E3Application app) 
            : base(app, () => new E3JobProxy(app.ComObject.CreateJobObject()))
        {
        }

        /// <inheritdoc />
        public IAttribute CreateAttributeObject() => CreateObject<IAttribute>();

        /// <inheritdoc />
        public IBinData CreateBinDataObject() => CreateObject<IBinData>();

        /// <inheritdoc />
        public IBoard CreateBoardObject() => CreateObject<IBoard>();

        /// <inheritdoc />
        public IBundle CreateBundleObject() =>  CreateObject<IBundle>();

        /// <inheritdoc />
        public IComponent CreateComponentObject() => CreateObject<IComponent>();

        /// <inheritdoc />
        public IConnection CreateConnectionObject() => CreateObject<IConnection>();

        /// <inheritdoc />
        public IConnectLine CreateConnectLineObject() => CreateObject<IConnectLine>();

        /// <inheritdoc />
        public IDevice CreateDeviceObject() => CreateObject<IDevice>();

        /// <inheritdoc />
        public IDimension CreateDimensionObject() => CreateObject<IDimension>();

        /// <inheritdoc />
        public IExternalDocument CreateExternalDocumentObject() => CreateObject<IExternalDocument>();

        /// <inheritdoc />
        public IField CreateFieldObject() => CreateObject<IField>();

        /// <inheritdoc />
        public IFunctionalPort CreateFunctionalPortObject() => CreateObject<IFunctionalPort>();

        /// <inheritdoc />
        public IFunctionalUnit CreateFunctionalUnitObject() => CreateObject<IFunctionalUnit>();

        /// <inheritdoc />
        public IGraph CreateGraphObject() => CreateObject<IGraph>();

        /// <inheritdoc />
        public IGroup CreateGroupObject() => CreateObject<IGroup>();

        /// <inheritdoc />
        public ILayer CreateLayerObject() => CreateObject<ILayer>();

        /// <inheritdoc />
        public IModule CreateModuleObject() => CreateObject<IModule>();

        /// <inheritdoc />
        public IModulePort CreateModulePortObject() => CreateObject<IModulePort>();

        /// <inheritdoc />
        public INet CreateNetObject() => CreateObject<INet>();

        /// <inheritdoc />
        public INetSegment CreateNetSegmentObject() => CreateObject<INetSegment>();

        /// <inheritdoc />
        public IOption CreateOptionObject() => CreateObject<IOption>();

        /// <inheritdoc />
        public IOutline CreateOutlineObject() => CreateObject<IOutline>();

        /// <inheritdoc />
        public IPin CreatePinObject() => CreateObject<IPin>();

        /// <inheritdoc />
        public ISheet CreateSheetObject() => CreateObject<ISheet>();

        /// <inheritdoc />
        public ISignal CreateSignalObject() => CreateObject<ISignal>();

        /// <inheritdoc />
        public ISignalClass CreateSignalClassObject() => CreateObject<ISignalClass>();

        /// <inheritdoc />
        public ISlot CreateSlotObject() => CreateObject<ISlot>();

        /// <inheritdoc />
        public IStructureNode CreateStructureNodeObject() => CreateObject<IStructureNode>();

        /// <inheritdoc />
        public ISupply CreateSupplyObject() => CreateObject<ISupply>();

        /// <inheritdoc />
        public ISymbol CreateSymbolObject() => CreateObject<ISymbol>();

        /// <inheritdoc />
        public ITestpoint CreateTestpointObject() => CreateObject<ITestpoint>();

        /// <inheritdoc />
        public IText CreateTextObject() => CreateObject<IText>();

        /// <inheritdoc />
        public ITree CreateTreeObject() => CreateObject<ITree>();

        /// <inheritdoc />
        public IVariant CreateVariantObject() => CreateObject<IVariant>();

        /// <inheritdoc />
        public string GetGidOfId(int id) => ComObject.GetGidOfId(id);

        /// <inheritdoc />
        public int GetIdOfGid(string gid) => ComObject.GetIdOfGid(gid);

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => ComObject.GetName();

        #endregion

        private T CreateObject<T>() where T : IDisposable
        {
            return this.CreateObject<T, E3JobProxy>();
        }
    }
}