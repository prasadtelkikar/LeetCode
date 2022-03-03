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
            return word.ToUpper() == word || word.ToLower() == word || (char.IsUpper(word[0]) &&  word.Substring(1) ==  word.Substring(1).ToLower());
        }
    }
}
