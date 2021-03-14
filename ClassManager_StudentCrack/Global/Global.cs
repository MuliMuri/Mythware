using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassManager_StudentCrack._Module;

namespace ClassManager_StudentCrack._Global
{
    // 全局资源表
    class Global
    {
        public static string MythwareName { get; } = "StudentMain";


        public Window.WindowManager WindowManager { get; }
        
        public TaskCore.ProcessManager ProcessManager { get; }
        public TaskCore.ThreadManager ThreadManager { get; }




        private CheckResx checkResx;
        

        public Global()
        {
            this.WindowManager = new Window.WindowManager();
            
            this.ProcessManager = new TaskCore.ProcessManager();
            this.ThreadManager = new TaskCore.ThreadManager();


            this.checkResx = new CheckResx(this.ProcessManager);

            MyInit();
        }

        private void MyInit()
        {
            this.ThreadManager.Add("CheckResx", checkResx.CheckAll);
        }

        private class CheckResx
        {
            TaskCore.ProcessManager processManager;

            public CheckResx(TaskCore.ProcessManager ProcessManager)
            {
                this.processManager = ProcessManager;
            }

            /// <summary>
            /// 包装检查函数
            /// </summary>
            public void CheckAll()
            {
                if (Mythware())
                    processManager.Add(MythwareName);


            }

            /// <summary>
            /// 极域进程存活检查
            /// </summary>
            /// <returns>
            /// <para>True: 存活</para>
            /// <para>False: 死亡</para>
            /// </returns>
            private bool Mythware()
            {
                if (Process.GetProcessesByName(MythwareName).Length > 0)
                    return true;
                return false;
                    
            }
        }

    }
}
