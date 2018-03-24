using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Job COM object
    /// </summary>
    public interface IJob : IComObjectProvider<E3JobProxy>
    {
        /// <summary>
        /// Create object for working with attribute
        /// </summary>
        /// <returns></returns>
        IAttribute CreateAttributeObject();

        /// <summary>
        /// Create object for working with bin data
        /// </summary>
        /// <returns></returns>
        IBinData CreateBinDataObject();

        /// <summary>
        /// Create object for working with board
        /// </summary>
        /// <returns></returns>
        IBoard CreateBoardObject();

        /// <summary>
        /// Create object for working with bundle
        /// </summary>
        /// <returns></returns>
        IBundle CreateBundleObject();

        /// <summary>
        /// Create object for working with component
        /// </summary>
        /// <returns></returns>
        IComponent CreateComponentObject();

        /// <summary>
        /// Create object for working with sheet
        /// </summary>
        /// <returns></returns>
        ISheet CreateSheetObject();
    }
}