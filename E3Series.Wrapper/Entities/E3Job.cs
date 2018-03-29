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
        public IAttribute CreateAttributeObject()
        {
            return this.CreateObject<IAttribute, E3JobProxy>();
        }

        /// <inheritdoc />
        public IBinData CreateBinDataObject()
        {
            return this.CreateObject<IBinData, E3JobProxy>();
        }

        /// <inheritdoc />
        public IBoard CreateBoardObject()
        {
            return this.CreateObject<IBoard, E3JobProxy>();
        }

        /// <inheritdoc />
        public IBundle CreateBundleObject()
        {
            return this.CreateObject<IBundle, E3JobProxy>();
        }

        /// <inheritdoc />
        public IComponent CreateComponentObject()
        {
            return this.CreateObject<IComponent, E3JobProxy>();
        }

        /// <inheritdoc />
        public IConnection CreateConnectionObject()
        {
            return this.CreateObject<IConnection, E3JobProxy>();
        }

        /// <inheritdoc />
        public IConnectLine CreateConnectLineObject()
        {
            return this.CreateObject<IConnectLine, E3JobProxy>();
        }

        /// <inheritdoc />
        public IDevice CreateDeviceObject()
        {
            return this.CreateObject<IDevice, E3JobProxy>();
        }

        /// <inheritdoc />
        public IDimension CreateDimensionObject()
        {
            return this.CreateObject<IDimension, E3JobProxy>();
        }

        /// <inheritdoc />
        public IExternalDocument CreateExternalDocumentObject()
        {
            return this.CreateObject<IExternalDocument, E3JobProxy>();
        }

        /// <inheritdoc />
        public IField CreateFieldObject()
        {
            return this.CreateObject<IField, E3JobProxy>();
        }

        /// <inheritdoc />
        public IFunctionalPort CreateFunctionalPortObject()
        {
            return this.CreateObject<IFunctionalPort, E3JobProxy>();
        }

        /// <inheritdoc />
        public IFunctionalUnit CreateFunctionalUnitObject()
        {
            return this.CreateObject<IFunctionalUnit, E3JobProxy>();
        }

        /// <inheritdoc />
        public ISheet CreateSheetObject()
        {
            return this.CreateObject<ISheet, E3JobProxy>();
        }
    }
}