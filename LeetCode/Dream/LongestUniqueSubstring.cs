using System;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class LongestUniqueSubstring
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = FindLengthOfLongestUniqueSubstring(input);
            Console.WriteLine(output);
        }

        private static int FindLengthOfLongestUniqueSubstring(string input)
        {
            if(string.IsNullOrEmpty(input))return 0;

            HashSet<char> hash = new HashSet<char>();
            int l = 0, max = int.MinValue;
            for (int r = 0; r < input.Length; r++)
            {
                while(hash.Contains(input[r]))
                {
                    hash.Remove(input[l]);
                    l++;
                }
                hash.Add(input[r]);
                max = Math.Max(max, r-l+1);
            }
            return max;
        }
    }
}
