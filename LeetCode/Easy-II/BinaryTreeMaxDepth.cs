using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class BinaryTreeMaxDepth
    {
        public static void Main(string[] args)
        {
            int?[] input = new int?[]{3, 9, 20, null, null, 15, 7};// { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeHelper.BuildTree(input);
            int maxDepth = MaxDepthBSF(root);
            Console.WriteLine(maxDepth);
        }

        //Using Recursion
        private static int MaxDepthRecursion(TreeNode root)
        {
            if(root == null)
                return 0;
            return Math.Max(MaxDepthRecursion(root.left), MaxDepthRecursion(root.right))+1;
        }

        //Using BFS
        private static int MaxDepthBSF(TreeNode root)
        {
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            int level = 1;
            while(queue.Count > 1)
            {
                TreeNode node = queue.Dequeue();
                //New Level
                if (node == null)
                    level++;
                if(node != null)
                {
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                else if (queue.Count > 0)
                    queue.Enqueue(null);
            }

            return level;
        }
    }
}
