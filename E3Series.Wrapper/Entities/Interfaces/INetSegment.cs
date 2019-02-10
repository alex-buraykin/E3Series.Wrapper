using System.Collections.Generic;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3NetSegment COM object
    /// </summary>
    public interface INetSegment : IProxyProvider<E3NetSegmentProxy>,
        IE3Identificated,
        IE3NamedReadonly,
        IE3IdentificatedGlobal,
        IE3Attributed
    {
        /// <summary>
        /// Returns iterator of nodes
        /// </summary>
        /// <param name="iterator">IPin iterator</param>
        /// <returns></returns>
        IEnumerable<IPin> GetNodes(IPin iterator);
    }
}