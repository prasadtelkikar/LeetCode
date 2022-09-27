using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class LinkedListPartition
    {
        public static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            ListNode head = LinkedListHelper.BuildLinkedList(inputArr);
            ListNode result = Partition(head, k);
            
            Console.WriteLine(LinkedListHelper.Display(head));
        }

        private static ListNode Partition(ListNode head, int x)
        {
            ListNode beforeHead = new ListNode();
            ListNode afterHead = new ListNode();
            ListNode before = beforeHead;
            ListNode after = afterHead;

            for (ListNode current = head; current != null; current = current.next)
            {
                if (current.val < x)
                {
                    before.next = current;
                    before = before.next;
                }
                else
                {
                    after.next = current;
                    after = after.next;
                }
            }
            after.next = null;
            before.next = afterHead.next;
            return beforeHead.next;
        }
    }
}
