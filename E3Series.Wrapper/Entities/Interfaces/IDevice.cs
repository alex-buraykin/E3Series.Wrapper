using System.Collections.Generic;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;
using E3Series.Wrapper.Entities.Models;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Device COM object
    /// </summary>
    public interface IDevice : IProxyProvider<E3DeviceProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal, IE3Attributed
    {
        /// <summary>
        /// Returns iterator of all devices in given assembly/terminal block
        /// </summary>
        /// <param name="iterator">IDevice iterator</param>
        /// <param name="expandAll">Recurcive</param>
        /// <returns></returns>
        IEnumerable<IDevice> GetDevices(IDevice iterator, bool expandAll = false);

        /// <summary>
        /// Get device's symbol count (also works with multiuser projects)
        /// </summary>
        /// <param name="pinIterator">IPin iterator</param>
        /// <param name="sheetIterator">ISheet iterator</param>
        /// <param name="mode">Type of symbol</param>
        /// <returns></returns>
        int GetSymbolCountByPins(
            IPin pinIterator,
            ISheet sheetIterator,
            SymbolModeEnum mode = SymbolModeEnum.AllSymbols);

        /// <summary>
        /// Returns iterator of symbols in device
        /// </summary>
        /// <param name="iterator">ISymbol iterator</param>
        /// <param name="mode">Symbol type</param>
        /// <returns></returns>
        IEnumerable<ISymbol> GetSymbols(ISymbol iterator, SymbolModeEnum mode = SymbolModeEnum.AllSymbols);

        /// <summary>
        /// Get ids of device's symbols
        /// </summary>
        /// <param name="mode">Symbol type</param>
        /// <returns></returns>
        IEnumerable<int> GetSymbolIds(SymbolModeEnum mode = SymbolModeEnum.AllSymbols);

        /// <summary>
        /// Get device's symbol count
        /// </summary>
        /// <param name="mode">Symbol type</param>
        /// <returns></returns>
        int GetSymbolCount(SymbolModeEnum mode = SymbolModeEnum.AllSymbols);

        /// <summary>
        /// Returns iterator of pins in device
        /// </summary>
        /// <param name="iterator">IPin iterator</param>
        /// <returns></returns>
        IEnumerable<IPin> GetPins(IPin iterator);

        /// <summary>
        /// Get device location on panel sheet
        /// </summary>
        /// <returns></returns>
        PanelLocationStruct? GetPanelLocation();
    }
}