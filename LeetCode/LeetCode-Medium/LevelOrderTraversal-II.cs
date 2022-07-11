using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class LevelOrderTraversal_II
    {
        public static IList<IList<int>> result = new List<IList<int>>();

        public static void Main(string[] args)
        {
            int?[] input = { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeHelper.BuildTree(input);
            IList<IList<int>> result = LevelOrderBottom(root);
        }

        private static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if(root == null)
                return result;
            ProcessLevelOrderBottomDSF(root, 0);
            result = result.Reverse().ToList();
            return result;

        }

        private static void ProcessLevelOrderBottomDSF(TreeNode root, int level)
        {
            if (result.Count == level)
                result.Insert(0, new List<int>());

            var innerList = result[level];
            innerList.Add(root.val);

            if(root.left != null)
                ProcessLevelOrderBottomDSF(root.left, level+1);
            if(root.right != null)
                ProcessLevelOrderBottomDSF(root.right, level+1);
        }
    }
}
