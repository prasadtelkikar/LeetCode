using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class SumOneDArray
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] result = RunningSum(nums);
            Console.WriteLine(result);
        }

        private static int[] RunningSum(int[] nums)
        {
            var output = new int[nums.Length];
            output[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
                output[i] = output[i-1] + nums[i];

            return output;
        }
    }
}
