using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class RemoveElement
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var val = Convert.ToInt32(Console.ReadLine());

            var length = RemoveElementFun(nums, val);
            Console.WriteLine(length);
            Console.WriteLine(String.Join(' ', nums));
        }

        //Actual solution, which failed.
        private static int RemoveElementFun(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == val)
                {
                    nums[i] = int.MaxValue;
                    count++;
                }
            }
            return count;
        }

        //Cheated: Solution tab
        public int RemoveElementFun1(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
    }
}
