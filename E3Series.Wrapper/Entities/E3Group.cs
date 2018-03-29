using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IGroup" />
    /// <summary>
    /// Implementation of IGroup interface
    /// </summary>
    public class E3Group : ComWrapperBase<E3GroupProxy>, IGroup
    {
        public E3Group(E3Job job)
            : base(job, () => new E3GroupProxy(job.ComObject.CreateGroupObject()))
        {
        }
    }
}