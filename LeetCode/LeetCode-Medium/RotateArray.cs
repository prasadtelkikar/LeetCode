using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class RotateArray
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = Convert.ToInt32(Console.ReadLine());

            RotateThirdApproach(nums, k);
            Console.WriteLine(String.Join(" ", nums));
        }

        private static void Rotate(int[] nums, int k)
        {
            int[] output = new int[nums.Length];
            int length =nums.Length;
            for (int i = 0; i < length; i++)
                output[i] = nums[(i+k) % length];
            for(int i = 0; i < length;i++)
                nums[i] = output[i];
        }

        private static void RotateSecondApproach(int[] nums, int k)
        {
            for(int step = 0; step < k; step++)
            {
                int stepItem = nums[0];
                for(int i = 1;i < nums.Length;i++)
                    nums[i - 1] = nums[i];
                nums[nums.Length - 1] = stepItem;
            }
        }

        private static void RotateThirdApproach(int[] nums, int k)
        {
            k = k % nums.Length;
            Swap(nums, 0, k - 1);
            Swap(nums, k, nums.Length - 1);
            Swap(nums, 0, nums.Length - 1);
        }

        private static void Swap(int[] nums, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                //int temp = nums[i];
                //nums[i] = nums[j];
                //nums[j] = temp;
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }
    }
}
