using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MinimumFourDigits
    {
        public static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            int sum = MinimumSumFunc1(number);
            Console.WriteLine(sum);
        }

        //Failed attempt
        private static int MinimumSum(int num)
        {
            int first2Numbers = num % 100;
            int second2Numbers = ReverseNumber(num) % 100;
            
            int minFirst = Math.Min(first2Numbers, ReverseNumber(first2Numbers));
            int minSecond = Math.Min(second2Numbers, ReverseNumber(second2Numbers));
            return minFirst + minSecond;
        }

        //Cheated
        private static int MinimumSumFunc(int num)
        {
            List<int> shortNumbers = new List<int>();
            while(num > 0)
            {
                var temp = num % 10;
                shortNumbers.Add(temp);
                num /= 10;
            }

            shortNumbers.Sort();
            int num1 = shortNumbers[0] * 10 + shortNumbers[2];  //Because we already sorted an array, we will get smallest number, by index 0 * 10 + index 2
            int num2 = shortNumbers[1] * 10 + shortNumbers[3];  //Second smallest number, because of sorting.

            return num1 + num2;

        }
        
        //Same test as above
        private static int MinimumSumFunc1(int num)
        {
            int[] numArray = num.ToString()
                .ToCharArray()
                .Select(c => c - '0')
                .OrderBy(x => x)
                .ToArray();

            int num1 = numArray[0] * 10 + numArray[2];
            int num2 = numArray[1] * 10 + numArray[3];
            return num1+num2;
        }


        private static int ReverseNumber(int number)
        {
            int result = 0;
            while(number > 0)
            {
                result = result*10 + number%10;
                number /= 10;
            }
            return result;
        }
    }
}
