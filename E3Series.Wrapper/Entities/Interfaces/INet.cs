using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Net COM object
    /// </summary>
    public interface INet : IProxyProvider<E3NetProxy>,
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal, IE3Attributed
    {
        bool TransferSignal { get; set; }
    }
}