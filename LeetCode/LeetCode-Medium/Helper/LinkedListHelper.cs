using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium.Helper
{
    public class LinkedListHelper
    {
        public static ListNode BuildLinkedList(int[] arr)
        {
            ListNode head = null;
            for(int i = 0; i < arr.Length; i++)
            {
                if(head == null)
                {
                    head = new ListNode(arr[i]);
                }
                else
                {
                    ListNode currentNode = head;
                    while (currentNode.next != null)
                        currentNode = currentNode.next;
                    currentNode.next = new ListNode(arr[i]);
                }
            }
            return head;
        }

        public static string Display(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            if(head == null)
                return String.Empty;
            ListNode current = head;
            while (current != null)
            {
                if (current.next != null)
                    sb.Append($"{current.val} -> ");
                else
                    sb.Append($"{current.val} -> null");
                current = current.next;
            }
            return sb.ToString();
        }
    }
}
