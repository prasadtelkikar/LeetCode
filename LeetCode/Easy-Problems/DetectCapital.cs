using System;

namespace Easy_Problems
{
    public class DetectCapital
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isCapital = DetectCapitalUse(input);
            Console.WriteLine(isCapital);
        }

        //Need clear understanding before I submit next attempt: https://leetcode.com/problems/detect-capital/
        private static bool DetectCapitalUse(string word)
        {
            var subStr = word.Substring(1);
            var regex = new System.Text.RegularExpressions.Regex(@"^[A-Z]+$");
            return regex.IsMatch(word) || (char.IsUpper(word[0]) && subStr == subStr.ToLower());
        }
    }
}
