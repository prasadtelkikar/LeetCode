using System;
using System.Linq;

using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class JumpGame
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            bool canJump = CanJump(nums);
            Console.WriteLine(canJump);

        }

        private static bool CanJump(int[] nums)
        {
            int reachable = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (reachable < i)
                    return false;
                int temp = Math.Max(reachable, i+nums[i]);
                if(temp > reachable)
                {
                    reachable = temp;
                    count++;
                }
            }
            return true;
        }
    }
}
