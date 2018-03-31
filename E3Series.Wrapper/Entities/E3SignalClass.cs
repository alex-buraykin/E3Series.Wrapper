using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ISignalClass" />
    /// <summary>
    /// Implementation of ISignalClass interface
    /// </summary>
    public class E3SignalClass : ComWrapperBase<E3SignalClassProxy>, ISignalClass
    {
        public E3SignalClass(E3Job job)
            : base(job, () => new E3SignalClassProxy(job.ComObject.CreateSignalClassObject()))
        {
        }
    }
}