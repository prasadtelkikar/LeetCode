using System;
using System.Collections.Generic;
using System.Text;

namespace Dream.LinkedList
{
    public class RemoveNthNodeFromEnd
    {
        public static void Main(string[] args)
        {
            //ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode head = new ListNode(1);
            int n = 1;
            ListNode output = RemoveNthFromEnd(head, n);
            for (ListNode i = output; i != null; i=i.next)
                Console.Write($"{i.val}->");
            Console.WriteLine("null");

        }

        private static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null)
                return null;

            ListNode output = new ListNode(0);
            output.next = head;
            ListNode firstNode = output;
            ListNode secondNode = output;
            for (int i = 1; i <= n+1; i++)
                firstNode = firstNode?.next ?? null;
            while(firstNode != null)
            {   
                firstNode = firstNode.next;
                secondNode = secondNode.next;
            }
            secondNode.next = secondNode?.next?.next;
            return output.next;
        }

        private static ListNode RemoveNthFromEndNaive(ListNode head, int n)
        {
            ListNode output = new ListNode(0);
            output.next = head;
            int length = 0;
            for (ListNode i = head; i != null; i=i.next, length++) ;
            int indexRemoveFromFirst = length - n;

            ListNode temp = output;
            for(int i = 0; i < length; i++)
                temp = temp.next;

            temp.next = temp.next.next;

            return output.next;
        }
    }
}
