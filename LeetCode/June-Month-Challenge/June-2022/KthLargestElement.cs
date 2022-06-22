using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class KthLargestElement
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int k = 4;
            int output = FindKthLargest(nums, k);
            Console.WriteLine(output);
        }

        private static int FindKthLargest(int[] nums, int k)
        {
            nums = nums.OrderByDescending(x => x).ToArray();
            return nums[k - 1];
        }
    }
}
