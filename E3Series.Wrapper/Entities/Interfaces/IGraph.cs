using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Graph COM object
    /// </summary>
    public interface IGraph : IProxyProvider<E3GraphProxy>,
        IE3Identificated, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}