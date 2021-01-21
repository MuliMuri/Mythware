using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack.Init
{
    class Infos
    {
        public static string LocalIP { get; } = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(p => p.AddressFamily.ToString() == "InterNetwork").ToString();
        // TODO: 修物理网卡bug
    }
}
