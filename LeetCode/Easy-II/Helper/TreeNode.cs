using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II.Helper
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value=0, TreeNode left=null, TreeNode right=null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        public override string ToString()
        {
            return $"{ this.Value }";
        }
    }
}
