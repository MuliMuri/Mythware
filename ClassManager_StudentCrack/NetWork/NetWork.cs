using System.Net.NetworkInformation;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace ClassManager_StudentCrack._NetWork
{
    class NetWork
    {

        /// <summary>
        /// 获取网卡信息
        /// </summary>
        /// <param name="CardInfos">out 网卡信息数组</param>
        /// <returns>BOOL</returns>
        public static bool GetNetWorkCard(out List<Dictionary<string, string>> CardInfos)
        {
            try
            {
                List<Dictionary<string, string>> _CardInfos = new List<Dictionary<string, string>>();    // 网卡信息数组

                NetworkInterface[] _networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface Adapter in _networkInterfaces)
                {
                    #region NetCardType
                    string CardType = "未知网卡";   // 初始化默认网卡类型
                    string CardRegKey = string.Format(@"SYSTEM\CurrentControlSet\Control\Network\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\{0}\Connection", Adapter.Id);
                    RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(CardRegKey, false);
                    if (RegKey != null)
                    {
                        // 识别网卡类型
                        string PnpInstanceID = RegKey.GetValue("PnpInstanceID", "").ToString();
                        int MediaSubType = int.Parse(RegKey.GetValue("MediaSubType", 0).ToString());

                        // PnpInstanceID 前3位带 PCI 即为物理网卡
                        if (PnpInstanceID.Length > 3 && PnpInstanceID.Substring(0, 3) == "PCI")
                        {
                            CardType = "物理网卡";
                        }
                        // PnpInstanceID 第6位带 VMWARE 即为 VMware 虚拟网卡
                        else if (PnpInstanceID.Length > 11 && PnpInstanceID.Substring(5, 6) == "VMWARE")
                        {
                            CardType = "VMWare虚拟网卡";
                        }
                        else if (PnpInstanceID.Contains("vwifimp_wfd"))
                        {
                            CardType = "Microsoft Wi-Fi 直连虚拟适配器";
                        }

                        switch (MediaSubType)
                        {
                            case 2:
                                CardType = "无线网卡";
                                break;

                            case 7:
                                CardType = "蓝牙网卡";
                                break;

                            default:
                                break;
                        }

                        // 网卡信息打包
                        #region NetCardInfos
                        Dictionary<string, string> CardDict = new Dictionary<string, string>
                        {
                            { "Name", Adapter.Name }, // 网络适配器名称
                            { "CardType", CardType }, // 网卡类型
                            { "InterFaceType", Adapter.NetworkInterfaceType.ToString() }, // 网络接口类型
                            { "MAC", Adapter.GetPhysicalAddress().ToString() }  // MAC 地址
                        }; // 网卡信息字典

                        // 获取 IP 地址
                        IPInterfaceProperties _iPInterfaceProperties = Adapter.GetIPProperties();
                        UnicastIPAddressInformationCollection _unicastIPAddressInformationCollection = _iPInterfaceProperties.UnicastAddresses;
                        foreach (UnicastIPAddressInformation _unicastIPAddressInformation in _unicastIPAddressInformationCollection)
                        {
                            if (_unicastIPAddressInformation.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                CardDict.Add("IP", _unicastIPAddressInformation.Address.ToString());
                                CardDict.Add("Mask", _unicastIPAddressInformation.IPv4Mask.ToString());
                            }
                        }

                        _CardInfos.Add(CardDict);    // 封装进数组
                        #endregion
                    }
                    #endregion
                }
                CardInfos = _CardInfos;
                return true;
            }
            catch (Exception)
            {
                CardInfos = null;
                return false;
                throw;
            }
        }

        /// <summary>
        /// 获取ARP查询字符串
        /// </summary>
        /// <returns></returns>
        private static string GetARPResult()
        {
            Process p = null;
            string output = string.Empty;
            try
            {
                p = Process.Start(new ProcessStartInfo("arp", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                });
                output = p.StandardOutput.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception("IPInfo: Error Retrieving 'arp -a' Results", ex);
            }
            finally
            {
                if (p != null)
                {
                    p.Close();
                }
            }
            return output;
        }


        /// <summary>
        /// 获取IP地址与Mac地址对应数据表
        /// </summary>
        /// <returns>Mac-IP</returns>
        public static List<string[]> GetIPInfo()
        {
            try
            {
                var list = new List<string[]>();
                foreach (var arp in GetARPResult().Split(new char[] { '\n', '\r' }))
                {
                    if (!string.IsNullOrEmpty(arp))
                    {
                        var pieces = (from piece in arp.Split(new char[] { ' ', '\t' })
                                      where !string.IsNullOrEmpty(piece)
                                      select piece).ToArray();
                        if (pieces.Length == 3)
                        {
                            //pieces[1]Mac
                            //pieces[0]IP
                            list.Add(new string[2] { pieces[1], pieces[0] });
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("IPInfo: Error Parsing 'arp -a' results", ex);
            }
        }

        /// <summary>
        /// Mac地址转换为IP地址
        /// </summary>
        /// <param name="str">IP</param>
        /// <returns></returns>
        public static string GetIpFromMac(string str)
        {
            str = str.Trim().ToString().Replace(":", "-");
            var ipinfo = (from ip in GetIPInfo()
                          where ip[0].ToLowerInvariant() == str.ToLowerInvariant()
                          select ip[1]).FirstOrDefault();
            return ipinfo;
        }


        /// <summary>
        /// 获取本机所有ip地址
        /// </summary>
        /// <param name="netType">"InterNetwork":ipv4地址，"InterNetworkV6":ipv6地址</param>
        /// <returns>ip地址集合</returns>
        public static List<string> GetLocalIpAddress(string netType)
        {
            string hostName = Dns.GetHostName();                    //获取主机名称
            IPAddress[] addresses = Dns.GetHostAddresses(hostName); //解析主机IP地址

            List<string> IPList = new List<string>();
            if (netType == string.Empty)
            {
                for (int i = 0; i < addresses.Length; i++)
                {
                    IPList.Add(addresses[i].ToString());
                }
            }
            else
            {
                //AddressFamily.InterNetwork表示此IP为IPv4,
                //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                for (int i = 0; i < addresses.Length; i++)
                {
                    if (addresses[i].AddressFamily.ToString() == netType)
                    {
                        IPList.Add(addresses[i].ToString());
                    }
                }
            }
            return IPList;
        }
    }
}
