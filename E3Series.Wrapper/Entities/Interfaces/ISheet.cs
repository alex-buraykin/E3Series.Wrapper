using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;
using E3Series.Wrapper.Entities.Models;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Sheet COM object
    /// </summary>
    public interface ISheet : IProxyProvider<E3SheetProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal, IE3Attributed
    {
        /// <summary>
        /// Check if sheet is offline (for multiuser project)
        /// </summary>
        /// <returns></returns>
        bool IsOffline();

        /// <summary>
        /// Checkout sheet in multiuser project
        /// </summary>
        /// <param name="mode">Checkout mode</param>
        /// <returns></returns>
        CheckOutResult CheckOut(CheckOutMode mode = CheckOutMode.ReadAndWrite);
    }
}