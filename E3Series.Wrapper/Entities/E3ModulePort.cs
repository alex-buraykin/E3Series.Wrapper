using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IModulePort" />
    /// <summary>
    /// Implementation of IModulePort interface
    /// </summary>
    public class E3ModulePort : ComWrapperBase<E3ModulePortProxy>, IModulePort
    {
        public E3ModulePort(E3Job job)
            : base(job, () => new E3ModulePortProxy(job.ComObject.CreateModulePortObject()))
        {
        }
    }
}