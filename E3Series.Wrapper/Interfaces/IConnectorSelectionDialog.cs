using System.Collections.Generic;

namespace E3Series.Wrapper.Interfaces
{
    /// <summary>
    /// Interface for creating Selection Dialog
    /// </summary>
    public interface IConnectorSelectionDialog
    {
        /// <summary>
        /// Show selection dialog
        /// </summary>
        /// <param name="processes">List of running E3.series instances</param>
        /// <param name="selectedProcess">Return selected instance</param>
        /// <returns></returns>
        bool ShowDialog(Dictionary<int, object> processes, out object selectedProcess);
    }
}