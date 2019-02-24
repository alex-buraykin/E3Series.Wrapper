using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.Entities.Extensions;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IApplication" />
    /// <summary>
    /// Implementation of IApplication interface
    /// </summary>
    public class E3Application : ProxyWrapperBase<E3ApplicationProxy>, IApplication
    {
        protected internal E3Application(object comObject)
            : base(null, () => new E3ApplicationProxy(comObject))
        {
        }

        /// <inheritdoc />
        public bool IsApplicationRunning() => Proxy?.ComObject != null;

        /// <inheritdoc />
        public bool IsProjectOpened() => Proxy.GetJobCount() != 0;

        /// <inheritdoc />
        public IJob CreateJobObject() => this.CreateObject<IJob, E3ApplicationProxy>();

        /// <inheritdoc />
        public bool IsMultiuser() => Proxy.IsMultiuser() == 1;

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => Proxy.GetName();

        #endregion
    }
}