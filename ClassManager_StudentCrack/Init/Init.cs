using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ClassManager_StudentCrack._Global;

namespace ClassManager_StudentCrack._Init
{
    class Init
    {
        public Global Global { get; }
        public Init()
        {
            Global = new Global();
        }



        /// <summary>
        /// 获取 极域电子教室 运行状态
        /// </summary>
        /// <returns>BOOL</returns>
        public static bool GetMythwareRunState()
        {
            if (Process.GetProcessesByName("StudentMain").Length == 0)
                return false;
            return true;
        }
    }
}
