using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IJob" />
    /// <summary>
    /// Implementation of IJob interface
    /// </summary>
    public class E3Job : ComWrapperBase<E3JobProxy>, IJob
    {
        public E3Job(E3Application app) 
            : base(app, () => new E3JobProxy(app.ComObject.CreateJobObject()))
        {
        }
    }
}