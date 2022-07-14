using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class MaxLevelSumBinaryTree
    {
        public static void Main(string[] args)
        {
            int?[] input = { 1, 7, 0, 7, -8, null, null };
            TreeNode root = TreeHelper.BuildTree(input);

            int level = MaxLevelSum(root);
            Console.WriteLine(level);   

        }

        //Solve it by DSF tomorrow
        private static int MaxLevelSum(TreeNode root)
        {
            List<LevelWithSum> result = BreadthFirstSearch(root);
            int maxSum = int.MinValue;

            int level = 0;
            foreach (var re in result)
            {
                if (re.Sum > maxSum)
                {
                    maxSum = re.Sum;
                    level = re.Level;
                }
            }
            return level;
        }

        private static List<LevelWithSum> BreadthFirstSearch(TreeNode root)
        {
            List<LevelWithSum> result = new List<LevelWithSum>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            int sum = 0;
            int level = 1;
            result.Add(new LevelWithSum(1, root.val));
            while(queue.Count > 1)
            {
                TreeNode node = queue.Dequeue();
                if(node == null)
                {
                    level++;
                    result.Add(new LevelWithSum(level, sum));
                    queue.Enqueue(null);
                    sum = 0;
                    continue;
                }

                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                    sum += node.left.val;
                }
                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                    sum += node.right.val;
                }
            }

            return result;
        }
    }
    public class LevelWithSum
    {
        public int Level { get; set; }
        public int Sum { get; set; }
        public LevelWithSum(int level, int sum)
        {
            this.Level = level;
            this.Sum = sum;
        }
    }
}
