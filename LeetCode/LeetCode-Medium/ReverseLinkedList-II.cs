using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class ReverseLinkedList_II
    {
        public static ListNode successor = null;
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            ListNode result = Reverse(head, m, n);

            Console.WriteLine(LinkedListHelper.Display(result));
        }

        private static ListNode Reverse(ListNode head, int m, int n)
        {
            if(m == 1)
            {
                return ReverseFirstN(head, n);
            }
            head.next = Reverse(head.next, m-1, n-1);
            return head;
        }

        private static ListNode ReverseFirstN(ListNode head, int n)
        {
            if(n == 1)
            {
                successor = head.next;
                return head;
            }

            ListNode last = ReverseFirstN(head.next, n -1);
            head.next.next = head;
            head.next = successor;

            return last;
        }
    }
}
