using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ISignal" />
    /// <summary>
    /// Implementation of ISignal interface
    /// </summary>
    public class E3Signal : ComWrapperBase<E3SignalProxy>, ISignal
    {
        public E3Signal(E3Job job)
            : base(job, () => new E3SignalProxy(job.ComObject.CreateSignalObject()))
        {
        }
    }
}