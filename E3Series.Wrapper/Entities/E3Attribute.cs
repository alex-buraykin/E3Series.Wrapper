using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IAttribute" />
    /// <summary>
    /// Implementation of IAttribute interface
    /// </summary>
    public class E3Attribute : ComWrapperBase<E3AttributeProxy>, IAttribute
    {
        public E3Attribute(E3Job job)
            : base(job, () => new E3AttributeProxy(job.ComObject.CreateAttributeObject()))
        {
        }
    }
}