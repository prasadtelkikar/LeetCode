using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class KthSmallestElementBST
    {
        public static List<int> result = new List<int>();
        public static void Main(string[] args)
        {
            int?[] arr = new int?[] { 5, 3, 6, 2, 4, null, null, 1 };
            int kthSmallest = 3;
            TreeNode root = TreeHelper.BuildTree(arr);
            int result = KthSmallest(root, kthSmallest);
            Console.WriteLine(result);
        }

        private static int KthSmallest(TreeNode root, int kthSmallest)
        {
            InOrderTraversal(root);
            return result[kthSmallest-1];
        }

        private static void InOrderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            InOrderTraversal(root.left);
            result.Add(root.val);
            InOrderTraversal(root.right);
        }
    }
}
