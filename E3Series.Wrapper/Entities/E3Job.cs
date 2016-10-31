using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <summary>
    /// Implementation of IJob interface
    /// </summary>
    public class E3Job : ComWrapper, IJob
    {
        #region Constructor

        protected internal E3Job(E3Application app) 
            : base(app, () => app.ComObject.CreateJobObject())
        {
        }

        #endregion
    }
}