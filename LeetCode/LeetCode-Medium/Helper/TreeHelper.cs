using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium.Helper
{
    public class TreeHelper
    {
        public static TreeNode BuildTree(int?[] input)
        {
            Queue<TreeNode> treeQueue = new Queue<TreeNode>();
            Queue<int?> intQueue = new Queue<int?>();
            TreeNode root = new TreeNode(input[0].Value);
            treeQueue.Enqueue(root);

            for(int i = 1; i < input.Length; i++)
                intQueue.Enqueue(input[i]);

            while(intQueue.Count > 0)
            {
                TreeNode node = treeQueue.Dequeue();
                int? leftData = intQueue.Count == 0 ? null : intQueue.Dequeue();
                int? rightData = intQueue.Count == 0 ? null : intQueue.Dequeue();
                if (leftData.HasValue)
                {
                    TreeNode leftNode = new TreeNode(leftData.Value);
                    node.left = leftNode;
                    treeQueue.Enqueue(leftNode);
                }

                if(rightData.HasValue)
                {
                    TreeNode rightNode = new TreeNode(rightData.Value);
                    node.right = rightNode;
                    treeQueue.Enqueue(rightNode);
                }
            }

            return root;
        }
    }
}
