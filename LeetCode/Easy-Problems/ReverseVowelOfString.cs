using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ReverseVowelOfString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = ReverseVowel(input);
            Console.WriteLine(output);
        }

        //Can we make it in one for loop
        private static string ReverseVowel(string input)
        {
            char[] vowels = "AEIOUaeiou".ToCharArray();
            List<char> reverseActualVowels = new List<char>();
            foreach(char ch in input)
            {
                if(vowels.Contains(ch))
                    reverseActualVowels.Add(ch);
            }
            reverseActualVowels.Reverse();
            List<char> result = new List<char>();
            int i = 0;
            foreach (char ch in input)
            {
                if (vowels.Contains(ch))
                    result.Add(reverseActualVowels[i++]);
                else
                    result.Add(ch);
            }
            return new string(result.ToArray());
        }
    }
}
