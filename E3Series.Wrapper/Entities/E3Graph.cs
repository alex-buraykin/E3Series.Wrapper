using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IGraph" />
    /// <summary>
    /// Implementation of IGraph interface
    /// </summary>
    public class E3Graph : ComWrapperBase<E3GraphProxy>, IGraph
    {
        public E3Graph(E3Job job)
            : base(job, () => new E3GraphProxy(job.ComObject.CreateGraphObject()))
        {
        }
    }
}