using System;

namespace Easy_II
{
    public class RootEqualsSumOfChildren
    {
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10, new TreeNode(5), new TreeNode(5));
            Console.WriteLine(root.val == root.left.val + root.right.val);
        }

        private class TreeNode
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
    }
}
