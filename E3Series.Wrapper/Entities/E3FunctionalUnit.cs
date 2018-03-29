using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IFunctionalUnit" />
    /// <summary>
    /// Implementation of IFunctionalUnit interface
    /// </summary>
    public class E3FunctionalUnit : ComWrapperBase<E3FunctionalUnitProxy>, IFunctionalUnit
    {
        public E3FunctionalUnit(E3Job job)
            : base(job, () => new E3FunctionalUnitProxy(job.ComObject.CreateFunctionalUnitObject()))
        {
        }
    }
}