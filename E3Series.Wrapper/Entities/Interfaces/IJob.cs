using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Job COM object
    /// </summary>
    public interface IJob : IComObjectProvider<E3JobProxy>
    {
        
    }
}