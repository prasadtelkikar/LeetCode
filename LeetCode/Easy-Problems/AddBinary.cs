using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class AddBinary
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            string result = AddBinaryFunc(a, b);
            Console.WriteLine(result);
        }

        //Not supporting higher value. Need to write our own technique
        private static string AddBinaryFunc(string a, string b)
        {
            long intA = Convert.ToInt64(a, 2);
            long intB = Convert.ToInt64(b, 2);
            long result = intA + intB;
            return Convert.ToString(result, 2);
        }
    }
}
