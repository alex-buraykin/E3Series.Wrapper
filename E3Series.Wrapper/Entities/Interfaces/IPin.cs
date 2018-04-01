using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Pin COM object
    /// </summary>
    public interface IPin : IComObjectProvider<E3PinProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}