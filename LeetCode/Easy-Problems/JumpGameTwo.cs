using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class JumpGameTwo
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int num = Jump(nums);

        }

        private static int Jump(int[] nums)
        {
            int reachable = 0;
            int count = 0;
            int previousReachable = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                reachable = Math.Max(reachable, nums[i]+i);
                if(i == previousReachable)
                {
                    previousReachable = reachable;
                    count++;
                }
            }
            return count;
        }
    }
}
