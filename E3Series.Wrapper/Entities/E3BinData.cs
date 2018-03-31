using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IBinData" />
    /// <summary>
    /// Implementation of IBinData interface
    /// </summary>
    public class E3BinData : ComWrapperBase<E3BinDataProxy>, IBinData
    {
        public E3BinData(E3Job job)
            : base(job, () => new E3BinDataProxy(job.ComObject.CreateBinDataObject()))
        {
        }
    }
}