using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IStructureNode" />
    /// <summary>
    /// Implementation of IStructureNode interface
    /// </summary>
    public class E3StructureNode : ComWrapperBase<E3StructureNodeProxy>, IStructureNode
    {
        public E3StructureNode(E3Job job)
            : base(job, () => new E3StructureNodeProxy(job.ComObject.CreateStructureNodeObject()))
        {
        }
    }
}