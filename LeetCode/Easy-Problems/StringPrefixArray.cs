using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class StringPrefixArray
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            bool isPrefix = IsPrefixString(input, words);
            Console.WriteLine(isPrefix);
        }

        private static bool IsPrefixString(string s, string[] words)
        {
            for (int i = 1; i <=words.Length; i++)
            {
                var temp = string.Join("", words.Take(i));
                if (temp == s)
                    return true;
                if (temp.Length <= s.Length && !s.StartsWith(temp))
                    return false;
            }
            return false;
        }
    }
}
