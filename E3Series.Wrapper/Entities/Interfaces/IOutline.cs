using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Outline COM object
    /// </summary>
    public interface IOutline : IProxyProvider<E3OutlineProxy>,
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal
    {
    }
}