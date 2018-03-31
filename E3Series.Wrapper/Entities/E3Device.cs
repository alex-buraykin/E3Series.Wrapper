using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IDevice" />
    /// <summary>
    /// Implementation of IDevice interface
    /// </summary>
    public class E3Device : ComWrapperBase<E3DeviceProxy>, IDevice
    {
        public E3Device(E3Job job)
            : base(job, () => new E3DeviceProxy(job.ComObject.CreateDeviceObject()))
        {
        }
    }
}