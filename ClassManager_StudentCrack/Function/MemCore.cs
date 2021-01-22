using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassManager_StudentCrack._Function
{
    class MemCore
    {
        public class ProcessManager
        {
            /// <summary>
            /// The process-specific access rights.
            /// </summary>
            [Flags()]
            public enum ProcessAccess : uint
            {
                /// <summary>
                /// Required to terminate a process using TerminateProcess.
                /// </summary>
                Terminate = 0x1,

                /// <summary>
                /// Required to create a thread.
                /// </summary>
                CreateThread = 0x2,

                /// <summary>
                /// Undocumented.
                /// </summary>
                SetSessionId = 0x4,

                /// <summary>
                /// Required to perform an operation on the address space of a process (see VirtualProtectEx and WriteProcessMemory).
                /// </summary>
                VmOperation = 0x8,

                /// <summary>
                /// Required to read memory in a process using ReadProcessMemory.
                /// </summary>
                VmRead = 0x10,

                /// <summary>
                /// Required to write to memory in a process using WriteProcessMemory.
                /// </summary>
                VmWrite = 0x20,

                /// <summary>
                /// Required to duplicate a handle using DuplicateHandle.
                /// </summary>
                DupHandle = 0x40,

                /// <summary>
                /// Required to create a process.
                /// </summary>
                CreateProcess = 0x80,

                /// <summary>
                /// Required to set memory limits using SetProcessWorkingSetSize.
                /// </summary>
                SetQuota = 0x100,

                /// <summary>
                /// Required to set certain information about a process, such as its priority class (see SetPriorityClass).
                /// </summary>
                SetInformation = 0x200,

                /// <summary>
                /// Required to retrieve certain information about a process, such as its token, exit code, and priority class (see OpenProcessToken, GetExitCodeProcess, GetPriorityClass, and IsProcessInJob).
                /// </summary>
                QueryInformation = 0x400,

                /// <summary>
                /// Undocumented.
                /// </summary>
                SetPort = 0x800,

                /// <summary>
                /// Required to suspend or resume a process.
                /// </summary>
                SuspendResume = 0x800,

                /// <summary>
                /// Required to retrieve certain information about a process (see QueryFullProcessImageName). A handle that has the PROCESS_QUERY_INFORMATION access right is automatically granted PROCESS_QUERY_LIMITED_INFORMATION.
                /// </summary>
                QueryLimitedInformation = 0x1000,

                /// <summary>
                /// Required to wait for the process to terminate using the wait functions.
                /// </summary>
                Synchronize = 0x100000
            }


            // 导出函数
            [DllImport("ntdll.dll")]
            private static extern uint NtResumeProcess([In] IntPtr processHandle);

            [DllImport("ntdll.dll")]
            private static extern uint NtSuspendProcess([In] IntPtr processHandle);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr OpenProcess(
                ProcessAccess desiredAccess,
                bool inheritHandle,
                int processId);

            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool CloseHandle([In] IntPtr handle);


            /// <summary>
            /// 挂起进程
            /// </summary>
            /// <param name="processID">进程PID</param>
            public static void SuspendProcess(int ProcessID)
            {
                IntPtr hProc = IntPtr.Zero;
                try
                {
                    // 获取进程句柄
                    hProc = OpenProcess(ProcessAccess.SuspendResume, false, ProcessID);
                    if (hProc != IntPtr.Zero)
                        NtSuspendProcess(hProc);
                }
                finally
                {
                    // 关闭进程句柄
                    if (hProc != IntPtr.Zero)
                        CloseHandle(hProc);
                }
            }


            /// <summary>
            /// 释放进程
            /// </summary>
            /// <param name="ProcessID"></param>
            public static void ResumeProcess(int ProcessID)
            {
                IntPtr hProc = IntPtr.Zero;
                try
                {
                    // 获取进程句柄
                    hProc = OpenProcess(ProcessAccess.SuspendResume, false, ProcessID);
                    if (hProc != IntPtr.Zero)
                        NtResumeProcess(hProc);
                }
                finally
                {
                    // 关闭进程句柄
                    if (hProc != IntPtr.Zero)
                        CloseHandle(hProc);
                }
            }


            /// <summary>
            /// 杀死进程
            /// </summary>
            /// <param name="PID">进程PID</param>
            /// <param name="Suspend">是否挂起进程</param>
            /// <returns>BOOL</returns>
            public static bool KillProcess(int PID, bool Suspend)
            {
                try
                {
                    if (Suspend)
                    {
                        SuspendProcess(PID);
                    }
                    Process.GetProcessById(PID).Kill();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}
