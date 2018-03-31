using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3FunctionalUnit COM object
    /// </summary>
    public interface IFunctionalUnit : IComObjectProvider<E3FunctionalUnitProxy>,
        IE3Identificated, IE3Named
    {
    }
}