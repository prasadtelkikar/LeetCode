using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SortEvenOddIndicesSeparately
    {
        public static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] result = SortEvenOdd(nums);
        }

        //This can be improved, Lets improve it
        private static int[] SortEvenOdd(int[] nums)
        {
            var evenElements = nums.Where((x, i) => i % 2 == 0).OrderBy(y => y).ToArray();
            var oddElements = nums.Where((x, i) => i % 2 != 0).OrderByDescending(y => y).ToArray();
            int evenLength = evenElements.Length;
            int oddLength = oddElements.Length;

            var minLength = Math.Min(evenLength, oddLength);
            List<int> result = new List<int>();
            for (int i = 0; i < minLength; i++)
            {
                result.Add(evenElements[i]);
                result.Add(oddElements[i]);
            }
            if (minLength == evenLength && minLength == oddLength)
            {
            }
            else if (minLength == oddLength)
                result.Add(evenElements[evenLength - 1]);
            else
                result.Add(oddElements[oddLength - 1]);
            return result.ToArray();
        }
    }
}
