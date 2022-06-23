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
            var inputs = s.Split('-');
            List<string> output = new List<string>();
            output.Add(inputs[0].ToUpper());
            var remainingKey = string.Join("", inputs.Skip(1));
            for(int i = 0; i < remainingKey.Length; i += k)
            {
                string subString = "";
                if(i+k >= remainingKey.Length)
                    subString = remainingKey.Substring(i);
                else
                    subString = remainingKey.Substring(i, k);
                output.Add(subString.ToUpper());
            }
            return string.Join("-", output);
        }
    }
}
