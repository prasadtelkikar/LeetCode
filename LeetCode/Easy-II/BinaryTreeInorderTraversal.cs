using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class BinaryTreeInorderTraversal
    {
        public static List<int> inorder = new List<int>();
        public static void Main(string[] args)
        {
            int?[] input = { 1, null, 2, 3 };
            TreeNode root = TreeHelper.BuildTree(input);
            List<int> result = InorderTravelWithoutRecursion(root);
            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> InorderTraversal(TreeNode root)
        {
            if(root == null)
                return inorder;

            Inorder(root);
            return inorder;
        }

        private static void Inorder(TreeNode root)
        {
            if (root == null)
                return;

            Inorder(root.Left);
            inorder.Add(root.Value);
            Inorder(root.Right);
        }

        private static List<int> InorderTravelWithoutRecursion(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            
            while(root != null || stack.Count > 0)
            {
                while(root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }
                root = stack.Pop();
                inorder.Add(root.Value);
                root = root.Right;
            }
            return inorder;
        }
    }
}
