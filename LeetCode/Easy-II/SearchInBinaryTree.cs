using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class SearchInBinaryTree
    {
        public static TreeNode result = null;
        public static void Main(string[] args)
        {

            int?[] arr = new int?[] { 4, 2, 7, 1, 3 };
            int nodeValue = 2;

            TreeNode root = TreeHelper.BuildTree(arr);
            TreeNode output = SearchBST(root, nodeValue);
            TreeHelper.InOrderDisplay(output);
        }

        private static TreeNode SearchBST(TreeNode root, int val)
        {
            InOrder(root, val);
            return result;
        }


        private static void InOrder(TreeNode root, int val)
        {
            if (root == null)
                return;
            if(root.val == val)
            {
                result = root;
                return;
            }

            if(result == null)
            {
                InOrder(root.left, val);
                InOrder(root.right, val);
            }
        }
    }
}
