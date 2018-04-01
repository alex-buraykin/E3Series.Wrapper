using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Supply COM object
    /// </summary>
    public interface ISupply : IProxyProvider<E3SupplyProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}