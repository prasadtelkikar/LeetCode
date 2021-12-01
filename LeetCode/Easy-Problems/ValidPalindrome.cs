using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ValidPalindrome
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var isPalindrome = IsPalindrome(input);
            Console.WriteLine(isPalindrome);
        }

        private static bool IsPalindrome(string input)
        {
            var inputAlphaNumeric = new string(input.ToLower().Where(x => char.IsDigit(x) || char.IsLetter(x)).ToArray());
            var reverse = inputAlphaNumeric.ToCharArray();
            Array.Reverse(reverse);
            var reverseStr = new String(reverse);
            return inputAlphaNumeric.Equals(reverseStr);
        }
    }
}
