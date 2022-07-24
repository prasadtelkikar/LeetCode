using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class RangeSumOfBST
    {
        public static int s_sum = 0;
        public static void Main(string[] args)
        {
            int?[] nums = { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 };
            int low = 6;
            int high = 10;
            TreeNode root = TreeHelper.BuildTree(nums);
            int result = RangeSumBST(root, low, high);
            Console.WriteLine(result);
        }

        private static int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;

            CalculateSum(root, low, high);

            return s_sum;
        }

        private static void CalculateSum(TreeNode root, int low, int high)
        {
            if (root == null)
                return;

            if (root.val >= low && root.val <= high)
                s_sum += root.val;

            CalculateSum(root.left, low, high);
            CalculateSum(root.right, low, high);
        }
    }
}
