using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class ReOrderLinkedList
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            ReorderList(head);
        }

        private static void ReorderList(ListNode head)
        {
            if (head.next == null)
                return;

            //Step 1: Find middle
            ListNode fastNode = head;
            ListNode slowNode = head;
            while (fastNode != null && fastNode.next != null)
            {
                fastNode = fastNode.next.next;
                slowNode = slowNode.next;
            }
            //Step 2: Reverse the linked List
            ListNode current = slowNode;
            ListNode previous = null;
            while (current != null)
            {
                var temp = current.next;

                current.next = previous;
                previous = current;
                current = temp;
            }

            //Step 3: Re arrange the list
            ListNode first = head;
            ListNode second = previous;

            while (second.next != null)
            {
                var temp = first.next;
                first.next = second;
                first = temp;

                temp = second.next;
                second.next = first;
                second = temp;
            }
            throw new NotImplementedException();
        }
    }
}
