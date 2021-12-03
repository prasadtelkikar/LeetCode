using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SmallestCharThenTarget
    {
        public static void Main(string[] args)
        {
            var letters = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
            var target = Console.ReadLine()[0];

            char nextGreatest = NextGreatestLetter(letters, target);
            Console.WriteLine(nextGreatest);
        }

        private static char NextGreatestLetter(char[] letters, char target)
        {
            foreach (var letter in letters)
            {
                if (letter > target)
                    return letter;
            }
            return letters[0];
        }

        //Solution with Linq
        private static char NextGreaterestLetterLinq(char[] letters, char target)
        {
            var firstNextChar = letters.FirstOrDefault(x => x > target);
            return firstNextChar == default(char) ? letters[0] : firstNextChar;
        }
    }
}
