using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ArrayFromPermutation
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var result = BuildArray(nums);
            Console.WriteLine(string.Join(", ", result));
        }

        private static int[] BuildArray(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                result[i] = nums[nums[i]];
            return result;
        }
        
        private static int[] BuildArraySelectLinq(int[] nums)
        {
            return nums.Select(x => nums[x]).ToArray();
        }
    }
}
