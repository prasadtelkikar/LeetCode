using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class AnyPrefixOfWord
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine(); 
            string prefix = Console.ReadLine();

            int prefixIndex = IsPrefixOfWord(sentence, prefix);
            Console.WriteLine(prefixIndex);
        }

        private static int IsPrefixOfWord(string sentence, string searchWord)
        {
            int index = 0;
            foreach (var item in sentence.Split(' '))
            {
                if (item.StartsWith(searchWord))
                    return ++index;
                ++index;
            }
            return -1;
        }
    }
}
