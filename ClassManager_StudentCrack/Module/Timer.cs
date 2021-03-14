using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManager_StudentCrack._Module
{
    class Timer
    {
        public delegate void TimerCompleteDelegate();

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateWaitableTimer(IntPtr lpTimerAttributes, bool bManualReset, string lpTimerName);

        [DllImport("kernel32.dll")]
        static extern bool SetWaitableTimer(IntPtr hTimer, [In] ref long ft, int lPeriod, TimerCompleteDelegate pfnCompletionRoutine, IntPtr pArgToCompletionRoutine, bool fResume);

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("User32.dll")]
        static extern int MsgWaitForMultipleObjects(int nCount, ref IntPtr handle, bool fWaitAll, int dwMilliseconds, int dwWakeMask);


        /// <summary>
        /// 延迟
        /// </summary>
        /// <param name="time">单位毫秒</param>
        public static bool Sleep(int time)
        {
            TimerCompleteDelegate TimerComplete = new TimerCompleteDelegate(TimerCompleted);
            long Interval = -10 * time * 1000;//占8字节
            //创建计时器
            IntPtr handle = CreateWaitableTimer(IntPtr.Zero, true, "WaitableTimer");
            SetWaitableTimer(handle, ref Interval, 0, TimerComplete, IntPtr.Zero, true);
            //等待消息抵达
            while (MsgWaitForMultipleObjects(1, ref handle, false, -1, 255) != 0)
            {
                //转让权限
                Application.DoEvents();
            }
            return CloseHandle(handle);
        }
        private static void TimerCompleted()
        {
            // 一旦定时器过期，就执行例程。这是独立于调用OnTimeRebug事件的类实现的程序执行的。
        }
    }
}
