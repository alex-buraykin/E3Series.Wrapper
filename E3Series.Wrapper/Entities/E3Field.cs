using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IField" />
    /// <summary>
    /// Implementation of IField interface
    /// </summary>
    public class E3Field : ComWrapperBase<E3FieldProxy>, IField
    {
        public E3Field(E3Job job)
            : base(job, () => new E3FieldProxy(job.ComObject.CreateFieldObject()))
        {
        }
    }
}