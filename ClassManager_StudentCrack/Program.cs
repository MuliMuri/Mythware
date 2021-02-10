using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassManager_StudentCrack._NetWork;
using ClassManager_StudentCrack._Function;
using ClassManager_StudentCrack._Chat;

namespace ClassManager_StudentCrack
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Test();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void Test()
        {
            // Chat.SendMsg("123123你好", "172.168.214.2");
            // NetInfo.GetIPInfo("192.168.1.27", "255.255.255.240");
        }
    }
}
