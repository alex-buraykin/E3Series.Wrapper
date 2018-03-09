using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ComWrapperBase" />
    /// <inheritdoc cref="IJob" />
    /// <summary>
    /// Implementation of IJob interface
    /// </summary>
    public class E3Job : ComWrapperBase, IJob
    {
        protected internal E3Job(E3Application app) 
            : base(app, () => app.ComObject.CreateJobObject())
        {
        }
    }
}