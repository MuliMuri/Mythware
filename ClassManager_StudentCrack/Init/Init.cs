using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack.Init
{
    class _Init
    {
        public static bool GetMythwareRunState()
        {
            if (Process.GetProcessesByName("StudentMain").Length == 0)
                return false;
            return true;
        }
    }
}
