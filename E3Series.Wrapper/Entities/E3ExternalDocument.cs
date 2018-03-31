using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IExternalDocument" />
    /// <summary>
    /// Implementation of IExternalDocument interface
    /// </summary>
    public class E3ExternalDocument : ComWrapperBase<E3ExternalDocumentProxy>, IExternalDocument
    {
        public E3ExternalDocument(E3Job job)
            : base(job, () => new E3ExternalDocumentProxy(job.ComObject.CreateExternalDocumentObject()))
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