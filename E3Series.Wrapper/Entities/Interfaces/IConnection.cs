using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Connection COM object
    /// </summary>
    public interface IConnection : IComObjectProvider<E3ConnectionProxy>,
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}