using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class ValidBinaryTree
    {
        public static int? previousValue = null;
        public static void Main(string[] args)
        {
            int?[] input = { 5, 1, 4, null, null, 3, 6 };
            TreeNode root = TreeHelper.BuildTree(input);
            bool isValid = IsValidBSTByStack(root);
            Console.WriteLine(isValid);
        }

        private static bool IsValidBST(TreeNode root)
        {
            return IsValidBSTDSF(root, int.MinValue, int.MaxValue);
        }

        private static bool IsValidBSTDSF(TreeNode root, int low, int high)
        {
            if (root == null)
                return true;

            int currentValue = root.val;

            if(currentValue <= low || currentValue >= high)
                return false;

            return IsValidBSTDSF(root.left, low, currentValue) && IsValidBSTDSF(root.right, currentValue, high);
        }
        
        private static bool isValidBSTByInorder(TreeNode root)
        {
            if (root == null)
                return true;

            if (!isValidBSTByInorder(root.left))
                return false;
            int currentValue = root.val;
            if(previousValue != null && currentValue < previousValue)
                return false;
            if(!isValidBSTByInorder(root.right))
                return false;
            return true;
        }

        //Using Stack

        private static bool IsValidBSTByStack(TreeNode root)
        {
            if (root == null)
                return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode previousNode = null;
            while(root != null || stack.Count > 0)
            {
                while(root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                if(previousNode != null && root.val <= previousNode.val)
                    return false;
                previousNode = root;
                root = root.right;
            }
            return true;
        }
    }
}
