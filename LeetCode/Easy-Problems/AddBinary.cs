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

            string result = AddBinaryFunc1(a, b);
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

        private static string AddBinaryFunc1(string a, string b)
        {
            if(a == "0" && b == "0")
                return "0";
            var binaryAReverse = a.ToCharArray().Reverse().ToArray();
            var binaryBReverse = b.ToCharArray().Reverse().ToArray();
            int lengthA = binaryAReverse.Length;
            int lengthB = binaryBReverse.Length;
            int maxLength = Math.Max(lengthA, lengthB);
            int carry = 0;
            int[] resultArr = new int[maxLength+1];
            for (int i = 0; i < maxLength; i++)
            {
                int sum = 0;
                int valueA = 0;
                int valueB = 0;
                if (i < lengthA)
                    valueA = binaryAReverse[i] - '0';
                if(i < lengthB)
                    valueB = binaryBReverse[i] - '0';

                sum = valueA + valueB + carry;
                int result = sum % 2;
                carry = sum / 2;
                resultArr[i] = result;
            }
            resultArr[maxLength] = carry;
            resultArr = resultArr.Reverse().ToArray();
            int count = 0;
            for (int i = 0; i < maxLength+1; i++)
            {
                if (resultArr[i] != 0)
                    break;
                else
                    count++;
            }
            return string.Join("", resultArr.Skip(count));    
        }
    }
}
