using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Bundle COM object
    /// </summary>
    public interface IBundle : IComObjectProvider<E3BundleProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}