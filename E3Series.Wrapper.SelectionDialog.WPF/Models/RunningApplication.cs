using System;
using System.Collections.Generic;
using System.Diagnostics;
using E3Series.Wrapper.SelectionDialog.WPF.Interop;

namespace E3Series.Wrapper.SelectionDialog.WPF.Models
{
    /// <summary>
    /// Info about running E3.series instance
    /// </summary>
    public class RunningApplication
    {
        /// <summary>
        /// E3.series instance COM object
        /// </summary>
        public object ComObject { get; }

        /// <summary>
        /// Build version
        /// </summary>
        public string Build { get; }

        /// <summary>
        /// Main window title
        /// </summary>
        public string Caption { get; }

        /// <summary>
        /// Flag of E3.Enterprise version
        /// </summary>
        public bool IsMultiuser { get; }

        public RunningApplication(KeyValuePair<int, object> process)
        {
            ComObject = process.Value;
            Build = $"E3.Series {((dynamic)ComObject).GetBuild()}";
            Caption = WinApi.GetText(Process.GetProcessById(process.Key).MainWindowHandle);

            // Check for multiuser version
            IsMultiuser = Caption.IndexOf("Multi", StringComparison.InvariantCultureIgnoreCase) >= 0;
        }
    }
}