using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class IncreasingOrderSearchTree
    {
        public static List<TreeNode> list = new List<TreeNode>();
        public static void Main(string[] args)
        {
            int?[] arr = new int?[] { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9 };
            TreeNode root = TreeHelper.BuildTree(arr);

            TreeNode result = IncreasingBST(root);
            InorderDisplay(result);
        }

        private static void InorderDisplay(TreeNode result)
        {
            if(result == null)
            {
                Console.Write(" null, ");
                return;
            }
            InorderDisplay(result.left);
            Console.Write($"{result.val}, ");
            InorderDisplay(result.right);
        }

        private static TreeNode IncreasingBST(TreeNode root)
        {
            InOrder(root);
            TreeNode result = new TreeNode(0);
            TreeNode current = result;
            foreach(TreeNode item in list)
            {
                current.right = new TreeNode(item.val);
                current.left = null;
                current = current.right;
            }
            return result.right;
        }

        private static void InOrder(TreeNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            list.Add(root);
            InOrder(root.right);
            
        }
    }
}
