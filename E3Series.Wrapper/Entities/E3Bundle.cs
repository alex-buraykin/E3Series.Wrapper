using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IBundle" />
    /// <summary>
    /// Implementation of IBundle interface
    /// </summary>
    public class E3Bundle : ComWrapperBase<E3BundleProxy>, IBundle
    {
        public E3Bundle(E3Job job)
            : base(job, () => new E3BundleProxy(job.ComObject.CreateBundleObject()))
        {
        }

        #region Implementation of IE3Identificated

        /// <inheritdoc />
        public int GetId() => ComObject.GetId();

        /// <inheritdoc />
        public int SetId(int id) => ComObject.SetId(id);

        /// <inheritdoc />
        public int Id
        {
            get => GetId();
            set => SetId(value);
        }

        #endregion

        #region Implementation of IE3NamedReadonly

        /// <summary>
        /// Get name of object
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Implementation of IE3Named

        /// <summary>
        /// Set name for object
        /// </summary>
        /// <param name="name">New name</param>
        /// <returns></returns>
        public bool SetName(string name)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Name of object
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}