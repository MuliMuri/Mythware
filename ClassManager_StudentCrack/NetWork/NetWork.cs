using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Text;
using System;
using System.Collections.Generic;

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
    }
}
