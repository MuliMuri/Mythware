using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace ClassManager_StudentCrack._Module
{
    class MemCore
    {
        //TODO: ?-重名多进程管理

        //TODO: 定时刷新
        [DllImport("kernel32.dll")]
        private static extern uint GetTickCount();
        private static void Delay(uint ms)
        {
            uint start = GetTickCount();
            while (GetTickCount() - start < ms)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }


        /// <summary>
        /// 进程管理类
        /// </summary>
        public class ProcessManager
        {
            public ProcessManager()
            {
                ThreadManager threadManager = new ThreadManager();
                threadManager.Add("CheckLive", CheckLive);
            }


            #region DllImport
            [DllImport("ntdll.dll")]
            private static extern uint NtResumeProcess([In] IntPtr processHandle);

            [DllImport("ntdll.dll")]
            private static extern uint NtSuspendProcess([In] IntPtr processHandle);

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool CloseHandle([In] IntPtr handle);
            #endregion

            /// <summary>
            /// 进程表
            /// </summary>
            Dictionary<string, ProcInfoTab> ProcTab = new Dictionary<string, ProcInfoTab>();

            /// <summary>
            /// 进程状态
            /// </summary>
            enum ProcState
            {
                Running,
                Stopping,
                Suspend
            }

            /// <summary>
            /// 进程表模板
            /// </summary>
            class ProcInfoTab
            {
                public string ProcName { get; set; }
                public int PID { get; set; }
                public IntPtr Handle { get; set; }
                public ProcState State { get; set; }
            }



            /// <summary>
            /// 向进程管理器添加进程
            /// </summary>
            /// <param name="ProcName">进程名</param>
            /// <param name="PID">进程PID</param>
            /// <returns>
            /// <para>True: 添加成功</para>
            /// <para>False: 进程不存在</para>
            /// </returns>
            public bool Add(string ProcName, int PID = 0)
            {
                // 填表
                ProcInfoTab Table = new ProcInfoTab();

                // Name
                Table.ProcName = ProcName;

                // PID & RunState & Handle
                GetPID:
                if (PID == 0)
                {
                    // 获取PID
                    Process[] process = Process.GetProcessesByName(ProcName);
                    if (process.Length == 0)
                    {
                        // 不存在进程
                        return false;
                    }
                    else
                    {
                        // 取第一位
                        PID = process[0].Id;
                        Table.State = ProcState.Running;
                        Table.Handle = process[0].Handle;
                    }
                }
                else
                {
                    // 判断是否存在进程
                    try
                    {
                        Process.GetProcessById(PID);
                        Table.State = ProcState.Running;
                    }
                    catch (ArgumentException)
                    {
                        PID = 0;
                        goto GetPID;
                    }
                }
                Table.PID = PID;

                ProcTab.Add(ProcName, Table);
                return true;
            }

            /// <summary>
            /// 从进程管理器删除进程
            /// </summary>
            /// <param name="ProcName">进程名</param>
            /// <param name="PID">进程PID</param>
            /// <returns>
            /// <para>True: 删除成功</para>
            /// <para>False: 进程不存在</para>
            /// </returns>
            public bool Remove(string ProcName, int PID = 0)
            {
                return ProcTab.Remove(ProcName);
            }

            /// <summary>
            /// 挂起指定进程
            /// </summary>
            /// <param name="ProcName">进程名</param>
            /// <param name="PID">进程PID</param>
            /// <returns>
            /// <para>True: 挂起成功</para>
            /// <para>False: 挂起失败</para>
            /// </returns>
            public bool Suspend(string ProcName, int PID = 0)
            {
                try
                {
                    IntPtr hProc = ProcTab[ProcName].Handle;
                    NtSuspendProcess(hProc);
                    CloseHandle(hProc);
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }

            /// <summary>
            /// 释放指定进程
            /// </summary>
            /// <param name="ProcName">进程名</param>
            /// <param name="PID">进程PID</param>
            /// <returns>
            /// <para>True: 释放成功</para>
            /// <para>False: 释放失败</para>
            /// </returns>
            public bool Resume(string ProcName, int PID = 0)
            {
                try
                {
                    IntPtr hProc = ProcTab[ProcName].Handle;
                    NtResumeProcess(hProc);
                    CloseHandle(hProc);
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }

            /// <summary>
            /// 结束指定进程
            /// </summary>
            /// <param name="ProcName">进程名</param>
            /// <param name="PID">进程PID</param>
            /// <param name="Suspend">是否挂起</param>
            /// <returns>
            /// <para>True: 结束成功</para>
            /// <para>False: 结束失败</para>
            /// </returns>
            public bool Kill(string ProcName, int PID = 0, bool Suspend = true)
            {
                try
                {
                    if (Suspend)
                    {
                        IntPtr hProc = ProcTab[ProcName].Handle;
                        NtResumeProcess(hProc);
                        CloseHandle(hProc);
                    }
                    Process.GetProcessById(PID).Kill();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }



            /// <summary>
            /// 检查进程管理器中进程是否存活
            /// </summary>
            private void CheckLive()
            {
                while (true)
                {
                    Delay(200);
                    // System.Windows.Forms.MessageBox.Show(ProcTab.Count.ToString());
                    ReStart:
                    try
                    {
                        foreach (var key in ProcTab.Keys)
                        {
                            try
                            {
                                _ = Process.GetProcessById(ProcTab[key].PID);
                            }
                            catch (ArgumentException)
                            {
                                ProcTab.Remove(key);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        goto ReStart;
                    }
                }
            }
        }

        /// <summary>
        /// 线程管理类
        /// </summary>
        public class ThreadManager
        {
            Dictionary<string, Thread> ThreTab = new Dictionary<string, Thread>();

            /// <summary>
            /// 向线程管理器添加线程
            /// </summary>
            /// <param name="Name">线程名</param>
            /// <param name="Function">
            /// <para>指向的函数</para>
            /// <para>注: 带参函数请用 void 包装</para>
            /// </param>
            /// <param name="Start">是否启动</param>
            /// <returns>
            /// <para>True: 添加成功</para>
            /// <para>False: 未知错误</para>
            /// </returns>
            public bool Add(string Name, Action Function, bool Start = true)
            {
                try
                {
                    Thread thread = new Thread(() => Function());
                    ThreTab.Add(Name, thread);
                    if (Start)
                    {
                        ThreTab[Name].Start();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
