using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class SortedListToBST
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            TreeNode root = SortedArrayToBST(nums);

        }

        private static TreeNode SortedArrayToBST(int[] nums)
        {
            int lower = 0;
            int upper = nums.Length - 1;

            TreeNode root = BinarySearch(nums, lower, upper);
            return root;
        }

        private static TreeNode BinarySearch(int[] nums, int lower, int upper)
        {

            if (lower > upper)
                return null;

            int mid = lower + (upper - lower) / 2;
            TreeNode root = new TreeNode(nums[mid]);

            root.left = BinarySearch(nums, lower, mid-1);
            root.right = BinarySearch(nums, mid+1, upper);

            return root;
        }
    }
}
