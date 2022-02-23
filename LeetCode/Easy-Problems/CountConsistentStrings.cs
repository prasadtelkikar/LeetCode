using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CountConsistentStrings
    {
        public static void Main(string[] args)
        {
            string allowed = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            int result = CountConsistentStringsInArray(allowed, words);
            Console.WriteLine(result);
        }

        private static int CountConsistentStringsInArray(string allowed, string[] words)
        {
            var result = 0;
            foreach (var word in words)
            {
                var distinctLettersInWord = word.Distinct();
                if(distinctLettersInWord.All(x => allowed.Contains(x)))
                {
                        result++;
                }
            }
            return result;
        }
    }
}
