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
            string output = MinWindow(input, subStr);
            Console.WriteLine(output);
        }

        private static string MinWindow(string input, string subStr)
        {
            int left = 0;
            int right = 0;
            int minLength = int.MaxValue;
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            while(left <= right && right < input.Length)
            {
                string subString = string.Empty;
                if (left+right+1 > input.Length)
                    subString = input.Substring(left, input.Length - left - 1);
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
    }
}
