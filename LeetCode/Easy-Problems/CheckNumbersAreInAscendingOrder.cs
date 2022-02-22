using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CheckNumbersAreInAscendingOrder
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isAscending = AreNumbersAscending(input);
            Console.WriteLine(isAscending ? "Passed" : "Failed");
        }

        private static bool AreNumbersAscending(string s)
        {
            var onlyNumbers = s.Split()
                .Where(x => int.TryParse(x, out int number))
                .Select(x => int.Parse(x)).ToArray();

            for (int i = 1; i < onlyNumbers.Length; i++)
            {
                if (onlyNumbers[i-1] >= onlyNumbers[i])
                    return false;
            }
            return true;
        }

        private static bool AreNumbersAscendingNoLinq(string s)
        {
            int min = int.MinValue;
            foreach(string word in s.Split())
            {
                if (int.TryParse(word,out int number))
                {
                    if (min >= number)
                        return false;
                    min = number;
                }
            }
            return true;
        }
    }
}
