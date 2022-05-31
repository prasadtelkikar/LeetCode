using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class UniqueMorseCode
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(',');
            int result = UniqueMorseRepresentations(words);
            Console.WriteLine(result);
        }

        private static int UniqueMorseRepresentations(string[] words)
        {
            var morseCodes = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..",
                "--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
            var temp = new HashSet<string>();

            foreach (string word in words)
            {
                var morseCode = string.Join("", word.Select(x => morseCodes[x - 'a']));
                temp.Add(morseCode);
            }
            return temp.Count();
        }
    }
}
