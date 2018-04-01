using System;
using E3Series.Proxy.Abstract;

namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Generic interface for all class-wrappers with readonly access to proxy object
    /// </summary>
    public interface IProxyProvider<out T>: IDisposable where T : E3ProxyBase
    {
        /// <summary>
        /// Proxy for E3series COM object
        /// </summary>
        T Proxy { get; }
    }
}