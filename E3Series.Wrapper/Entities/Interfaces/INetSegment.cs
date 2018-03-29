using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3NetSegment COM object
    /// </summary>
    public interface INetSegment : IComObjectProvider<E3NetSegmentProxy>
    {
    }
}