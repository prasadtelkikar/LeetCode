using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class LinkedListCycle
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 0, -4 };
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            head.next.next.next.next = head.next;

            bool hasCycle = HasCycle(head);
        }

        private static bool HasCycle(ListNode head)
        {
            if(head == null || head.next == null)
                return false;
            ListNode fastNode = head;
            ListNode slowNode = head;

            while(fastNode != null || fastNode.next != null)
            {
                fastNode = fastNode.next.next;
                slowNode = slowNode.next;

                if (slowNode == fastNode)
                    return true;
            }
            return false;
        }
    }
}
