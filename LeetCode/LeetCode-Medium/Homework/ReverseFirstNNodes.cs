using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium.Homework
{
    public class ReverseFirstNNodes
    {
        public static ListNode successor = null;
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            ListNode reverseHead = ReverseFirstNNodesLL(head, n);

            Console.WriteLine(LinkedListHelper.Display(reverseHead));
        }

        private static ListNode ReverseFirstNNodesLL(ListNode head, int n)
        {
            if (head == null)
                return head;

            if(n == 1)
            {
               successor = head.next;
                return head;
            }

            ListNode last = ReverseFirstNNodesLL(head.next, n-1);
            head.next.next = head;
            head.next = successor;

            return last;
        }
    }
}
