using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class MinimumWindowSubstring
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string subStr = Console.ReadLine();
            string output = MinWindowSecondAttempt(input, subStr);
            Console.WriteLine(output);
        }

        private static string MinWindow(string input, string subStr)
        {
            if (input.Length < subStr.Length)
                return "";
            int left = 0;
            int right = 0;
            int minLength = int.MaxValue;
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            while(left < input.Length && right < input.Length)
            {
                string subString = string.Empty;
                if (left+right >= input.Length)
                    subString = input.Substring(left, input.Length - left);
                else
                    subString = input.Substring(left, right+1);

                if (subStr.All(x => subString.Contains(x)))
                {
                    minLength = Math.Min(minLength, subString.Length);
                    if(keyValuePairs.ContainsKey(subString))
                    {
                        minLength = Math.Min(minLength, keyValuePairs[subString]);
                        keyValuePairs[subString] = minLength;
                    }
                    else
                        keyValuePairs.Add(subString, minLength);
                    left++;
                }
                else
                    right++;
            }

            string result = string.Empty;
            int valueMin = int.MaxValue;
            foreach (var kvp in keyValuePairs)
            {
                if(kvp.Value < valueMin)
                    result = kvp.Key;
            }
            return result;
        }

        //TODO: Debug and fix the bug
        //https://youtu.be/U1q16AFcjKs
        private static string MinWindowSecondAttempt(string input, string subStr)
        {
            if (string.IsNullOrEmpty(subStr) || string.IsNullOrEmpty(input))
                return string.Empty;

            Dictionary<char, int> charCountsInSubStr = new Dictionary<char, int>();
            foreach(char ch in subStr)
            {
                if(charCountsInSubStr.ContainsKey(ch))
                    charCountsInSubStr[ch]++;
                else
                    charCountsInSubStr.Add(ch, 1);
            }

            int i = 0, j = 0;
            int count = charCountsInSubStr.Count;
            int leftBoundary = 0, rightBoundary = input.Length-1;
            int min = subStr.Length;
            bool found = false;

            while(j < input.Length)
            {
                char rightChar = input[j++];
                if(charCountsInSubStr.ContainsKey(rightChar))
                {
                    charCountsInSubStr[(rightChar)]--;
                    if (charCountsInSubStr[rightChar] == 0)
                        count--;
                }
                if (count > 0)
                    continue;
                while(count == 0)
                {
                    char startChar = input[i++];
                    if(charCountsInSubStr.ContainsKey(startChar))
                    {
                        charCountsInSubStr[startChar]++;
                        if(charCountsInSubStr[startChar]>0)
                            count++;
                    } 
                }

                if((j - i) <= min)
                {
                    found = true;
                    leftBoundary = i;
                    rightBoundary = j;
                    min = j - i;
                }
            }
            return !found ? "" : input.Substring(leftBoundary-1, rightBoundary-leftBoundary+1);
        }
    }
}
