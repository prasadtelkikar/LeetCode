using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class LongestPalindromeString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = LongestPalindrome(input);
            Console.WriteLine(output);
        }
        //Not working
        private static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //For Odd length
                int len1 = ExpandAroundCenter(s, i, i);
                //For even length
                int len2 = ExpandAroundCenter(s, i, i+1);
                int len =  Math.Max(len1, len2);

                if(len > end-start)
                {
                    start = i - (len-1)/2;
                    end = i + len / 2;
                }

            }
            return s.Substring(start, end+1);
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while(L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
