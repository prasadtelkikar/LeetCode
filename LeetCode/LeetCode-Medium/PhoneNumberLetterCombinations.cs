using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class PhoneNumberLetterCombinations
    {
        public static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            IList<string> result = LetterCombinations(digits);
            Console.WriteLine(string.Join(", ", result));
        }

        private static IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, string> numPad = new Dictionary<char, string>()
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            string[] arr = digits.ToCharArray().Select(x => numPad[x]).ToArray();
            IList<string> result = new List<string>();
            result.Add(String.Empty);
            for (int i = 0; i < arr.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                HashSet<string> set = new HashSet<string>(); 
                foreach(string str in result)
                {
                    //Store each element into result and use stored value and append each letter
                    foreach (char ch in arr[i])
                        set.Add(new StringBuilder(str).Append(ch).ToString());
                }
                result = set.ToList();
            }
            return result;
        }
    }
}
