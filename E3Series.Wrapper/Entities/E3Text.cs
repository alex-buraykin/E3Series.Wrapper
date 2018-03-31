using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IText" />
    /// <summary>
    /// Implementation of IText interface
    /// </summary>
    public class E3Text : ComWrapperBase<E3TextProxy>, IText
    {
        public E3Text(E3Job job)
            : base(job, () => new E3TextProxy(job.ComObject.CreateTextObject()))
        {
        }
    }
}