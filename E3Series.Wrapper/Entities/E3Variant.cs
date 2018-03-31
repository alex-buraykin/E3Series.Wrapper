using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IVariant" />
    /// <summary>
    /// Implementation of IVariant interface
    /// </summary>
    public class E3Variant : ComWrapperBase<E3VariantProxy>, IVariant
    {
        public E3Variant(E3Job job)
            : base(job, () => new E3VariantProxy(job.ComObject.CreateVariantObject()))
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