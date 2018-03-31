using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IFunctionalPort" />
    /// <summary>
    /// Implementation of IFunctionalPort interface
    /// </summary>
    public class E3FunctionalPort : ComWrapperBase<E3FunctionalPortProxy>, IFunctionalPort
    {
        public E3FunctionalPort(E3Job job)
            : base(job, () => new E3FunctionalPortProxy(job.ComObject.CreateFunctionalPortObject()))
        {
        }
    }
}