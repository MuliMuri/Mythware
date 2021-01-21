using System;
using System.Net;
using System.Net.Sockets;

namespace ClassManager_StudentCrack.Com
{
    class ComSocket
    {
        private Socket socket;
        public ComSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            
        }
        public static bool SendMsg(string Msg)
        {


            return true;
        }
    }
}
