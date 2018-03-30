using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ITree" />
    /// <summary>
    /// Implementation of ITree interface
    /// </summary>
    public class E3Tree : ComWrapperBase<E3TreeProxy>, ITree
    {
        public E3Tree(E3Job job)
            : base(job, () => new E3TreeProxy(job.ComObject.CreateTreeObject()))
        {
        }
    }
}