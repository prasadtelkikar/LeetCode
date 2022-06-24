using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class LicenseKeyFormatting
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = Convert.ToInt32(Console.ReadLine());
            string output = FormatLicenseKey(input, length);
            Console.WriteLine(output);
        }

        //Partial succeed. 0th portion of key should be of length k
        private static string FormatLicenseKey(string s, int k)
        {
            var inputs = s.Replace("-", "").ToUpper();

            StringBuilder sb = new StringBuilder(inputs);
            int length = inputs.Length;
            for (int i = k; i < length; i+=k)
                sb.Insert(length-i, "-");

            return sb.ToString();
        }
    }
}
