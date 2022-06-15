using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class MaxEnsureValue
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int result = MaximumUniqueSubarray(nums);
            Console.WriteLine(result);
        }

        //Sliding window algorithm
        private static int MaximumUniqueSubarray(int[] nums)
        {
            int i = 0, j = 0;
            int sum = 0, ans = 0;
            HashSet<int> set = new HashSet<int>();
            while(i < nums.Length && j < nums.Length)
            {
                if(!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                    sum = sum + nums[i];
                    ans = Math.Max(sum, ans);
                    i++;
                }
                else
                {
                    set.Remove(nums[j]);
                    sum = sum - nums[j];
                    j++;
                }
            }
            return ans;
        }
    }
}
