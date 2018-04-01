using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Extensions;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IModulePort" />
    /// <summary>
    /// Implementation of IModulePort interface
    /// </summary>
    public class E3ModulePort : ProxyWrapperBase<E3ModulePortProxy>, IModulePort
    {
        public E3ModulePort(E3Job job)
            : base(job, () => new E3ModulePortProxy(job.Proxy.CreateModulePortObject()))
        {
        }

        #region Implementation of IE3Identificated

        /// <inheritdoc />
        public int GetId() => Proxy.GetId();

        /// <inheritdoc />
        public int SetId(int id) => Proxy.SetId(id);

        /// <inheritdoc />
        public int Id
        {
            get => GetId();
            set => SetId(value);
        }

        #endregion

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => Proxy.GetName();

        #endregion

        #region Implementation of IE3Named

        /// <inheritdoc />
        public bool SetName(string name) => Proxy.SetName(name).CastToBool();

        /// <inheritdoc />
        public string Name
        {
            get => GetName();
            set => Proxy.SetName(value);
        }

        #endregion

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        /// <inheritdoc />
        public string GetGlobalId() => ((IJob)Parent).GetGidOfId(Id);

        /// <inheritdoc />
        public int SetId(string globalId) => Proxy.SetId(((IJob)Parent).GetIdOfGid(globalId));

        #endregion
    }
}