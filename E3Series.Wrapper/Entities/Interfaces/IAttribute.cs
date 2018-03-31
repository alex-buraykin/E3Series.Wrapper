using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Attribute COM object
    /// </summary>
    public interface IAttribute : IComObjectProvider<E3AttributeProxy>, 
        IE3Identificated
    {
    }
}