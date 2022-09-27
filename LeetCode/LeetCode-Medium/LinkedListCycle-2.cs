using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class LinkedListCycle_2
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 0, -4 };
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            head.next.next.next.next = head.next;

            ListNode result = DetectCycle(head);

        }

        private static ListNode DetectCycle(ListNode head)
        {
            if(head == null || head.next == null)
                return head;
            ListNode fastNode = head;
            ListNode slowNode = head;
            while(fastNode != null && fastNode.next != null)
            {
                fastNode = fastNode.next.next;
                slowNode = slowNode.next;
                if (fastNode == slowNode)
                {
                    ListNode entry = head;
                    while(slowNode != entry)
                    {
                        slowNode = slowNode.next;
                        entry = entry.next;
                    }
                    return slowNode;
                }
            }
            return null;
        }
    }
}
