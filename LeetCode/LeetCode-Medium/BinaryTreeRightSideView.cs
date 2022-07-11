using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class BinaryTreeRightSideView
    {
        public static IList<int> result = new List<int>();
        public static void Main(string[] args)
        {
            int?[] input = { 1 };
            TreeNode root = TreeHelper.BuildTree(input);

            IList<int> result = FindRightSideRecursiveBSF(root);

            Console.WriteLine(string.Join(", ", result));
        }

        private static IList<int> FindRightSideView(TreeNode root)
        {
            if(root == null)
                return new List<int>();

            FindRightSideRecursive(root, 0);
            return result;
        }

        private static void FindRightSideRecursive(TreeNode root, int level)
        {
            if (root == null)
                return;

            var currentValue = root.val;
            if(result.Count == level)
                result.Add(currentValue);

            FindRightSideRecursive(root.right, level+1);
            FindRightSideRecursive(root.left, level+1);
        }

        private static IList<int> FindRightSideRecursiveBSF(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            List<int?> BSFResult = new List<int?>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            while(queue.Count > 1)
            {
                TreeNode node = queue.Dequeue();
                if(node == null)
                {
                    queue.Enqueue(null);
                    BSFResult.Add(null);
                    continue;
                }
                var currentValue = node.val;
                BSFResult.Add(currentValue);

                if(node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            BSFResult.Add(null);
            
            List<int> rightView = new List<int>();
            for(int i = 1; i < BSFResult.Count; i++)
            {
                if(BSFResult[i] == null)
                {
                    rightView.Add(BSFResult[i-1].Value);
                }
            }
            return rightView;
        }
    }
}
