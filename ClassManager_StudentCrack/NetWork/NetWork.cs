using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack.NetWork
{
    class NetWork
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        public static bool GetConState()
        {
            return InternetGetConnectedState(out _, 0);
        }
    }
}
