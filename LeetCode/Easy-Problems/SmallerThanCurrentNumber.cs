using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SmallerThanCurrentNumber
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] outputs = FindSmallerThanCurrentNumber(inputs);
            Console.WriteLine(string.Join(' ', outputs));
        }

        private static int[] FindSmallerThanCurrentNumber(int[] inputs)
        {
            return inputs.Select(x => inputs.Count(y => y < x)).ToArray();
        }
    }
}
