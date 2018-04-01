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
    public class E3Application : ComWrapperBase<E3ApplicationProxy>, IApplication
    {
        protected internal E3Application(object comObject)
            : base(null, () => new E3ApplicationProxy(comObject))
        {
        }

        /// <inheritdoc />
        public bool IsProjectOpened() => ComObject.GetJobCount() != 0;

        /// <inheritdoc />
        public IJob CreateJobObject()
        {
            return this.CreateObject<IJob, E3ApplicationProxy>();
        }

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => ComObject.GetName();

        #endregion
    }
}