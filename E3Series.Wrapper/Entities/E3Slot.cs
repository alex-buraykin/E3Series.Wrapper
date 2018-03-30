using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ISlot" />
    /// <summary>
    /// Implementation of ISlot interface
    /// </summary>
    public class E3Slot : ComWrapperBase<E3SlotProxy>, ISlot
    {
        public E3Slot(E3Job job)
            : base(job, () => new E3SlotProxy(job.ComObject.CreateSlotObject()))
        {
        }
    }
}