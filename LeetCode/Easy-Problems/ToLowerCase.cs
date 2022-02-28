using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ToLowerCase
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = ToLowerCaseFunc(input);
        }

        private static string ToLowerCaseFunc(string s)
        {
            return s.ToLower();
        }

        private static string ToLowerCaseForLoop(string s)
        {
            char[] word = new char[s.Length];
            char[] upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int index = 0;
            foreach(var ch in s)
            {
                if(upperLetters.Contains(ch))
                    word[index++] = char.ToLower(ch);
                else
                    word[index++] = ch;
            }
            return new string(word);
        }
    }
}
