using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ClassManager_StudentCrack._Function
{
    class Window
    {
        public bool LastIsTop { get; set; } = true;         // 上一次置顶状态
        public bool IsTop { get; set; } = true;             // 请求置顶状态

        public bool IsDialog { get; set; } = false;         // 是否弹出对话框
        public List<int> InceptMytwnds = new List<int>();   // 需要拦截窗口计数
        public List<int> AllowMytwnds = new List<int>();    // 单次允许白名单

        private IntPtr[] HMytWnds = new IntPtr[5];          // 极域功能性窗口句柄数组
        public List<int> RunMytWnds = new List<int>();      // 极域功能性窗口统计计数

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

        /// <summary>
        /// 窗口大小和位置标志
        /// </summary>
        private enum SWPs
        {
            SWP_ASYNCWINDOWPOS  = 0x4000,
            SWP_DEFERERASE      = 0x2000,
            SWP_DRAWFRAME       = 0x0020,
            SWP_FRAMECHANGED    = 0x0020,
            SWP_HIDEWINDOW      = 0x0080,
            SWP_NOACTIVATE      = 0x0010,
            SWP_NOCOPYBITS      = 0x0100,
            SWP_NOMOVE          = 0x0002,
            SWP_NOOWNERZORDER   = 0x0200,
            SWP_NOREDRAW        = 0x0008,
            SWP_NOREPOSITION    = 0x0200,
            SWP_NOSENDCHANGING  = 0x0400,
            SWP_NOSIZE          = 0x0001,
            SWP_NOZORDER        = 0x0004,
            SWP_SHOWWINDOW      = 0x0040
        }

        /// <summary>
        /// 窗口显示状态
        /// </summary>
        private enum SWs
        {
            SW_FORCEMINIMIZE    = 11,
            SW_HIDE             = 0,
            SW_MAXIMIZE         = 3,
            SW_MINIMIZE         = 6,
            SW_RESTORE          = 9,
            SW_SHOW             = 5,
            SW_SHOWDEFAULT      = 10,
            SW_SHOWMAXIMIZED    = 3,
            SW_SHOWMINIMIZED    = 2,
            SW_SHOWMINNOACTIVE  = 7,
            SW_SHOWNA           = 8,
            SW_SHOWNOACTIVATE   = 4,
            SW_SHOWNORMAL       = 1
        }

        #region 导入函数

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SWPs uFlags);

        [DllImport("user32.dll", EntryPoint = "FindWindowA")]
        private static extern IntPtr FindWindow(string ClassName = null, string WindowName = null);

        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        private static extern bool ShowWindow(IntPtr hWnd, SWs nCmdShow);

        [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "IsIconic")]
        private static extern bool IsIconic(IntPtr hWnd);

        // [DllImport("Kernel32.dll", EntryPoint = "GetLastError")]
        // private static extern int GetLastError();

        #endregion

        /// <summary>
        /// 设置自身窗口样式
        /// </summary>
        /// <param name="Handle">窗口句柄</param>
        public void SetMyWindow(IntPtr Handle)
        {
            if (IsTop)
            {
                // 设置窗口置顶
                SetWindowPos(Handle, WndStyle.HWND_TOPMOST, 0, 0, 0, 0, SWPs.SWP_NOMOVE | SWPs.SWP_NOSIZE);
            }
            else if (!IsTop)
            {
                // 取消窗口置顶
                SetWindowPos(Handle, WndStyle.HWND_NOTOPMOST, 0, 0, 0, 0, SWPs.SWP_NOMOVE | SWPs.SWP_NOSIZE);
            }
            return;
        }

        public bool CheckMythwareWindow()
        {
            // HMytWnds[2] = FindWindow("notepad", null);

            HMytWnds[0] = FindWindow(null, "屏幕广播");
            HMytWnds[1] = FindWindow(null, "学生演示");
            HMytWnds[2] = FindWindow(null, "网络影院");
            HMytWnds[3] = FindWindow(null, "视频直播");
            HMytWnds[4] = FindWindow(null, "共享白板");
            for (int i = 0; i < HMytWnds.Length; i++)
            {
                if (AllowMytwnds.Contains(i))
                {
                    // 此窗口已 关闭或隐藏 非最小化状态
                    if (HMytWnds[i].Equals(IntPtr.Zero) && !IsWindowVisible(HMytWnds[i]) && !IsIconic(HMytWnds[i]))
                    {
                        AllowMytwnds.Remove(i);
                    }
                }

                // 不在单次白名单内
                else
                {
                    // 存在窗口 显示 非最小化状态
                    if (!HMytWnds[i].Equals(IntPtr.Zero) && IsWindowVisible(HMytWnds[i]) && !IsIconic(HMytWnds[i]))
                    {
                        RunMytWnds.Add(i);
                    }
                }
            }
            if (RunMytWnds.Count != 0)
            {
                return true;
            }
            return false;
        }

        public void SetMythwareWindow()
        {
            for (int i = 0; i < InceptMytwnds.Count; i++)
            {
                SetWindowPos(HMytWnds[InceptMytwnds[i]], WndStyle.HWND_NOTOPMOST, 0, 0, 0, 0, SWPs.SWP_NOMOVE | SWPs.SWP_NOSIZE | SWPs.SWP_NOSENDCHANGING);
                ShowWindow(HMytWnds[InceptMytwnds[i]], SWs.SW_FORCEMINIMIZE);
            }

            // 重置标志位
            IsDialog = false;
            RunMytWnds.Clear();
            InceptMytwnds.Clear();
            HMytWnds = new IntPtr[5];
        }
    }
}
