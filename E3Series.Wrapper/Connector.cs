using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using E3Series.Wrapper.Entities;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper
{
    /// <summary>
    /// Entry point for this library
    /// </summary>
    public static class Connector
    {
        #region Public Methods

        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <returns>Wrapped e3Application COM object</returns>
        public static IApplication Connect()
        {
            return new E3Application(GetProcess());
        }

        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <param name="connectorSelectionDialog">Implementation of Selection Dialog 
        /// (used in case of multiple running E3.series instances)</param>
        /// <returns>Wrapped e3Application COM object</returns>
        public static IApplication Connect(IConnectorSelectionDialog connectorSelectionDialog)
        {
            return new E3Application(GetProcess(connectorSelectionDialog));
        }
        
        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <param name="processId">E3.series application process id</param>
        /// <returns>Wrapped e3Application COM object</returns>
        public static IApplication Connect(int processId)
        {
            return new E3Application(GetProcess(processId));
        }

        #endregion

        #region WinApi Imports

        private enum GetWindowCmd : uint
        {
            GW_HWNDNEXT = 2,
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        private static extern IntPtr GetParent(IntPtr hWnd);

        #endregion

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
            IntPtr hWnd = GetForegroundWindow();
            int curPid;
            GetWindowThreadProcessId(hWnd, out curPid);

            if (Process.GetProcessById(curPid).ProcessName == Assembly.GetEntryAssembly().GetName().Name)
            {
                IntPtr targetHwnd = GetWindow(Process.GetCurrentProcess().MainWindowHandle,
                    (uint) GetWindowCmd.GW_HWNDNEXT);

                while (true)
                {
                    IntPtr temp = GetParent(targetHwnd);
                    if (temp.Equals(IntPtr.Zero)) break;
                    targetHwnd = temp;
                }
                GetWindowThreadProcessId(targetHwnd, out curPid);
            }
            if (Process.GetProcessById(curPid).ProcessName == "E3.series")
                return GetProcess(Process.GetProcessById(curPid).Id);

            // If connection to foreground window fails, 
            // then show selection dialog (if exists) or throw exception
            if (connectorSelectionDialog == null)
                throw new NotImplementedException(
                    "Multiple running E3.series processes. Bring needed E3.series instance on top and restart application or implement connectorSelectionDialog in your application");

            object selectedProcess = null;
            var result = connectorSelectionDialog.ShowDialog(processes, ref selectedProcess);
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