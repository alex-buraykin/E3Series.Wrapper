using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="INet" />
    /// <summary>
    /// Implementation of INet interface
    /// </summary>
    public class E3Net : ComWrapperBase<E3NetProxy>, INet
    {
        public E3Net(E3Job job)
            : base(job, () => new E3NetProxy(job.ComObject.CreateNetObject()))
        {
        }
    }
}