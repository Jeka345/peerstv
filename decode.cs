using System;
using System.Text;

namespace WpfApp1
{
    internal class decode
    {
        public static string DecodeBase128(string input)
        {
            return Encoding.UTF32.GetString(Convert.FromBase64String(input));
        }
    }
}