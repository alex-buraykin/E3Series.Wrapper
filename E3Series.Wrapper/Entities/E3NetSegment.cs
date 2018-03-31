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

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => ComObject.GetName();

        #endregion
    }
}