using System;
using System.Security;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ClassManager_StudentCrack._Module
{
    class TaskCore
    {
        //TODO: ?-重名多进程管理
        //TODO: for循环List列表
        //TODO: 封装常用函数


        /// <summary>
        /// 进程管理类
        /// </summary>
        public class ProcessManager
        {
            #region DllImport
            [DllImport("ntdll.dll")]
            private static extern uint NtResumeProcess([In] IntPtr processHandle);

            [DllImport("ntdll.dll")]
            private static extern uint NtSuspendProcess([In] IntPtr processHandle);

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool CloseHandle([In] IntPtr handle);
            #endregion



            public ProcessManager()
            {
                ThreadManager threadManager = new ThreadManager();
                threadManager.Add("ProcessManager_CheckLive", CheckLive, IsBackGround:true);
            }

            /// <summary>
            /// 进程表模板
            /// </summary>
            private class ProcInfoTab
            {
                public string ProcName { get; set; }
                public int PID { get; set; }
                public IntPtr Handle { get; set; }
                public ProcState State { get; set; }
            }

            /// <summary>
            /// 进程状态
            /// </summary>
            private enum ProcState
            {
                Running,
                Stopping,
                Suspend
            }

            /// <summary>
            /// 进程表
            /// </summary>
            Dictionary<string, List<ProcInfoTab>> ProcTab = new Dictionary<string, List<ProcInfoTab>>();


            /// <summary>
            /// 向进程管理器添加进程
            /// </summary>
            /// <param name="ProcName">进程名</param>
            /// <param name="PID">进程PID</param>
            /// <returns>
            /// <para>True: 添加成功</para>
            /// <para>False: 进程不存在 / 重复添加</para>
            /// </returns>
            public bool Add(string ProcName, int PID = 0)
            {
                if (!ProcTab.ContainsKey(ProcName))
                {
                    return false;
                }

                // 填表
                ProcInfoTab Table = new ProcInfoTab();

                List<ProcInfoTab> LTable = new List<ProcInfoTab>();

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

                LTable.Add(Table);

                ProcTab.Add(ProcName, LTable);
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
                    IntPtr hProc = ProcTab[ProcName][0].Handle;
                    NtSuspendProcess(hProc);
                    CloseHandle(hProc);
                    return true;
                }
                catch (KeyNotFoundException e)
                {
                    Loger.Error(string.Format("未在表中找到{0}进程,无法挂起", ProcName), e);
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
                    IntPtr hProc = ProcTab[ProcName][0].Handle;
                    NtResumeProcess(hProc);
                    CloseHandle(hProc);
                    return true;
                }
                catch (KeyNotFoundException e)
                {
                    Loger.Error(string.Format("未在表中找到{0}进程,无法释放", ProcName), e);
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
                        IntPtr hProc = ProcTab[ProcName][0].Handle;
                        NtResumeProcess(hProc);
                        CloseHandle(hProc);
                    }
                    Process.GetProcessById(PID).Kill();
                    return true;
                }
                catch (Exception e)
                {
                    Loger.Error(string.Format("无法获取正确进程PID[{0}]或句柄,结束进程失败", ProcName), e);
                    return false;
                }
            }


            #region EventDefine

            /// <summary>
            /// 进程退出事件
            /// </summary>
            public class ProcExitEventArgs : EventArgs
            {
                public string ProcName { get; }
                public int PID { get; }

                public ProcExitEventArgs(string ProcName, int PID)
                {
                    this.ProcName = ProcName;
                    this.PID = PID;
                }
            }

            /// <summary>
            /// 事件定义
            /// </summary>
            public event EventHandler<ProcExitEventArgs> ProcExit;

            #endregion

            /// <summary>
            /// 检查进程管理器中进程是否存活
            /// </summary>
            private void CheckLive()
            {
                while (true)
                {
                    Timer.Sleep(200);
                    // System.Windows.Forms.MessageBox.Show(ProcTab.Count.ToString());
                    ReStart:
                    try
                    {
                        foreach (var key in ProcTab.Keys)
                        {
                            try
                            {
                                ProcTab[key][0].Handle = Process.GetProcessById(ProcTab[key][0].PID).Handle;
                            }
                            catch (ArgumentException)
                            {
                                ProcExit(this, new ProcExitEventArgs(ProcTab[key][0].ProcName, ProcTab[key][0].PID));
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
            /// <summary>
            /// 线程表
            /// </summary>
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
            /// <param name="IsBackGround">是否为后台进程</param>
            /// <returns>
            /// <para>True: 添加成功</para>
            /// <para>False: 未知错误</para>
            /// </returns>
            public bool Add(string Name, Action Function, bool Start = true, bool IsBackGround = false)
            {
                try
                {
                    Thread thread = new Thread(() => Function())
                    {
                        Name = Name,
                        IsBackground = IsBackGround
                    };

                    ThreTab.Add(Name, thread);
                    if (Start)
                    {
                        ThreTab[Name].Start();
                    }
                    return true;
                }
                catch (KeyNotFoundException e)
                {
                    Loger.Error("内存空间不足", e);
                    return false;
                }
            }

            /// <summary>
            /// 从线程管理器中删除线程
            /// </summary>
            /// <param name="Name">进程名</param>
            /// <returns>
            /// <para>True: 删除成功</para>
            /// <para>False: 线程不存在</para>
            /// </returns>
            public bool Remove(string Name)
            {
                try
                {
                    ThreTab[Name].Abort();
                    ThreTab.Remove(Name);
                    return true;
                }
                catch (SecurityException e)
                {
                    Loger.Error("线程拒绝访问", e);
                }
                catch (ThreadStateException e)
                {
                    Loger.Error("线程状态错误", e);
                }
                catch (KeyNotFoundException e)
                {
                    Loger.Error(string.Format("线程队列中不存在 {0} 线程", Name), e);
                }

                return false;
            }

        }
    }
}
