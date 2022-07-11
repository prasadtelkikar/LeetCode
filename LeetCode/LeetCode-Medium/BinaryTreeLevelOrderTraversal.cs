using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> result = new List<IList<int>>();
        public static void Main(string[] args)
        {
            int?[] input = { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeHelper.BuildTree(input);
            IList<IList<int>> output = LevelOrder(root);
            foreach(var outerList in output)
            {
                Console.WriteLine(string.Join(", ", outerList));
            }
        }

        //DSF
        private static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if(root == null)
                return result;
            ProcessDSF(root, 0);
            return result;

        }

        //BSF
        private static IList<IList<int>> LevelOrderBSF(TreeNode root)
        {
            if (root == null)
                return result;
            ProcessBSF(root);
            return result;

        }

        private static void ProcessDSF(TreeNode root, int level)
        {
            if (result.Count == level)
                result.Add(new List<int>());

            var resultantCurrentLevel = result[level];
            resultantCurrentLevel.Add(root.val);

            if (root.left != null)
                ProcessDSF(root.left, level+1);
            if (root.right != null)
                ProcessDSF(root.right, level+1);
        }

        private static void ProcessBSF(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 0;  

            while(queue.Count > 0)
            {
                result.Add(new List<int>());

                int currentSize = queue.Count;
                for(int i = 0; i < currentSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    result[level].Add(currentNode.val);

                    if(currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
                level++;
            }
        }
    }
}
