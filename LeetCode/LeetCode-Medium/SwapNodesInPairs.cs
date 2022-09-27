using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class SwapNodesInPairs
    {
        public static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(inputArr);
            ListNode result = SwapPairs(head);
            LinkedListHelper.Display(result);
        }

        private static ListNode SwapPairs(ListNode head)
        {
            if (head == null)
                return head;
            if (head.next == null)
                return head;

            ListNode first = head;
            ListNode second = head.next;
            ListNode third = second.next;

            head = second;
            second.next = first;
            first.next = SwapPairs(third);

            return head;
        }
    }
}
