using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class KeyboardRow
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(',');

            string[] output = FindWords(words);
            Console.WriteLine(string.Join(" ", output));
        }

        private static string[] FindWords(string[] words)
        {
            string[] keyConstants = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            List<string> result = new List<string>();

            foreach(var word in words)
            {
                if (word.All(x => "qwertyuiop".Contains(x, StringComparison.CurrentCultureIgnoreCase)))
                    result.Add(word);
                else if (word.All(x => "asdfghjkl".Contains(x, StringComparison.CurrentCultureIgnoreCase)))
                    result.Add(word);
                else if (word.All(x => "zxcvbnm".Contains(x, StringComparison.CurrentCultureIgnoreCase)))
                    result.Add(word);
            }
            return result.ToArray();
        }
    }
}
