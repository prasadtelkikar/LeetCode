using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class PlusOne
    {
        public static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] result = PlusOneFun(digits);
            Console.WriteLine(string.Join(", ",result));
        }

        private static int[] PlusOneFun(int[] digits)
        {
            digits = digits.Reverse().ToArray();
            var result = new int[digits.Length+1];
            int carry = 0;
            for (int i = 0; i < digits.Length; i++)
            {

                int sum = 0;
                if (i == 0)
                    sum = digits[i] + 1;
                else
                    sum = digits[i] + carry;

                result[i] = sum % 10;
                carry = sum / 10;
            }
            if(carry != 0)
                result[digits.Length] = carry;
            result = result.Reverse().ToArray();
            int skipElements = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                    break;

                skipElements++;
            }
            return result.Skip(skipElements).ToArray();
        }
    }
}
