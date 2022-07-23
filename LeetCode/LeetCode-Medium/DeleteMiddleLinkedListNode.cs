using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class DeleteMiddleLinkedListNode
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            ListNode result = DeleteMiddle(head);
        }

        private static ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null)
                return null;

            ListNode fastNode = head;
            ListNode slowNode = head;
            ListNode previousNode = head;
            while (fastNode != null && fastNode.next != null)
            {
                previousNode = slowNode;
                fastNode = fastNode.next.next;
                slowNode = slowNode.next;
            }
            Console.WriteLine(slowNode.val);
            Console.WriteLine(previousNode.val);
            previousNode.next = slowNode.next;

            return head;
        }
    }
}
