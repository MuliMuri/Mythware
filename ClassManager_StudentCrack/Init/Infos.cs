using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack._Init
{
    class Infos
    {
        public static class NetWork
        {
            /// <summary>
            /// 获取 UDP 表
            /// </summary>
            /// <param name="pUdpTable">指向表结构的指针</param>
            /// <param name="dwOutBufLen">结构估计大小</param>
            /// <param name="sort">是否排序</param>
            /// <param name="ipVersion">IP 版本</param>
            /// <param name="tblClass">UDP 表结构类型</param>
            /// <param name="reserved">保留 必须为0</param>
            /// <returns></returns>
            [DllImport("iphlpapi.dll", SetLastError = true)]
            private static extern uint GetExtendedUdpTable(IntPtr pUdpTable, ref int dwOutBufLen, bool sort, int ipVersion, UDP_TABLE_CLASS tblClass, uint reserved = 0);

            #region UDP结构

            /// <summary>
            /// UDP 枚举类型
            /// </summary>
            private enum UDP_TABLE_CLASS
            {
                UDP_TABLE_BASIC = 0,
                UDP_TABLE_OWNER_PID = 1,
                UDP_TABLE_OWNER_MODULE = 2
            }

            /// <summary>
            /// UDP 表结构
            /// </summary>
            [StructLayout(LayoutKind.Sequential)]
            private struct UDPTable
            {
                /// <summary>
                /// 元素数量
                /// </summary>
                public uint dwNumEntries;

                /// <summary>
                /// 指向 UDPRow 的指针
                /// </summary>
                UDPRow table;
            }

            /// <summary>
            /// UDP 结构
            /// </summary>
            [StructLayout(LayoutKind.Sequential)]
            public struct UDPRow
            {
                private uint dwLocalAddr;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
                private byte[] dwLocalPort;
                private int dwOwningPid;

                /// <summary>
                /// 本地IP
                /// </summary>
                public IPAddress LocalAddress { get { return new IPAddress(dwLocalAddr); } }

                /// <summary>
                /// 本地端口
                /// </summary>
                public ushort LocalPort { get { return BitConverter.ToUInt16(new byte[2] { dwLocalPort[1], dwLocalPort[0] }, 0); } }

                /// <summary>
                /// 进程PID
                /// </summary>
                public int PID { get { return dwOwningPid; } }
            }

            #endregion

            /// <summary>
            /// 获取所有 UDP 连接对象
            /// </summary>
            /// <returns></returns>
            private static UDPRow[] GetAllUdpConnections()
            {
                UDPRow[] tTable;
                int AF_INET = 2;    // IPv4
                int buffSize = 0;
                GetExtendedUdpTable(IntPtr.Zero, ref buffSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID); // 获取 buffsize 大小
                IntPtr buffTable = Marshal.AllocHGlobal(buffSize);
                try
                {
                    uint ret = GetExtendedUdpTable(buffTable, ref buffSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID);
                    if (ret != 0)
                    {
                        return null;
                    }
                    UDPTable tab = (UDPTable)Marshal.PtrToStructure(buffTable, typeof(UDPTable));
                    IntPtr rowPtr = (IntPtr)((long)buffTable + Marshal.SizeOf(tab.dwNumEntries));
                    tTable = new UDPRow[tab.dwNumEntries];
                    
                    for (int i = 0; i<tab.dwNumEntries; i++)
                    {
                        UDPRow udpRow = (UDPRow)Marshal.PtrToStructure(rowPtr, typeof(UDPRow));
                        tTable[i] = udpRow;
                        rowPtr = (IntPtr) ((long) rowPtr + Marshal.SizeOf(udpRow));   // next entry
                    }
                }
                finally
                {
                    Marshal.FreeHGlobal(buffTable);
                }
                return tTable;
            }

            /// <summary>
            /// 获取特定 UDP 连接对象
            /// </summary>
            /// <param name="PID">进程 PID</param>
            /// <returns></returns>
            private static List<UDPRow> GetSpecUDPConnection(int PID)
            {
                int AF_INET = 2;    // IPv4
                int BuffSize = 0;   // 缓冲区大小
                List<UDPRow> Target = new List<UDPRow>();

                GetExtendedUdpTable(IntPtr.Zero, ref BuffSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID); // 获取 BuffSize 大小
                IntPtr Buffer = Marshal.AllocHGlobal(BuffSize);    // 分配内存空间
                try
                {
                    if (GetExtendedUdpTable(Buffer, ref BuffSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID) != 0)
                    {
                        return null;
                    }
                    UDPTable udpTable = (UDPTable)Marshal.PtrToStructure(Buffer, typeof(UDPTable));
                    IntPtr RowPtr = (IntPtr)((long)Buffer + Marshal.SizeOf(udpTable.dwNumEntries));

                    for (int i = 0; i < udpTable.dwNumEntries; i++)
                    {
                        UDPRow udpRow = (UDPRow)Marshal.PtrToStructure(RowPtr, typeof(UDPRow));
                        if (udpRow.PID == PID)
                        {
                            Target.Add(udpRow);
                        }
                        RowPtr = (IntPtr)((long)RowPtr + Marshal.SizeOf(udpRow));   // next entry
                    }
                }
                finally
                {
                    Marshal.FreeHGlobal(Buffer);
                }
                return Target;
            }





            public static string LocalIP { get; } = GetSpecUDPConnection(Init.ProcessID)[0].LocalAddress.ToString();
        }
    }
}
