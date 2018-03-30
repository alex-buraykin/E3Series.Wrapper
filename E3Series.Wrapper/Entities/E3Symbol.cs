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
    }
}