using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class MultiplyString
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            string mul = Multiply(num1, num2);
            Console.WriteLine(mul);
        }

        private static string Multiply(string num1, string num2)
        {
            if(num1 == "0" || num2 == "0")
                return "0";
            //Always reverse the array
            int[] num1Arr = num1.ToCharArray().Select(x => x - '0').Reverse().ToArray();
            int[] num2Arr = num2.ToCharArray().Select(x => x - '0').Reverse().ToArray();
            int[] result = new int[num1Arr.Length + num2Arr.Length];

            for (int i = 0; i < num1Arr.Length; i++)
            {
                for (int j = 0; j < num2Arr.Length; j++)
                {
                    //Sum previous value with carry
                    var mul = num1Arr[i] * num2Arr[j];
                    result[i+j] += mul;
                    //Sum leftover carry with original carry
                    result[i+j+1] += result[i+j] / 10;
                    //Store last date
                    result[i+j] = result[i+j] % 10;
                }
            }

            //Remove unused space
            result = result.Reverse().ToArray();
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                    break;
                temp++;
            }
            return string.Join("", result.Skip(temp));
        }
    }
}
