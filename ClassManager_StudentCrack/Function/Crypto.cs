using System;
using System.Security.Cryptography;
using System.Text;

namespace ClassManager_StudentCrack._Function
{
    internal class Crypto
    {
        public static class MyRandom
        {
            /// <summary>
            /// 获取32位随机Hex
            /// </summary>
            /// <returns></returns>
            public static int[] Get32RandomNum()
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                Random random = new Random();
                int[] RandomHex = new int[16];
                int Seed;

                Seed = random.Next(0, 100);
                byte[] ByteRandom = md5.ComputeHash(Encoding.Unicode.GetBytes(Seed.ToString()));
                for (int i = 0; i < ByteRandom.Length; i++)
                {
                    RandomHex[i] = int.Parse(ByteRandom[i].ToString("x"), System.Globalization.NumberStyles.HexNumber);
                }

                return RandomHex;
            }
        }
    }
}
