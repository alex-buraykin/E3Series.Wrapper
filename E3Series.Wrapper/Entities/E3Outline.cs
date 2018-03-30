using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IOutline" />
    /// <summary>
    /// Implementation of IOutline interface
    /// </summary>
    public class E3Outline : ComWrapperBase<E3OutlineProxy>, IOutline
    {
        public E3Outline(E3Job job)
            : base(job, () => new E3OutlineProxy(job.ComObject.CreateOutlineObject()))
        {
        }
    }
}