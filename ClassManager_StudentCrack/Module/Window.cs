using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ClassManager_StudentCrack._Module
{
    class Window
    {
        /// <summary>
        /// 窗口管理类
        /// </summary>
        public class WindowManager
        {
            #region DllImport

            [DllImport("user32.dll", EntryPoint = "IsWindow")]
            private static extern bool IsWindow(IntPtr hWnd);

            [DllImport("user32.dll", EntryPoint = "FindWindowA")]
            private static extern IntPtr FindWindow(string ClassName = null, string WindowName = null);

            [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthA")]
            private static extern int GetWindowTextLength(IntPtr hWnd);

            [DllImport("user32.dll", EntryPoint = "GetWindowTextA")]
            private static extern int GetWindowText(IntPtr hWnd, StringBuilder Title, int Length);

            [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
            private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

            [DllImport("user32.dll", EntryPoint = "GetWindowLongA")]
            private static extern long GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll", EntryPoint = "ShowWindow")]
            private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
            private static extern bool IsWindowVisible(IntPtr hWnd);

            [DllImport("user32.dll", EntryPoint = "IsIconic")]
            private static extern bool IsIconic(IntPtr hWnd);

            [DllImport("Kernel32.dll", EntryPoint = "GetLastError")]
            private static extern int GetLastError();

            #endregion

            /// <summary>
            /// 窗口表
            /// </summary>
            Dictionary<string, WndInfoTab> WndTab = new Dictionary<string, WndInfoTab>();

            /// <summary>
            /// 窗口表模板
            /// </summary>
            class WndInfoTab
            {
                public string Title { get; set; }
                public IntPtr Handle { get; set; }
                public long Style { get; set; }
                public long ExStyle { get; set; }
                public bool IsTop { get; set; } = false;
            }

            /// <summary>
            /// 窗口显示状态
            /// </summary>
            public enum SW
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

            /// <summary>
            /// 窗口大小和位置标志
            /// </summary>
            public enum SWP
            {
                SWP_ASYNCWINDOWPOS = 0x4000,
                SWP_DEFERERASE = 0x2000,
                SWP_DRAWFRAME = 0x0020,
                SWP_FRAMECHANGED = 0x0020,
                SWP_HIDEWINDOW = 0x0080,
                SWP_NOACTIVATE = 0x0010,
                SWP_NOCOPYBITS = 0x0100,
                SWP_NOMOVE = 0x0002,
                SWP_NOOWNERZORDER = 0x0200,
                SWP_NOREDRAW = 0x0008,
                SWP_NOREPOSITION = 0x0200,
                SWP_NOSENDCHANGING = 0x0400,
                SWP_NOSIZE = 0x0001,
                SWP_NOZORDER = 0x0004,
                SWP_SHOWWINDOW = 0x0040
            }

            /// <summary>
            /// Z方向样式
            /// </summary>
            public enum ZStyle
            {
                HWND_BOTTOM,
                HWND_NOTOPMOST,
                HWND_TOP,
                HWND_TOPMOST
            }

            /// <summary>
            /// 获取窗口样式标志
            /// </summary>
            enum GWL
            {
                GWL_EXSTYLE = -20,
                GWL_STYLE = -16
            }

            /// <summary>
            /// Z方向句柄
            /// </summary>
            private IntPtr[] HWNDPos = new IntPtr[4]
            {
                new IntPtr(1),
                new IntPtr(-2),
                new IntPtr(0),
                new IntPtr(-1)
            };



            /// <summary>
            /// 向窗口管理器添加窗口
            /// </summary>
            /// <param name="Title">窗口标题</param>
            /// <param name="ClassName">窗口类名</param>
            /// <param name="hWnd">窗口句柄</param>
            /// <returns>
            /// <para>True: 添加成功</para>
            /// <para>False: 未找到窗口</para>
            /// </returns>
            public bool Add(string Title = null, string ClassName = null, IntPtr hWnd = new IntPtr())
            {
                // 填表
                WndInfoTab Table = new WndInfoTab();

                // Title & Handle
                GetHandle:
                if (hWnd == IntPtr.Zero)
                {
                    // 未指定Handle

                    if ((Title == null) && (ClassName == null))
                    {
                        // 啥参数都没获取个der
                        return false;
                    }
                    // 获取窗口句柄
                    IntPtr Handle = FindWindow(ClassName, Title);
                    if (Handle == IntPtr.Zero)
                    {
                        // 不存在窗口
                        return false;
                    }
                    else
                    {
                        // 获取信息
                        int Len = GetWindowTextLength(Handle) + 1;  // 标题长度
                        StringBuilder builder = new StringBuilder(Len);
                        GetWindowText(Handle, builder, Len);
                        if (builder.Length == 0)
                        {
                            return false;
                        }

                        Title = builder.ToString();
                        hWnd = Handle;
                    }
                }
                else
                {
                    // 指定Handle

                    // 判断是否存在窗口
                    if (!IsWindow(hWnd))
                    {
                        goto GetHandle;
                    }

                    // 获取 Title
                    // 获取信息
                    int Len = GetWindowTextLength(hWnd) + 1;  // 标题长度
                    StringBuilder builder = new StringBuilder(Len);
                    GetWindowText(hWnd, builder, Len);

                    Title = builder.ToString();
                }

                // Title
                Table.Title = Title;

                // Handle
                Table.Handle = hWnd;

                // Sytle & ExStyle
                Table.Style = GetWindowLong(hWnd, (int)GWL.GWL_STYLE);
                Table.ExStyle = GetWindowLong(hWnd, (int)GWL.GWL_EXSTYLE);

                // IsTop
                if ((Table.ExStyle & 0x00000008L) != 0)
                {
                    Table.IsTop = true;
                }

                WndTab.Add(Title, Table);

                return true;
            }

            /// <summary>
            /// 更改指定窗口样式
            /// </summary>
            /// <param name="Title">窗口标题</param>
            /// <param name="ZStyle">Z方向排序</param>
            /// <param name="SWP">
            /// <para>窗口大小和位置标志</para>
            /// <para>注: 若使用 ZStyle, 则必须赋值此参数</para>
            /// </param>
            /// <param name="SW">窗口显示状态</param>
            /// <returns></returns>
            public bool ChangeWindow(string Title, ZStyle ZStyle = 0, SWP SWP = 0, SW SW = 0)
            {
                try
                {
                    IntPtr hWnd = WndTab[Title].Handle;
                    if (ZStyle != 0)
                    {
                        SetWindowPos(hWnd, HWNDPos[(int)ZStyle], 0, 0, 0, 0, (uint)SWP);
                    }
                    if (SW != 0)
                    {
                        ShowWindow(hWnd, (int)SW);
                    }
                }
                catch (KeyNotFoundException)
                {
                    return false;
                    throw;
                }
                return true;
            }

            /// <summary>
            /// 置顶指定窗口
            /// </summary>
            /// <param name="Title">窗口标题</param>
            /// <returns></returns>
            public bool TopWindow(string Title)
            {
                return ChangeWindow(Title, ZStyle.HWND_TOPMOST, SWP.SWP_NOMOVE | SWP.SWP_NOSIZE);
            }
        }




















        public bool LastIsTop { get; set; } = true;         // 上一次置顶状态
        public bool IsTop { get; set; } = true;             // 请求置顶状态

        public bool IsDialog { get; set; } = false;         // 是否弹出对话框
        public List<int> InceptMytwnds = new List<int>();   // 需要拦截窗口计数
        public List<int> AllowMytwnds = new List<int>();    // 单次允许白名单

        private IntPtr[] HMytWnds = new IntPtr[5];          // 极域功能性窗口句柄数组
        public List<int> RunMytWnds = new List<int>();      // 极域功能性窗口统计计数

        



































        /// <summary>
        /// 设置自身窗口样式
        /// </summary>
        /// <param name="Handle">窗口句柄</param>
        public void SetMyWindow(IntPtr Handle)
        {
            //if (IsTop)
            //{
            //    // 设置窗口置顶
            //    SetWindowPos(Handle, WndStyle.HWND_TOPMOST, 0, 0, 0, 0, SWPs.SWP_NOMOVE | SWPs.SWP_NOSIZE);
            //}
            //else if (!IsTop)
            //{
            //    // 取消窗口置顶
            //    SetWindowPos(Handle, WndStyle.HWND_NOTOPMOST, 0, 0, 0, 0, SWPs.SWP_NOMOVE | SWPs.SWP_NOSIZE);
            //}
            //return;
        }

        public bool CheckMythwareWindow()
        {
            //// HMytWnds[2] = FindWindow("notepad", null);

            //HMytWnds[0] = FindWindow(null, "屏幕广播");
            //HMytWnds[1] = FindWindow(null, "学生演示");
            //HMytWnds[2] = FindWindow(null, "网络影院");
            //HMytWnds[3] = FindWindow(null, "视频直播");
            //HMytWnds[4] = FindWindow(null, "共享白板");
            //for (int i = 0; i < HMytWnds.Length; i++)
            //{
            //    if (AllowMytwnds.Contains(i))
            //    {
            //        // 此窗口已 关闭或隐藏 非最小化状态
            //        if (HMytWnds[i].Equals(IntPtr.Zero) && !IsWindowVisible(HMytWnds[i]) && !IsIconic(HMytWnds[i]))
            //        {
            //            AllowMytwnds.Remove(i);
            //        }
            //    }

            //    // 不在单次白名单内
            //    else
            //    {
            //        // 存在窗口 显示 非最小化状态
            //        if (!HMytWnds[i].Equals(IntPtr.Zero) && IsWindowVisible(HMytWnds[i]) && !IsIconic(HMytWnds[i]))
            //        {
            //            RunMytWnds.Add(i);
            //        }
            //    }
            //}
            //if (RunMytWnds.Count != 0)
            //{
            //    return true;
            //}
            //return false;
            return true;
        }

        public void SetMythwareWindow()
        {
            //for (int i = 0; i < InceptMytwnds.Count; i++)
            //{
            //    SetWindowPos(HMytWnds[InceptMytwnds[i]], WndStyle.HWND_NOTOPMOST, 0, 0, 0, 0, SWPs.SWP_NOMOVE | SWPs.SWP_NOSIZE | SWPs.SWP_NOSENDCHANGING);
            //    ShowWindow(HMytWnds[InceptMytwnds[i]], SWs.SW_FORCEMINIMIZE);
            //}

            //// 重置标志位
            //IsDialog = false;
            //RunMytWnds.Clear();
            //InceptMytwnds.Clear();
            //HMytWnds = new IntPtr[5];
        }
    }
}
