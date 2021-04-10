using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private static void GetPassword()
        {
            RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TopDomain\e-Learning Class\Student", false);
            byte[] Knock = (byte[])Key.GetValue("Knock1");
            if (Knock == null || Knock.Length % 4 != 0)
            {
                Console.WriteLine("error");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < Knock.Length; i += 4)
            {
                Knock[i + 0] = (byte)(Knock[i + 0] ^ 0x50 ^ 0x45);
                Knock[i + 1] = (byte)(Knock[i + 1] ^ 0x43 ^ 0x4c);
                Knock[i + 2] = (byte)(Knock[i + 2] ^ 0x4c ^ 0x43);
                Knock[i + 3] = (byte)(Knock[i + 3] ^ 0x45 ^ 0x50);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (uint i = Knock[0]; i < Knock.Length; i += 2)
            {
                if (Knock[i] == 0)
                {
                    // '\0' 结尾符直接跳出
                    break;
                }

                byte[] a = new byte[1]
                {
                    Knock[i]
                };

                stringBuilder.Append(Encoding.ASCII.GetString(a));
            }
            Console.WriteLine(stringBuilder);
            Console.ReadKey();
        }

        private static void SetPassword(string Password)
        {
            Password += "\0";

            List<byte> data = new List<byte>();
            byte[] uPwd = Encoding.Unicode.GetBytes(Password);

            for (int i = 0; i < uPwd.Length; i++)
            {
                data.Add(uPwd[i]);
            }
            

            if (data.Count % 4 != 2)
            {
                while (true)
                {
                    if (data.Count % 4 == 2)
                    {
                        break;
                    }
                    data.Add(0);
                }
            }
            data.Insert(0, 1);
            data.Add(1);
            for (int i = 0; i < data.Count; i += 4)
            {
                data[i + 0] = (byte)(data[i + 0] ^ 0x45 ^ 0x50);
                data[i + 1] = (byte)(data[i + 1] ^ 0x4c ^ 0x43);
                data[i + 2] = (byte)(data[i + 2] ^ 0x43 ^ 0x4c);
                data[i + 3] = (byte)(data[i + 3] ^ 0x50 ^ 0x45);
            }

            RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TopDomain\e-Learning Class\Student", true);
            byte[] a = data.ToArray();
            Key.SetValue("Knock1", a);

            Console.WriteLine("Write OK");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("指令(1 - 写; 非1 - 读): ");
                string inst = Console.ReadLine();
                if (inst == "1")
                {
                    SetPassword(Console.ReadLine());
                }
                else
                {
                    GetPassword();
                }
            }
        }
    }
}
