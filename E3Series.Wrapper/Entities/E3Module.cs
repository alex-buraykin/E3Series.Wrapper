using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IModule" />
    /// <summary>
    /// Implementation of IModule interface
    /// </summary>
    public class E3Module : ComWrapperBase<E3ModuleProxy>, IModule
    {
        public E3Module(E3Job job)
            : base(job, () => new E3ModuleProxy(job.ComObject.CreateModuleObject()))
        {
        }
    }
}