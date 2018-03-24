using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace E3Series.Wrapper.Interop
{
    /// <summary>
    /// WinApi methods signatures
    /// </summary>
    public static class WinApi
    {
        public enum GetWindowCmd : uint
        {
            GW_HWNDNEXT = 2,
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("ole32.dll")]
        public static extern int CreateBindCtx(int reserved, out IBindCtx ppbc);
    }
}