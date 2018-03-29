using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IConnectLine" />
    /// <summary>
    /// Implementation of IConnectLine interface
    /// </summary>
    public class E3ConnectLine : ComWrapperBase<E3ConnectLineProxy>, IConnectLine
    {
        public E3ConnectLine(E3Job job)
            : base(job, () => new E3ConnectLineProxy(job.ComObject.CreateConnectLineObject()))
        {
        }
    }
}