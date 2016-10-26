using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Extensions;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <summary>
    /// Implementation of IApplication interface
    /// </summary>
    public class E3Application : ComWrapper, IApplication
    {
        #region Constructor

        public E3Application(object comObject)
            : base(null, () => comObject)
        {
        }

        #endregion

        #region IApplication Members
        public IJob CreateJobObject()
        {
            return this.CreateObject<IJob>();
        }

        #endregion
    }
}