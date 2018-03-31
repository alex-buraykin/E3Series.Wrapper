using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IComponent" />
    /// <summary>
    /// Implementation of IComponent interface
    /// </summary>
    public class E3Component : ComWrapperBase<E3ComponentProxy>, IComponent
    {
        public E3Component(E3Job job)
            : base(job, () => new E3ComponentProxy(job.ComObject.CreateComponentObject()))
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