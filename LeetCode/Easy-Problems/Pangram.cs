using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class Pangram
    {
        public static void Main(string args)
        {
            string word = Console.ReadLine();
            bool isPangram = IsPangram(word);
        }

        private static bool IsPangram(string word)
        {
            int[] wordCount = new int[26];
            foreach (char letter in word)
            {
                wordCount[letter - 'a']++;
            }
            return wordCount.All(x => x == 1);
        }
    }
}
