using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Field COM object
    /// </summary>
    public interface IField : IProxyProvider<E3FieldProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}