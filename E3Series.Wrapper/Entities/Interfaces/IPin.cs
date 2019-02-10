using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;
using E3Series.Wrapper.Entities.Models;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Pin COM object
    /// </summary>
    public interface IPin : IProxyProvider<E3PinProxy>,
        IE3Identificated,
        IE3Named,
        IE3IdentificatedGlobal,
        IE3Attributed,
        IE3SchemaLocation
    {
        /// <summary>
        /// Pin Signal name
        /// </summary>
        string SignalName { get; set; }

        /// <summary>
        /// Get signal name type (not set/system/user)
        /// </summary>
        /// <returns></returns>
        SignalNameType GetSignalNameType();
    }
}