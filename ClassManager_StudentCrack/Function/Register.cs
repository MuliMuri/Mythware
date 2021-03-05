using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManager_StudentCrack._Function
{
    class Register
    {
        private static string[] RegRootPath = new string[1]
        {
            "SOFTWARE\\{0}\\TopDomain\\e-Learning Class\\Student"
        };

        private static string Set6432NodePath(string Path)
        {
            // MessageBox.Show(IntPtr.Size.ToString());
            if (IntPtr.Size == 8)
            {
                // x64
                return string.Format(Path, "Wow6432Node");
            }
            else
            {
                // x86
                return string.Format(Path, "");
            }
        }

        public enum RegOperate
        {
            Password = 0
        }

        public static void ReadRegKey(RegOperate operate)
        {
            string RegPath;
            switch (operate)
            {
                case RegOperate.Password:
                    RegPath = RegRootPath[0];
                    RegPath = Set6432NodePath(RegPath);
                    byte[] RegData = (byte[])Registry.LocalMachine.OpenSubKey(RegPath).GetValue("Knock1");
                    List<byte> LPassword = new List<byte>();
                    List<byte> b = new List<byte>();
                    StringBuilder strb = new StringBuilder();
                    for (int i = 0; i < RegData.Length; i += 4)
                    {
                        byte[] data = BitConverter.GetBytes(BitConverter.ToUInt32(RegData, i) ^ 0x50434C45 ^ 0x454C4350);
                        for (int j = 0; j < data.Length; j++)
                        {
                            LPassword.Add(data[j]);
                        }
                    }
                    for (int i = 0; i < LPassword.Count; i++)
                    {
                        if ((LPassword[i] | LPassword[i+1]) != 0)
                        {
                            b.Add(LPassword[i]);
                        }
                        else
                        {
                            b.Add(0x00);
                            break;
                        }
                    }
                    string Password = Encoding.GetEncoding("UTF-8").GetString(b.ToArray()).Replace("\0", "");

                    //for (int i = 0; i < RegData.Length; i += 4)
                    //{
                    //    Password.Add(BitConverter.ToUInt32(RegData, i) ^ 0x50434c45 ^ 0x454c4350);
                    //}
                    //for (int i = 0; i < Password.Count; i++)
                    //{
                    //    byte[] byte4 = BitConverter.GetBytes(Password[i]);

                    //    for (int j = 0; j < byte4.Length; j++)
                    //    {
                    //        DecPassword.Add(byte4[j]);
                    //    }
                    //}
                    //DecPassword.Reverse();
                    //byte[] a = DecPassword.ToArray();
                    //for (int i = 0; i < a.Length; i++)
                    //{

                    //}
                    break;

                default:
                    break;
            }
        }
    }
}
