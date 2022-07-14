using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class ValidPalindrome_II
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPalindrome = ValidPalindromeSecond(input);
            Console.WriteLine(isPalindrome);
        }

        private static bool ValidPalindromeSecond(string input)
        {
            int i = 0;
            int j = input.Length - 1;
            while(i < j)
            {
                if (input[i] != input[j])
                    return IsPalindrome(input, i+1, j) || IsPalindrome(input, i, j-1);
            }
            return true;
        }


        //We need to use Recursion to delete and check palindrome
        public static bool IsPalindrome(string input, int i, int j)
        {
            while(i < j)
            {
                if (input[i] != input[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
