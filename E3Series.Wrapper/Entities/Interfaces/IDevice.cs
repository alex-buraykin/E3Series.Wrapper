using System.Collections.Generic;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Device COM object
    /// </summary>
    public interface IDevice : IProxyProvider<E3DeviceProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal, IE3Attributed
    {
        /// <summary>
        /// Returns iterator of all devices in given assembly/terminal block
        /// </summary>
        /// <param name="iterator">IDevice iterator</param>
        /// <param name="expandAll">Recurcive</param>
        /// <returns></returns>
        IEnumerable<IDevice> GetDevices(IDevice iterator, bool expandAll = false);
    }
}