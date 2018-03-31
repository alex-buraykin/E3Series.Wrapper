using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IOption" />
    /// <summary>
    /// Implementation of IOption interface
    /// </summary>
    public class E3Option : ComWrapperBase<E3OptionProxy>, IOption
    {
        public E3Option(E3Job job)
            : base(job, () => new E3OptionProxy(job.ComObject.CreateOptionObject()))
        {
        }
    }
}