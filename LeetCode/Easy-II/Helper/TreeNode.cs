using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II.Helper
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value=0, TreeNode left=null, TreeNode right=null)
        {
            this.val = value;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return $"{ this.val }";
        }
    }
}
