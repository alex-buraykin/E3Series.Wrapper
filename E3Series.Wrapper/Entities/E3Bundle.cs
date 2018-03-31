using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IBundle" />
    /// <summary>
    /// Implementation of IBundle interface
    /// </summary>
    public class E3Bundle : ComWrapperBase<E3BundleProxy>, IBundle
    {
        public E3Bundle(E3Job job)
            : base(job, () => new E3BundleProxy(job.ComObject.CreateBundleObject()))
        {
        }
    }
}