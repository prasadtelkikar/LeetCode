using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class SortedLinkedListToBST
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            TreeNode root = SortedListToBST(head);
        }

        private static TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
                return null;

            return BinarySearch(head, null);
        }

        private static TreeNode BinarySearch(ListNode head, ListNode tail)
        {
            if (head == tail)
                return null;

            ListNode fastNode = head;
            ListNode slowNode = head;

            while(fastNode != null && fastNode.next != null)
            {
                fastNode = fastNode.next.next;
                slowNode = slowNode.next;
            }

            TreeNode root = new TreeNode(slowNode.val);
            root.left = BinarySearch(head, slowNode);
            root.right = BinarySearch(slowNode.next, tail);

            return root;
        }
    }
}
