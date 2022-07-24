using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class LowestCommonAnscestor
    {
        public static void Main(string[] args)
        {
            int?[] input = { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            int p = 2;
            int q = 8;
            TreeNode root = TreeHelper.BuildTree(input);
            TreeNode result = LowestCommonAncestor(root, p, q);
        }

        private static TreeNode LowestCommonAncestor(TreeNode root, int p, int q)
        {
            TreeNode currentNode = root;
            while(currentNode != null)
            {
                int parentNodeValue = currentNode.val;
                if (p > parentNodeValue && q > parentNodeValue)
                    currentNode = currentNode.right;
                else if (p < parentNodeValue && q < parentNodeValue)
                    currentNode = currentNode.left;
                else
                    return currentNode;
            }
            return null;
        }

    }
}
