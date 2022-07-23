using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class IntegerToRoman
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string output = IntToRoman(num);
        }

        //Greedy approach from Solution: https://leetcode.com/problems/integer-to-roman/solution/
        private static string IntToRoman(int num)
        {
            List<int> Values = new List<int>() { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            List<string> romanSymbols = new List<string> { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < Values.Count && num > 0; i++)
            {
                while(Values[i] <= num)
                {
                    sb.Append(romanSymbols[i]);
                    num -= Values[i];
                }
            }
            return sb.ToString();
        }
    }
}
