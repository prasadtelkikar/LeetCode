using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class PalindromeNumber
    {
        public static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(x));
        }

        private static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var reverse = 0;
            var tempx = x;
            while(x > 0)
            {
                var rem = x % 10;
                reverse = reverse * 10 + rem;
                x = x / 10;
            }
            return tempx == reverse;
        }
    }
}
