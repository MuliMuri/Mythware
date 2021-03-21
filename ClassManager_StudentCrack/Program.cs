using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassManager_StudentCrack._NetWork;
using ClassManager_StudentCrack._Function;
using ClassManager_StudentCrack._Chat;
using ClassManager_StudentCrack._Init;
using ClassManager_StudentCrack._Module;

using System.Net;
using System.Diagnostics;

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
            try
            {
                Init();
                Test();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                Loger.MainThreadDied = true;
            }
            catch (Exception e)
            {
                Loger.Fatal("主进程崩溃", e);
                Loger.MainThreadDied = true;
            }
        }

        static void Init()
        {
            new Loger();
        }

        static void Test()
        {
            // Chat.SendMsg("123123你好", "172.168.214.2");
            // NetInfo.GetIPInfo("192.168.1.27", "255.255.255.240");
            // string[] a = new string[2];
            // a[0] = "172.168.1.1";
            // a[1] = "192.168.1.1";
            // 
            // int[] b = new int[2];
            // b[0] = 2000;
            // b[1] = 1111;
            // NetSocket.Chat chat = new NetSocket.Chat(a, b);
            // string a = Infos.LocalIP;
            // IPAddress[] ipArray;
            // ipArray = Dns.GetHostAddresses(Dns.GetHostName());
            // IPAddress localIp = ipArray.First(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            // Infos.NetWork.Test();
            // string a = Infos.NetWork.LocalIP;
            // DisMytServer.Test();
            // Window.SetMythwareWindow();
            // Process.GetProcessById(4);
            // MemCore.ProcessManager a = new MemCore.ProcessManager();
            // a.Add("Notepad");
            // a.Remove("a");
            // Window.WindowManager windowManager = new Window.WindowManager();
            // windowManager.Add("任务管理器");
            // windowManager.Add(null, null, default);
            // windowManager.Add(null, null, new IntPtr(0x00180CE8));
            // MemCore.ThreadManager threadManager = new MemCore.ThreadManager();
            // asd();
            // threadManager.Add("a", asd);
            // Logger logger = new Logger(Logger.Level.ALL);
            // logger.a = 1;
            // int a = 0;
            // int b = 3 / a;
            // Loger.Info("aa");
        }
    }
}
