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

        #region Implementation of IE3Identificated

        /// <inheritdoc />
        public int GetId() => ComObject.GetId();

        /// <inheritdoc />
        public int SetId(int id) => ComObject.SetId(id);

        /// <inheritdoc />
        public int Id
        {
            get => GetId();
            set => SetId(value);
        }

        #endregion
    }
}