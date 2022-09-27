using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class RemoveDuplicateFromSortedList
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);

            ListNode result = DeleteDuplicates(head);
            Console.WriteLine(LinkedListHelper.Display(result));
        }

        private static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode list = head;

            while(list != null)
            {
                if (list.next == null)
                    break;
                if (list.val == list.next.val)
                    list.next = list.next.next;
                else
                    list = list.next;
            }

            return head;
        }
    }
}
