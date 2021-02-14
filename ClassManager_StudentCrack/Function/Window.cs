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
        public bool IsTop { get; set; } = true;

        /// <summary>
        /// 窗口样式类
        /// </summary>
        private class WndStyle
        {
            public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
            public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
            public static readonly IntPtr HWND_TOP = new IntPtr(0);
            public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        }

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern bool SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            uint uFlags
            );

        /// <summary>
        /// 设置窗口样式
        /// </summary>
        /// <param name="Handle">窗口句柄</param>
        public void SetWindow(IntPtr Handle)
        {
            if (IsTop)
            {
                // 设置窗口置顶
                SetWindowPos(Handle, WndStyle.HWND_TOPMOST, 0, 0, 0, 0, 0x0002 | 0x0001);
            }
            else if (!IsTop)
            {
                // 取消窗口置顶
                SetWindowPos(Handle, WndStyle.HWND_NOTOPMOST, 0, 0, 0, 0, 0x0002 | 0x0001);
            }
            return;
        }
    }
}
