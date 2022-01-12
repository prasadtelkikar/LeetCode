using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class RunningSumOfArray
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var output = RunningSumPrefixArray(nums);
            Console.WriteLine(String.Join(", ", output));
        }

        private static int[] RunningSum(int[] nums)
        {
            var result = new List<int>();
            for (int i = 0;i < nums.Length;i++)
            {
                int sum = 0;
                for (int j = 0; j <=i; j++)
                   sum+= nums[j];
                result.Add(sum);
            }
            return result.ToArray();
        }

        //This solution was new to me. Thanks to https://dev.to/seanpgallivan/solution-running-sum-of-1d-array-34na#idea
        private static int[] RunningSumPrefixArray(int[] nums)
        {
            var output = new int[nums.Length];
            output[0] = nums[0];
            for(int i = 1; i < nums.Length;i++)
                output[i] = output[i-1] + nums[i];

            return output;
        }
    }
}
