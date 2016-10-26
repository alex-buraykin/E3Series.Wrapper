using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace E3Series.Wrapper.SelectionDialog.WPF.Models
{
    /// <summary>
    /// Info about running E3.series instance
    /// </summary>
    public class RunningApplication
    {
        #region Public Fields

        /// <summary>
        /// E3.series instance COM object
        /// </summary>
        public object ComObject { get; private set; }

        /// <summary>
        /// Build version
        /// </summary>
        public string Build { get; private set; }

        /// <summary>
        /// Main window title
        /// </summary>
        public string Caption { get; private set; }

        /// <summary>
        /// Flag of E3.Enterprise version
        /// </summary>
        public bool IsMultiuser { get; private set; }

        #endregion

        #region Constructor

        public RunningApplication(KeyValuePair<int, object> process)
        {
            ComObject = process.Value;
            Build = string.Format("E3.Series {0}", ((dynamic) ComObject).GetBuild());
            Caption = GetText(Process.GetProcessById(process.Key).MainWindowHandle);

            // Check for multiuser version
            IsMultiuser = Caption.IndexOf("Multi", StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        #endregion

        #region WinApi Imports

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        #endregion

        #region Private Methods

        /// <summary>
        /// Get window title as string
        /// </summary>
        /// <param name="hWnd">Window's handle</param>
        /// <returns></returns>
        private static string GetText(IntPtr hWnd)
        {
            // Allocate correct string length first
            var length = GetWindowTextLength(hWnd);
            var sb = new StringBuilder(length + 1);
            GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        #endregion
    }
}