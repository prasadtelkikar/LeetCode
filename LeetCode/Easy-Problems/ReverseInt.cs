using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ReverseInt
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int result = Reverse(x);
            Console.WriteLine(result);
        }

        private static int Reverse(int x)
        {
            bool isNegative = x < 0;
            int processedNum = x < 0 ? x * -1 : x;
            long result = 0;
            while (processedNum > 0)
            {
                int lastDigit = processedNum % 10;
                processedNum /= 10;
                result = result * 10 + lastDigit;
            }
            if (result > int.MaxValue)
                return 0;
            if (isNegative)
            {
                result = result * -1;
                if (result > 0)
                    return 0;
            }
            return (int)result;
        }
    }
}
