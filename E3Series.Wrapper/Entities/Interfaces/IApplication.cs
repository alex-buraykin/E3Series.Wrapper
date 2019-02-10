using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Apllication COM object
    /// </summary>
    public interface IApplication : IProxyProvider<E3ApplicationProxy>,
        IE3NamedReadonly
    {
        /// <summary>
        /// Check for successful connect to E3.series COM
        /// </summary>
        /// <returns></returns>
        bool IsApplicationRunning();

        /// <summary>
        /// Check for opened project
        /// </summary>
        /// <returns></returns>
        bool IsProjectOpened();

        /// <summary>
        /// Create wrapper for e3Job COM object
        /// </summary>
        /// <returns></returns>
        IJob CreateJobObject();
    }
}