using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class DeepestLeavesSum
    {
        public static int s_index = -1;
        public static void Main(string[] args)
        {
            int?[] input = new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8 };
            TreeNode root = BuildTree(input);
            int result = DeepestLeavesSumFunBFS(root);
            Console.WriteLine(result);
        }

        private static int DeepestLeavesSumFun(TreeNode root)
        {
            int deepestSum = 0, depth = 0;
            Stack<NodeWithLevel> stack = new Stack<NodeWithLevel>();
            stack.Push(new NodeWithLevel(root, 0));

            while(stack.Count > 0)
            {
                NodeWithLevel node = stack.Pop();
                var currentNode = node.node;
                var currentDepth = node.level;

                if (currentNode.left == null && currentNode.right == null)
                {

                    if (depth < currentDepth)
                    {
                        deepestSum = currentNode.val;
                        depth = currentDepth;
                    }
                    else if (currentDepth == depth)
                        deepestSum += currentNode.val;
                }
                else
                {
                    if (currentNode.right != null)
                        stack.Push(new NodeWithLevel(currentNode.right, currentDepth + 1));
                    if (currentNode.left != null)
                        stack.Push(new NodeWithLevel(currentNode.left, currentDepth + 1));
                }
            }   
            return deepestSum;
        }


        private static int DeepestLeavesSumFunBFS(TreeNode root)
        {
            List<TreeNode> currentLevel = new List<TreeNode>();
            List<TreeNode> nextLevel = new List<TreeNode>();

            nextLevel.Add(root);

            while(nextLevel.Count > 0)
            {
                currentLevel = nextLevel.ToList();
                nextLevel.Clear();

                foreach(var node in currentLevel)
                {
                    if(node.left != null)
                        nextLevel.Add(node.left);
                    if (node.right != null)
                        nextLevel.Add(node.right);
                }
            }

            int deepestNode = 0;
            foreach (var item in currentLevel)
            {
                deepestNode += item.val;
            }
            return deepestNode;
        }

        private static int TreeHeight(TreeNode root)
        {
            if(root == null)
                return 0;
            int leftHeight = TreeHeight(root.left);
            int rightHeight = TreeHeight(root.right);
            return Math.Max(leftHeight, rightHeight)+1;
        }

        private static TreeNode BuildTree(int?[] input)
        {
            if(input.Length == 0)
                return null;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<int?> integerQueue = new Queue<int?>();

            for (int i = 1; i < input.Length; i++)
                integerQueue.Enqueue(input[i]);

            TreeNode treeNode = new TreeNode(input[0].Value);
            queue.Enqueue(treeNode);

            while(integerQueue.Count > 0)
            {
                int? leftValue = integerQueue.Count == 0 ? null : integerQueue.Dequeue();
                int? rightValue = integerQueue.Count == 0 ? null : integerQueue.Dequeue();
                TreeNode currentNode = queue.Dequeue();

                if(leftValue.HasValue)
                {
                    TreeNode left = new TreeNode(leftValue.Value);
                    currentNode.left = left;
                    queue.Enqueue(left);
                }
                if(rightValue.HasValue)
                {
                    TreeNode right = new TreeNode(rightValue.Value);
                    currentNode.right = right;
                    queue.Enqueue(right);
                }
            }

            return treeNode;
        }

        protected class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        protected class NodeWithLevel
        {
            public int level;
            public TreeNode node;
            public NodeWithLevel(TreeNode treeNode, int level)
            {
                this.node = treeNode;
                this.level = level;
            }
        }
    }


}
