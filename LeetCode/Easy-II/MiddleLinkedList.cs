using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class MiddleLinkedList
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            ListNode result = MiddleNode(head);
        }

        private static ListNode MiddleNode(ListNode head)
        {
            ListNode fastNode = head;
            ListNode slowNode = head;

            while (fastNode != null && fastNode.next != null)
            {
                fastNode = fastNode.next.next;
                slowNode = slowNode.next;
            }
            return slowNode;
        }
    }
}
