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

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        /// <inheritdoc />
        public string GetGlobalId() => ((IJob)Parent).GetGidOfId(Id);

        /// <inheritdoc />
        public int SetId(string globalId) => ComObject.SetId(((IJob)Parent).GetIdOfGid(globalId));

        #endregion
    }
}