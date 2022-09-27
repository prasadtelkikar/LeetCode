using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class MergeSortedKLists
    {
        public static void Main(string[] args)
        {
            ListNode head1 = LinkedListHelper.BuildLinkedList(new int[] { 1, 4, 5 });
            ListNode head2 = LinkedListHelper.BuildLinkedList(new int[] { 1, 3, 4 });
            ListNode head3 = LinkedListHelper.BuildLinkedList(new int[] { 2, 6 });

            ListNode[] lists = new ListNode[] {head1, head2, head3};
            ListNode result = MergeKLists(lists);

            Console.WriteLine(LinkedListHelper.Display(result));
        }

        private static ListNode MergeKLists(ListNode[] lists)
        {
            List<int> bucket = new List<int>();
            foreach(ListNode head in lists)
            {
                ListNode current = head;
                while(current != null)
                {
                    bucket.Add(current.val);
                    current = current.next;
                }
            }

            bucket.Sort();

            ListNode result = new ListNode();
            ListNode currentResult = result;
            foreach (var data in bucket)
            {
                currentResult.next = new ListNode(data);
                currentResult = currentResult.next;
            }
            return result.next;
        }
    }
}
