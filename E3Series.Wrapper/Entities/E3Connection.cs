using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IConnection" />
    /// <summary>
    /// Implementation of IConnection interface
    /// </summary>
    public class E3Connection : ComWrapperBase<E3ConnectionProxy>, IConnection
    {
        public E3Connection(E3Job job)
            : base(job, () => new E3ConnectionProxy(job.ComObject.CreateConnectionObject()))
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