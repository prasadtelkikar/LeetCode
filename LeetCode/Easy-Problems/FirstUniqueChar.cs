using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FirstUniqueChar
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = FirstUniqChar(input);
            Console.WriteLine(output);
        }

        //Time limit exceed
        private static int FirstUniqChar(string input)
        {
            var result = input.Select((x, i) => new { Ch = x, Count = input.Count(c => c == x), Index = i });
            return result?.FirstOrDefault(x => x.Count == 1)?.Index ?? -1;
        }

        //Using Array
        private static int FirstUniqueCharArray(string input)
        {
            int[] array = new int[26];
            for (int i = 0; i < input.Length; i++)
            {
                int index = input[i] - 'a';
                array[index]++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                //Bug need to fix.
                if (array[i] == 1)
                    return i;
            }
            return -1;
        }
    }
}
