using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="INetSegment" />
    /// <summary>
    /// Implementation of INetSegment interface
    /// </summary>
    public class E3NetSegment : ComWrapperBase<E3NetSegmentProxy>, INetSegment
    {
        public E3NetSegment(E3Job job)
            : base(job, () => new E3NetSegmentProxy(job.ComObject.CreateNetSegmentObject()))
        {
        }
    }
}