using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3SignalClass COM object
    /// </summary>
    public interface ISignalClass : IComObjectProvider<E3SignalClassProxy>,
        IE3Identificated, IE3Named
    {
    }
}