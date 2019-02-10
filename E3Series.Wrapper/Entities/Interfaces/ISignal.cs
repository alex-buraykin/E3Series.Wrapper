using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Signal COM object
    /// </summary>
    public interface ISignal : IProxyProvider<E3SignalProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal, IE3Attributed
    {
        /// <summary>
        /// Search signal with given name and set current instance to this signal
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ISignal Search(string name);
    }
}