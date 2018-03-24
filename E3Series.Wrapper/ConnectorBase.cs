using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using E3Series.Wrapper.Entities;
using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.Interfaces;
using E3Series.Wrapper.Interop;

namespace E3Series.Wrapper
{
    /// <inheritdoc />
    /// <summary>
    /// Entry point for this library
    /// </summary>
    public class ConnectorBase : IConnector
    {
        private static readonly string[] Identifiers = { "E3SERI~1", "E3.series" };

        /// <inheritdoc />
        public virtual IApplication Connect()
        {
            var comObject = GetProcess();

            return comObject != null 
                ? new E3Application(comObject) 
                : null;
        }
       
        /// <inheritdoc />
        public virtual IApplication Connect(int processId)
        {
            var comObject = GetProcess(processId);

            return comObject != null 
                ? new E3Application(comObject) 
                : null;
        }

        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <param name="connectorSelectionDialog">Implementation of Selection Dialog 
        /// (used in case of multiple running E3.series instances)</param>
        /// <returns>Wrapped e3Application COM object</returns>
        protected IApplication Connect(IConnectorSelectionDialog connectorSelectionDialog)
        {
            var comObject = GetProcess(connectorSelectionDialog);

            return comObject != null
                ? new E3Application(comObject)
                : null;
        }

        #region Private Methods

        /// <summary>
        /// Get E3.series COM object
        /// </summary>
        /// <param name="connectorSelectionDialog">Selection dialog for multiple running instances of E3.series</param>
        /// <returns></returns>
        private static object GetProcess(IConnectorSelectionDialog connectorSelectionDialog = null)
        {
            var processes = Dispatcher.GetRunningE3SeriesApplications();

            if (processes.Count == 0)
                return null;

            if (processes.Count == 1)
                return processes.First().Value;

            // If multiple instances of E3.series, try to connect to foreground process
            var hWnd = WinApi.GetForegroundWindow();
            WinApi.GetWindowThreadProcessId(hWnd, out var curPid);

            if (Process.GetProcessById(curPid).ProcessName == Assembly.GetEntryAssembly().GetName().Name)
            {
                var targetHwnd = WinApi.GetWindow(Process.GetCurrentProcess().MainWindowHandle,
                    (uint) WinApi.GetWindowCmd.GW_HWNDNEXT);

                while (true)
                {
                    var temp = WinApi.GetParent(targetHwnd);
                    if (temp.Equals(IntPtr.Zero)) break;
                    targetHwnd = temp;
                }
                WinApi.GetWindowThreadProcessId(targetHwnd, out curPid);
            }
            if (Identifiers.Contains(Process.GetProcessById(curPid).ProcessName))
                return GetProcess(Process.GetProcessById(curPid).Id);

            // If connection to foreground window fails, 
            // then show selection dialog (if exists) or throw exception
            if (connectorSelectionDialog == null)
                throw new NotSupportedException(
                    "Multiple running E3.series processes. Bring needed E3.series instance on top and restart application or implement connectorSelectionDialog in your application");

            var result = connectorSelectionDialog.ShowDialog(processes, out var selectedProcess);
            return result ? selectedProcess : null;
        }

        /// <summary>
        /// Get E3.series COM object by process id
        /// </summary>
        /// <param name="processId">E3.series application process id</param>
        /// <returns></returns>
        private static object GetProcess(int processId)
        {
            var processes = Dispatcher.GetRunningE3SeriesApplications();

            return processes.ContainsKey(processId) ? processes[processId] : null;
        }

        #endregion
    }
}