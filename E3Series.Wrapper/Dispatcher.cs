using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace E3Series.Wrapper
{
    /// <summary>
    /// Class-dispatcher of running E3.series COM objects
    /// </summary>
    public static class Dispatcher
    {
        #region WinApi Imports

        [DllImport("ole32.dll")]
        private static extern int CreateBindCtx(int reserved, out IBindCtx ppbc);

        #endregion

        #region Public Methods

        /// <summary>
        /// Get IEnumerablw
        /// </summary>
        /// <returns></returns>
        [STAThread]
        public static Dictionary<int, object> GetRunningE3SeriesApplications()
        {
            var dict = new Dictionary<int, object>();
            IRunningObjectTable runningObjectTable;
            IEnumMoniker monikerEnumerator;
            var monikers = new IMoniker[1];

            IBindCtx ctx;
            CreateBindCtx(0, out ctx);

            ctx.GetRunningObjectTable(out runningObjectTable);
            runningObjectTable.EnumRunning(out monikerEnumerator);
            monikerEnumerator.Reset();

            while (monikerEnumerator.Next(1, monikers, IntPtr.Zero) == 0)
            {
                string runningObjectName;
                monikers[0].GetDisplayName(ctx, null, out runningObjectName);

                if (!runningObjectName.StartsWith("!E3Application", StringComparison.InvariantCultureIgnoreCase))
                    continue;

                int index = runningObjectName.IndexOf(':');
                if (index == -1) continue;

                object runningObjectVal;
                runningObjectTable.GetObject(monikers[0], out runningObjectVal);

                dict.Add(int.Parse(runningObjectName.Substring(index + 1)), runningObjectVal);
            }

            return dict;
        }

        #endregion
    }
}