using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IOption" />
    /// <summary>
    /// Implementation of IOption interface
    /// </summary>
    public class E3Option : ComWrapperBase<E3OptionProxy>, IOption
    {
        public E3Option(E3Job job)
            : base(job, () => new E3OptionProxy(job.ComObject.CreateOptionObject()))
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

        /// <inheritdoc />
        public string GetName() => ComObject.GetName();

        #endregion

        #region Implementation of IE3Named

        /// <inheritdoc />
        public bool SetName(string name) => ComObject.SetName(name) == 1;

        /// <inheritdoc />
        public string Name
        {
            get => GetName();
            set => ComObject.SetName(value);
        }

        #endregion
    }
}