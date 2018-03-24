using System;
using System.Runtime.InteropServices;
using System.Text;

namespace E3Series.Wrapper.SelectionDialog.WPF.Interop
{
    /// <summary>
    /// WinApi methods signatures
    /// </summary>
    public static class WinApi
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// Get window title as string
        /// </summary>
        /// <param name="hWnd">Window's handle</param>
        /// <returns></returns>
        public static string GetText(IntPtr hWnd)
        {
            // Allocate correct string length first
            var length = GetWindowTextLength(hWnd);
            var sb = new StringBuilder(length + 1);
            GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }
    }
}