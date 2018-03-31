using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IText" />
    /// <summary>
    /// Implementation of IText interface
    /// </summary>
    public class E3Text : ComWrapperBase<E3TextProxy>, IText
    {
        public E3Text(E3Job job)
            : base(job, () => new E3TextProxy(job.ComObject.CreateTextObject()))
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