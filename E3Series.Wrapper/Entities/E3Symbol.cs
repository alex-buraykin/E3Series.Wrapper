using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ISymbol" />
    /// <summary>
    /// Implementation of ISymbol interface
    /// </summary>
    public class E3Symbol : ComWrapperBase<E3SymbolProxy>, ISymbol
    {
        public E3Symbol(E3Job job)
            : base(job, () => new E3SymbolProxy(job.ComObject.CreateSymbolObject()))
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