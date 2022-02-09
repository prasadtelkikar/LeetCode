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
            int sum = MinimumSum(number);
            Console.WriteLine(sum);
        }

        private static int MinimumSum(int num)
        {
            int first2Numbers = num % 100;
            int second2Numbers = ReverseNumber(num) % 100;
            
            int minFirst = Math.Min(first2Numbers, ReverseNumber(first2Numbers));
            int minSecond = Math.Min(second2Numbers, ReverseNumber(second2Numbers));
            return minFirst + minSecond;
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
