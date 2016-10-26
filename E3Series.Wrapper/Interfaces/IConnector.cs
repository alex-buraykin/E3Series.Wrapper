using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Interfaces
{
    /// <summary>
    /// Interface for all connectors
    /// </summary>
    public interface IConnector
    {
        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <returns>Wrapped e3Application COM object</returns>
        IApplication Connect();


        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <param name="connectorSelectionDialog">Implementation of Selection Dialog 
        /// (used in case of multiple running E3.series instances)</param>
        /// <returns>Wrapped e3Application COM object</returns>
        IApplication Connect(IConnectorSelectionDialog connectorSelectionDialog);

        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <param name="processId">E3.series application process id</param>
        /// <returns>Wrapped e3Application COM object</returns>
        IApplication Connect(int processId);
    }
}