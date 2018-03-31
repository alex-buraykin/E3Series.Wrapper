using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Variant COM object
    /// </summary>
    public interface IVariant : IComObjectProvider<E3VariantProxy>,
        IE3Identificated, IE3Named
    {
    }
}