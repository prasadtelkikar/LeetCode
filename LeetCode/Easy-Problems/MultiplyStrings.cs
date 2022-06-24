using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MultiplyStrings
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            string output = Multiply(num1, num2);
            Console.WriteLine(output);
        }

        private static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int[] num1Chars = num1.ToCharArray().Select(x => x - '0').Reverse().ToArray();
            int[] num2Chars = num2.ToCharArray().Select(x => x - '0').Reverse().ToArray();

            int[] result = new int[num1Chars.Length + num2Chars.Length];
            for (int i = 0; i < num1Chars.Length; i++)
            {
                for (int j = 0; j < num2Chars.Length; j++)
                {
                    var digit = num1Chars[i] * num2Chars[j];
                    result[i+j] += digit;
                    result[i+j+1] += (result[i+j] / 10);
                    result[i+j] = result[i+j] % 10;
                }
            }
            result = result.Reverse().ToArray();
            int temp = 0;
            for (int i = 0; i < num1Chars.Length; i++, temp++)
            {
                if (result[i] != 0)
                    break;
            }
            return string.Join("", result.Skip(temp));
        }
    }
}
