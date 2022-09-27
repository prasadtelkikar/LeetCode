using LeetCode_Medium.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class RemoveDuplicatesLL
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            ListNode result = DeleteDuplicateII(head);
            Console.WriteLine(LinkedListHelper.Display(result));
        }

        private static ListNode DeleteDuplicate(ListNode head)
        {
            if (head == null)
                return head;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            while (head != null)
            {
                if (keyValuePairs.ContainsKey(head.val))
                    keyValuePairs[head.val]++;
                else
                    keyValuePairs.Add(head.val, 1);
                head = head.next;
            }
            ListNode result = null;
            foreach(var item in keyValuePairs)
            {
                if (result == null)
                    result = new ListNode(item.Key);
                else
                {
                    var currentNode = result;
                    while(currentNode.next != null)
                        currentNode = currentNode.next;
                    if(item.Value == 1)
                        currentNode.next = new ListNode(item.Key);
                   
                }
            }
            return result;
        }

        private static ListNode DeleteDuplicateII(ListNode head)
        {
            ListNode sentinal = new ListNode(0, head);
            ListNode pred = sentinal;

            while(head != null)
            {
                if (head.next != null && head.val == head.next.val)
                {
                    while (head.next != null && head.val == head.next.val)
                        head = head.next;

                    pred.next = head.next;
                }
                else
                {
                    pred = pred.next;
                }
                head = head.next;
            }
            return sentinal.next;
        }
    }
}
