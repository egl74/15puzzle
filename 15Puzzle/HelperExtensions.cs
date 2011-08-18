using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _15Puzzle
{
    public static class HelperExtensions
    {
        public static string ConvertZeroToEmpty(this int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }
            else
            {
                return number.ToString();
            }
        }

        // return a number between [0-max)
        public static int Random(this int max)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] randomByte = new byte[1];

            do provider.GetBytes(randomByte);
            while (!(randomByte[0] < max * (Byte.MaxValue / max)));

            return randomByte[0] % max;
        }
    }
}
