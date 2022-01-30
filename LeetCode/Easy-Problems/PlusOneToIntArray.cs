using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class PlusOneToIntArray
    {
        public static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = GetPlusOneToIntArray(digits);

            Console.WriteLine(string.Join(", ", result));
        }

        //This is using integer conversion plus one.
        private static int[] GetPlusOneToIntArray(int[] digits)
        {
            long result = 0;
            foreach (var digit in digits)
            {
                result = result *10 + digit;
            }
            result = result + 1;

            var array = new List<int>();
            while(result > 0)
            {
                long element = result % 10;
                result /= 10;
                array.Add((int)element);
            }
            array.Reverse();
            return array.ToArray();
        }

        //This program is not as simple as it looks like, it need to cover length of interger <= 100
    }
}
