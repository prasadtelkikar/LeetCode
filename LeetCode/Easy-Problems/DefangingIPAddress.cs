using System;
using System.Text;

namespace Easy_Problems
{
    public class DefangingIPAddress
    {
        public static void Main(string[] args)
        {
            var inputStr = Console.ReadLine();
            var outputStr = DefangIPaddr(inputStr);
            Console.WriteLine(outputStr);
        }

        private static string DefangIPaddr(string inputStr)
        {
            var splitted = inputStr.Split('.');
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var str in splitted)
            {
                if(count != splitted.Length)
                    sb.Append($"{str}[.]");
                else
                    sb.Append(str);
                count = count + 1;
            }
            return sb.ToString();
        }

        private static string DefangIPaddrLinq(string address)
        {
            return string.Join("[.]", address.Split('.'));
        }
    }
}
