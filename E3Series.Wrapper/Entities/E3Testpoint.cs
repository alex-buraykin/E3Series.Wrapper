using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ITestpoint" />
    /// <summary>
    /// Implementation of ITestpoint interface
    /// </summary>
    public class E3Testpoint : ComWrapperBase<E3TestpointProxy>, ITestpoint
    {
        public E3Testpoint(E3Job job)
            : base(job, () => new E3TestpointProxy(job.ComObject.CreateTestpointObject()))
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
    }
}