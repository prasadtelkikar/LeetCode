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
            var evenElements = nums.Where((x, i) => i % 2 == 0).OrderByDescending(y => y).ToArray();
            var oddElements = nums.Where((x, i) => i % 2 != 0).OrderBy(y => y).ToArray();
            var minLength = Math.Min(evenElements.Count(), oddElements.Count());
            List<int> result = new List<int>();
            for (int i = 0; i < minLength; i++)
            {
                result.Add(evenElements[i]);
                result.Add(oddElements[i]);
            }
            if (minLength == evenElements.Count() && minLength == oddElements.Count())
            {
            }
            else if (minLength == oddElements.Count())
                result.Add(evenElements[evenElements.Count() - 1]);
            else
                result.Add(oddElements[oddElements.Count() - 1]);
            return result.ToArray();
        }
    }
}
