using E3Series.Wrapper.Entities.Base;
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
        
        #region IComObjectProvider Members

        public object ComObject
        {
            get { return UntypedComObject; }
        }

        #endregion
    }
}