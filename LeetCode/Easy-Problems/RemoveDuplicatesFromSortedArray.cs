using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static void Main(string[] args)
        {
            RemoveDuplicatesFromSortedArray duplicateRemove = new RemoveDuplicatesFromSortedArray();
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = duplicateRemove.RemoveTwoDuplicate(nums);
            Console.Write(result);
        }

        private int RemoveDuplicate(int[] nums)
        {
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i] == nums[i -1])
                    count++;
                else
                    nums[i-count] = nums[i];
            }
            return nums.Length - count;

        }
        //TODO: Need to solve it
        //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
        private int RemoveTwoDuplicate(int[] nums)
         {
            int count = 0;
            var test = new List<int>();
            for (int i = 0; i < nums.Length-2; i++)
            {
                if (nums[i] == nums[i+1] && nums[i+1] == nums[i+2])
                    count += 2;
                else
                {
                    nums[i-count] = nums[i];
                    test.Add(nums[i]);
                }
            }
            return test.Count + (nums.Length - count);

        }
    }
}
