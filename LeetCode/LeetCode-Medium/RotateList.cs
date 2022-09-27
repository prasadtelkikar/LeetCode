using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class RotateList
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            int k = Convert.ToInt32(Console.ReadLine());

            ListNode result = RotateRight(head, k);
        }

        private static ListNode RotateRight(ListNode head, int k)
        {
            if(head == null || k == 0)
                return head;

            ListNode current = head;
            int length = 1;
            while(current.next != null)
            {
                current = current.next;
                length++;
            }
            //Make LL as circular
            current.next = head;

            //skip first length % k
            k = k % length;
            for (int i = 0; i < length - k; i++)
                current = current.next;

            //Make next element as head
            head = current.next;
            //null set
            current.next = null;
            return head;
        }

    }
}
