using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3ModulePort COM object
    /// </summary>
    public interface IModulePort : IComObjectProvider<E3ModulePortProxy>,
        IE3Identificated
    {
    }
}