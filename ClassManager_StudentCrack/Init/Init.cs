using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack._Init
{
    class Init
    {
        public static bool GetMythwareRunState()
        {
            if (Process.GetProcessesByName("StudentMain").Length == 0)
                return false;
            return true;
        }
    }
}
