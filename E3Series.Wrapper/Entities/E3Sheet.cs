using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ISheet" />
    /// <summary>
    /// Implementation of ISheet interface
    /// </summary>
    public class E3Sheet : ComWrapperBase<E3SheetProxy>, ISheet
    {
        public E3Sheet(E3Job job)
            : base(job, () => new E3SheetProxy(job.ComObject.CreateSheetObject()))
        {
        }
    }
}