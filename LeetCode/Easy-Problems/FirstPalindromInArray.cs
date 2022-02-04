using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FirstPalindromInArray
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string result = FindFirstPalindromInAnArray(words);
        }

        private static string FindFirstPalindromInAnArray(string[] words)
        {
            var reverseWords = words.Select(x => new string(x.Reverse().ToArray())).ToArray();
            for(int i = 0; i < reverseWords.Length; i++)
            {
                if(words[i] == reverseWords[i])
                    return reverseWords[i];
            }
            return null;
        }
    }
}
