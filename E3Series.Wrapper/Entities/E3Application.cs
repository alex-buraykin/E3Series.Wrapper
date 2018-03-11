using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

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
    }
}