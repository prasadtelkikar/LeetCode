using System;
using System.Collections.Generic;
using System.Linq;

namespace Easy_Problems
{
    public class PlusOneToIntArray
    {
        public static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] result = GetPlusOneToIntArray(digits);

            int[] result = PlusOneFunWithoutReverse(digits);
            Console.WriteLine(string.Join(", ", result));
        }

        //This is using integer conversion plus one.
        private static int[] GetPlusOneToIntArray(int[] digits)
        {
            long result = 0;
            foreach (var digit in digits)
            {
                result = result *10 + digit;
            }
            result = result + 1;

            var array = new List<int>();
            while(result > 0)
            {
                long element = result % 10;
                result /= 10;
                array.Add((int)element);
            }
            array.Reverse();
            return array.ToArray();
        }
        //TODO: Very close to solve; Failing test case [8,9,9,9], lets look at tomorrow
        private static int[] PlusOne(int[] digits)
        {
            int carry = 0;
            int[] result = new int[digits.Length+1];
            for (int i = digits.Length-1; i >= 0; i--)
            {
                int sum = 0;
                if (i == digits.Length - 1)
                    sum = digits[i] + 1;
                else if (carry != 0)
                {
                    sum += carry + digits[i];
                }
                else
                    sum += digits[i];

                if (sum > 9)
                {
                    var lastDigit = sum % 10;
                    carry = sum / 10;
                    result[i+1] = lastDigit;
                }
                else
                    result[i+1] = sum;
            }
            if (carry != 0)
                result[0] = carry;
            else
                result = result.Skip(1).ToArray();
            return result;
        }

        private static int[] PlusOneFun(int[] digits)
        {
            digits = digits.Reverse().ToArray();
            int[] result = new int[digits.Length + 1];
            for (int i = 0; i < digits.Length; i++)
            {
                if(i == 0)
                {
                    var sumOne = digits[i] + 1;
                    result[i] = sumOne;
                    result[i+1] = result[i] / 10;
                    result[i] = result[i] % 10;
                }
                else
                {
                    var sum = digits[i] + result[i+1];
                    result[i] += sum;
                    result[i+1] = result[i] / 10;
                    result[i] = result[i] % 10;
                }   
            }
            result = result.Reverse().ToArray();
            int temp = 0;
            for (int i = 0; i < result.Length; i++, temp++)
            {
                if (result[i] != 0)
                    break;
            }
            return result.Skip(temp).ToArray();
        }



        //No major difference in this two solutions
        private static int[] PlusOneFunWithoutReverse(int[] digits)
        {
            int length = digits.Length;
            int resultLength = length + 1;
            int[] result = new int[resultLength];
            for (int i = length-1, j = 0; i >= 0; i--, j++)
            {
                if(i == length-1)
                {
                    var sum = digits[i]+1;
                    result[length-j] = sum;
                    result[length-j-1] = result[length-j] / 10;
                    result[length-j] = result[length-j] % 10;
                }
                else
                {
                    var sum = digits[i] + result[length-j-1];
                    result[length-j] += sum;
                    result[length-j-1] = result[length-j] / 10;
                    result[length-j] = result[length-j] % 10;
                }
            }
            int temp = 0;
            for (int i = 0; i < result.Length; i++, temp++)
                if (result[i] != 0)
                    break;

            return result.Skip(temp).ToArray();
        }
    }
}
