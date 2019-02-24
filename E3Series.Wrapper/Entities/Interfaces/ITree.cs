using System.Collections.Generic;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Tree COM object
    /// </summary>
    public interface ITree : IProxyProvider<E3TreeProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
        /// <summary>
        /// Returns iterator of all selected terminals in project tree
        /// </summary>
        /// <param name="iterator">IDevice iterator</param>
        /// <returns></returns>
        IEnumerable<IDevice> GetSelectedTerminals(IDevice iterator);
    }
}