using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3ConnectLine COM object
    /// </summary>
    public interface IConnectLine : IProxyProvider<E3ConnectLineProxy>,
        IE3Identificated, IE3IdentificatedGlobal
    {
    }
}