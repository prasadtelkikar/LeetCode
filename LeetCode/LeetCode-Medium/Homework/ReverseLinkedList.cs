using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium.Homework
{
    public class ReverseLinkedList
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            var reverseListHead = ReverseLL(head);

            Console.WriteLine(LinkedListHelper.Display(reverseListHead));
        }

        private static ListNode ReverseLL(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode last = ReverseLL(head.next);
            head.next.next = head;
            head.next = null;
            return last;
        }
    }
}
