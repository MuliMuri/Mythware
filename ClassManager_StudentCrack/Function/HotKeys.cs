using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClassManager_StudentCrack._Function
{
    /// <summary>
    /// 热键定义
    /// </summary>
    internal class HotKeys
    {
        // 全局热键
        public class Global
        {
            // 辅助键定义
            [Flags()]
            public enum KeyModifiers
            {
                None = 0,
                Alt = 1,
                Ctrl = 2,
                Shift = 4,
                Win = 8,
            }

            // 全局自定义热键表
            public class HotKeyIDs
            {
                public const int WindowTop = 1000;
            }

            public class Win
            {
                // 导出 注册全局热键 函数
                [DllImport("user32.dll", SetLastError = true)]
                private static extern bool RegisterHotKey(IntPtr hWnd, int ID, KeyModifiers fsModifiers, Keys vk);

                // 导出 卸载全局热键 函数
                [DllImport("user32.dll", SetLastError = true)]
                private static extern bool UnregisterHotKey(IntPtr hWnd, int ID);

                /// <summary>
                /// 注册全局热键
                /// </summary>
                /// <param name="hWnd">窗口句柄</param>
                /// <param name="ID">热键ID</param>
                /// <param name="fsModifiers">标识辅助键</param>
                /// <param name="vk">热键内容</param>
                /// <returns>BOOL</returns>
                public static bool RegHotKey(IntPtr hWnd, int ID, KeyModifiers fsModifiers, Keys vk)
                {
                    return RegisterHotKey(hWnd, ID, fsModifiers, vk);
                }

                /// <summary>
                /// 卸载全局热键
                /// </summary>
                /// <param name="hWnd">窗口句柄</param>
                /// <param name="ID">热键ID</param>
                /// <returns>BOOL</returns>
                public static bool UnRegHotKey(IntPtr hWnd, int ID)
                {
                    return UnregisterHotKey(hWnd, ID);
                }
            }
        }

        // 窗口局部热键
        public class Form
        {
            // 聊天窗口热键
            public class Chat
            {
                /// <summary>
                /// 发送信息
                /// <para>热键：Ctrl + Enter</para>
                /// </summary>
                /// <param name="e">键盘事件</param>
                public static void Key_SendMsg(KeyEventArgs e)
                {
                    if (e.Control && e.KeyCode == Keys.Enter)
                    {
                        // 发送热键
                        // MessageBox.Show("send");

                        // TODO: 可选 发送信息热键
                    }
                }
            }
        }
    }
}
