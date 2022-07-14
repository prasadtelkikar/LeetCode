using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class ValidPalindrome
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPalindrome = ValidPalindromeForth(input);
        }

        private static bool ValidPalindromeForth(string input)
        {
            int limit=0;
            int length = input.Length - 1;
            int mid = input.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                if (input[i] != input[length - i])
                    limit++;
                if (limit > 1)
                    return false;
            }
            return true;
        }
    }
}
