using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack._Function
{
    class Window
    {
        /// <summary>
        /// 窗口样式类
        /// </summary>
        public class WndStyle
        {
            public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
            public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
            public static readonly IntPtr HWND_TOP = new IntPtr(0);
            public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        }

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern bool SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            uint uFlags
            );
    }
}
