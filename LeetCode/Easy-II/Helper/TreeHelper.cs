using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II.Helper
{
    public class TreeHelper
    {
        public static TreeNode BuildTree(int?[] nums)
        {
            Queue<TreeNode> treeQueue = new Queue<TreeNode>();
            Queue<int?> numQueue = new Queue<int?>();

            TreeNode root = new TreeNode(nums[0].Value);
            treeQueue.Enqueue(root);

            for(int i = 1; i < nums.Length; i++)
                numQueue.Enqueue(nums[i]);

            while(numQueue.Count > 0)
            {
                int? leftValue = numQueue.Count == 0 ? null : numQueue.Dequeue();
                int? rightValue = numQueue.Count == 0 ? null : numQueue.Dequeue();
                TreeNode currentNode = treeQueue.Dequeue();

                if(leftValue.HasValue)
                {
                    TreeNode left = new TreeNode(leftValue.Value);
                    currentNode.Left = left;
                    treeQueue.Enqueue(left);
                }
                if(rightValue.HasValue)
                {
                    TreeNode right = new TreeNode(rightValue.Value);
                    currentNode.Right = right;
                    treeQueue.Enqueue(right);
                }
            }

            return root;
        }
    }
}
