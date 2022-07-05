using System;
using System.Collections.Generic;
using System.Text;

namespace Dream.LinkedList
{
    public class MergeTwoSortedLL
    {
        public static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            ListNode result = MergeTwoLists(list1, list2);
            for (ListNode i = result; i != null; i = i.next)
                Console.Write($"{i.val}->");
            Console.WriteLine();
        }

        private static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode(0);
            ListNode currentIterator = result;
            while (list1 != null || list2 != null)
            {
                int currentList1Value = list1?.val ?? int.MaxValue;
                int currentList2Value = list2?.val ?? int.MaxValue;

                int minValue = Math.Min(currentList1Value, currentList2Value);
                if(list1 != null && minValue == currentList1Value)
                {
                    currentIterator.next = new ListNode(minValue);
                    currentIterator = currentIterator.next;
                    list1 = list1.next;
                }

                if(list2 != null && minValue == currentList2Value)
                {
                    currentIterator.next = new ListNode(minValue);
                    currentIterator = currentIterator.next;
                    list2 = list2.next;
                }
            }
            return result.next;
        }
    }
}
