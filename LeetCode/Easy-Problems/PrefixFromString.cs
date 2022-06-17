using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    internal class PrefixFromString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            int result = CountPrefixes(words, input);
            Console.WriteLine(result);
        }

        private static int CountPrefixes(string[] words, string input)
        {
            return words.Count(x => input.StartsWith(x));
        }
    }
}
