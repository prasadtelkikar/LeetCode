using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class FlattenBinaryTreeToLinkedList
    {
        public static void Main(string[] args)
        {
            int?[] arr = new int?[] { 1, 2, 5, 3, 4, null, 6 };
            TreeNode root = TreeHelper.BuildTree(arr);

            FlattenNonRecursive(root);

        }

        private static TreeNode previous = null;
        private static void Flatten(TreeNode root)
        {
            if (root == null)
                return;
            Flatten(root.right);
            Flatten(root.left);

            root.right = previous;
            root.left = null;

            previous = root;
        }

        private static void FlattenNonRecursive(TreeNode root)
        {
            if (root == null)
                return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if(node.right != null)
                    stack.Push(node.right);
                if (node.left != null)
                    stack.Push(node.left);
                if(stack.Count > 0)
                {
                    //Keep in mind: Here you have to get top, not remove it.
                    var top = stack.Peek();
                    node.right = top;
                }
                node.left = null;
            }

        }
    }
}
