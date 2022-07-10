using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class FindTargetInCloneTree
    {
        public static void Main(string[] args)
        {
            int?[] input = new int?[] { 7, 4, 3, null, null, 6, 19 };
            TreeNode original =  TreeHelper.BuildTree(input);
            TreeNode cloned = original;
            TreeNode target = new TreeNode(3);

            TreeNode result = GetTargetCopy(original, cloned, target);
        }

        private static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            Queue<TreeNode> originalQueue = new Queue<TreeNode>();
            Queue<TreeNode> clonedQueue = new Queue<TreeNode>();
            clonedQueue.Enqueue(cloned);
            originalQueue.Enqueue(original);
            while(originalQueue.Count > 0)
            {
                var originalLastElement = originalQueue.Dequeue();
                var clonedLastElement = clonedQueue.Dequeue();
                if(originalLastElement == target)
                    return clonedLastElement;
                if(originalLastElement.Left != null)
                {
                    clonedQueue.Enqueue(clonedLastElement.Left);
                    originalQueue.Enqueue(originalLastElement.Left);
                }
                if (originalLastElement.Right != null)
                {
                    clonedQueue.Enqueue(clonedLastElement.Right);
                    originalQueue.Enqueue(originalLastElement.Right);
                }
            }
            //This will never execute
            return null;
        }
    }
}
