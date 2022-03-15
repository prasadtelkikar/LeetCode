using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CountMatches
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = NumberOfMatches(n);
            Console.WriteLine(result);
        }

        private static int NumberOfMatches(int n)
        {
            int ans = 0;
            while(n > 1)
            {
                int temp = n / 2;
                ans += temp;
                n -= temp;
            }
            return ans;
        }
    }
}
