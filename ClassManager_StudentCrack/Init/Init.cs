using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ClassManager_StudentCrack._Function;

namespace ClassManager_StudentCrack._Init
{
    class Init
    {
        /// <summary>
        /// 极域电子教室 进程PID
        /// </summary>
        public static int ProcessID { get; set; }


        /// <summary>
        /// 初始化日志线程
        /// </summary>
        /// <param name="textBox">TextBox 对象实例</param>
        /// <returns>Thread 实例</returns>
        public static Thread SetLogClass(TextBox textBox)
        {
            Logs logs = new Logs(textBox);
            Thread thread = new Thread(new ParameterizedThreadStart(logs.WriteLog));
            return thread;
        }


        /// <summary>
        /// 获取 极域电子教室 运行状态
        /// </summary>
        /// <returns>BOOL</returns>
        public static bool GetMythwareRunState()
        {
            if (Process.GetProcessesByName("StudentMain").Length != 0)
            {

            }
            return false;
        }
    }
}
