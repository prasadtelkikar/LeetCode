using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class BalancedBinaryTree
    {
        public static void Main(string[] args)
        {
            int?[] input = new int?[] { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeHelper.BuildTree(input);

            bool isBalanced = IsBalanced(root);
            Console.WriteLine(isBalanced);
        }

        private static bool IsBalanced(TreeNode root)
        {
            return IsBalancedProcessed(root).isBalanced;
        }

        private static TreeInfo IsBalancedProcessed(TreeNode root)
        {
            if (root == null)
                return new TreeInfo(-1, true);
            TreeInfo left = IsBalancedProcessed(root.Left);
            if (!left.isBalanced)
                return new TreeInfo(-1, false);

            TreeInfo right = IsBalancedProcessed(root.Right);
            if(!right.isBalanced)
                return new TreeInfo(-1, false);

            if(Math.Abs(left.height - right.height) < 2)
                return new TreeInfo(Math.Max(left.height, right.height)+1, true);
            return new TreeInfo(-1, false);
        }

        protected class TreeInfo
        {
            public readonly int height;
            public readonly bool isBalanced;

            public TreeInfo(int height, bool isBalanced)
            {
                this.height = height;
                this.isBalanced = isBalanced;
            }
        }
    }
}
