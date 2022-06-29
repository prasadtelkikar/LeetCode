using System;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class LongestStringAtMostTwoDistinctCh
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = LengthOfLongestSubstringTwoDistinct(input);
            Console.WriteLine(output);
        }

        private static int LengthOfLongestSubstringTwoDistinct(string input)
        {
            int start = 0;
            int end = 0;
            int maxLength = int.MinValue;
            Dictionary<char, int> indexAndCount = new Dictionary<char, int>();
            while (end < input.Length)
            {
                if(indexAndCount.ContainsKey(input[end]))
                    indexAndCount[input[end]]++;
                else
                    indexAndCount.Add(input[end],1);
                end++;
                while(indexAndCount.Count >= 3)
                {
                    indexAndCount[input[start]]--;
                    if (indexAndCount[input[start]] == 0)
                        indexAndCount.Remove(input[start]);
                        
                    start++;
                }

                maxLength = Math.Max(maxLength, end-start);
            }
            return maxLength;
        }
    }
}
