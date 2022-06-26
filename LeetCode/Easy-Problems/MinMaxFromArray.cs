using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MinMaxFromArray
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int count = MinimumDeletions(nums);
            Console.WriteLine(count);
        }

        private static int MinimumDeletions(int[] nums)
        {
            if (nums.Length == 1)
                return 1;
            if (nums.Length == 2)
                return 2;
            Dictionary<int, int> numWithIndex = new Dictionary<int, int>();
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                numWithIndex.Add(nums[i], i+1);
                min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
            }

            var maxIndex = numWithIndex[max];
            var minIndex = numWithIndex[min];

            var midIndex = nums.Length / 2;
            if(maxIndex < midIndex && minIndex < midIndex)
            {
                return Math.Max(maxIndex, minIndex);
            }
            else if(maxIndex > midIndex && minIndex > midIndex)
            {
                var minValue = Math.Min(maxIndex, minIndex);
                return nums.Length - minValue;
            }
            else
            {
                var minValuePosition = minIndex < (nums.Length - minIndex) ? minIndex : nums.Length - minIndex;
                var maxValuePosition = maxIndex < (nums.Length - maxIndex) ? maxIndex : nums.Length - maxIndex + 1;
                return minValuePosition + maxValuePosition;
            }    
        }
    }
}
