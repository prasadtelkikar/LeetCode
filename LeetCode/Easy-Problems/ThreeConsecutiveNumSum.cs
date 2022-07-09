using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ThreeConsecutiveNumSum
    {
        public static void Main(string[] args)
        {

            long num = long.Parse(Console.ReadLine());
            long[] result = SumOfThree(num);
            Console.WriteLine(string.Join(", ", result));
        }

        private static long[] SumOfThree(long num)
        {
            long rem = num % 3;
            if(rem != 0)
                return new long[0];
            else
            {
                long x = num / 3;
                return new long[] { x - 1, x, x + 1 };
            }
        }
    }
}
