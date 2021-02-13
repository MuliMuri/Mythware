using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace ClassManager_StudentCrack._NetWork
{
    /// <summary>
    /// 封装 Socket
    /// </summary>
    class NetSocket
    {
        /// <summary>
        /// 聊天用 Socket
        /// </summary>
        public class Chat
        {            
            private List<IPEndPoint> IPEnds = new List<IPEndPoint>();
            private readonly Socket UDPSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            
            /// <summary>
            /// 单目标
            /// </summary>
            public Chat(string IP, int Port)
            {
                IPEnds.Add(new IPEndPoint(IPAddress.Parse(IP), Port));
            }

            /// <summary>
            /// 多目标
            /// </summary>
            public Chat(string[] IP, int[] Port)
            {
                for (int i = 0; i < IP.Length; i++)
                {
                    IPEnds.Add(new IPEndPoint(IPAddress.Parse(IP[i]), Port[i]));
                }
            }

            /// <summary>
            /// 信息发送
            /// </summary>
            /// <param name="ChatData">信息内容</param>
            /// <returns></returns>
            public bool MsgSend(byte[] ChatData)
            {
                try
                {
                    for (int i = 0; i < IPEnds.Count; i++)
                    {
                        UDPSocket.SendTo(ChatData, SocketFlags.None, IPEnds[i]);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}
