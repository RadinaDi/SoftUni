using System;
using System.Linq;

namespace SeleniumAdvanced.Extensions
{
    public static class RandomExtensions
    {
        private const string Charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string NextString(this Random random, int length = -1)
        {
            length = (length == -1) ? random.Next(1, 1000) : length;
            var chars = Enumerable.Repeat(Charset, length).Select(s => s[random.Next(s.Length)]).ToArray();
            return new string(chars);
        }
    }
}
