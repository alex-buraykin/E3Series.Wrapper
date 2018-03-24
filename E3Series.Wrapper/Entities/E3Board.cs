using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IBoard" />
    /// <summary>
    /// Implementation of IBoard interface
    /// </summary>
    public class E3Board : ComWrapperBase<E3BoardProxy>, IBoard
    {
        public E3Board(E3Job job)
            : base(job, () => new E3BoardProxy(job.ComObject.CreateBoardObject()))
        {
        }
    }
}