using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IPin" />
    /// <summary>
    /// Implementation of IPin interface
    /// </summary>
    public class E3Pin : ComWrapperBase<E3PinProxy>, IPin
    {
        public E3Pin(E3Job job)
            : base(job, () => new E3PinProxy(job.ComObject.CreatePinObject()))
        {
        }
    }
}