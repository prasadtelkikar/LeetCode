using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class BottomLeftValue
    {
        public static int maxDepth = 0;
        public static int resultantValue = 0;
        public static void Main(string[] args)
        {
            int?[] input = { 1, 2, 3, 4, null, 5, 6, null, null, 7 };
            TreeNode root = TreeHelper.BuildTree(input);

            int result = FindBottomLeftValue(root);
            Console.WriteLine(result);
        }

        //BSF
        private static int FindBottomLeftValue(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode currentNode = root;
            while(queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                currentNode = node;
                if(node.right != null)
                    queue.Enqueue(node.right);
                if (node.left != null)
                    queue.Enqueue(node.left);
            }
            return currentNode.val;
        }

        //DSF
        private static int FindBottomLeftValueDSF(TreeNode root)
        {
            CaculateHeight(root, 1);
            return resultantValue;
        }

        private static void CaculateHeight(TreeNode root, int level)
        {
            if (root == null)
                return;

            if(level > maxDepth)
            {
                maxDepth = level;
                resultantValue = root.val;
            }

            CaculateHeight(root.left, level+1);
            CaculateHeight(root.right, level+1);
        }
    }
}
