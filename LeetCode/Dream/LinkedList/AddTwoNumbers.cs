using System;
using System.Collections.Generic;
using System.Text;

namespace Dream.LinkedList
{
    public class AddTwoNumbers
    {
        public static void Main(string[] args)
        {
            ListNode firstNumber = new ListNode(9, new ListNode(9, new ListNode(9)));
            ListNode secondNumber = new ListNode(1, new ListNode(1));

            ListNode result = AddTwoNumbersFunc(firstNumber, secondNumber);
            for (ListNode i = result; i != null; i=i.next)
            {
                Console.Write($"{i.val}->");
            }
            Console.WriteLine("null");

        }

        private static ListNode AddTwoNumbersFunc(ListNode firstNumber, ListNode secondNumber)
        {
            int carry = 0;
            ListNode head = new ListNode(0);
            ListNode currentNode = head;
            while (firstNumber != null || secondNumber!= null || carry != 0)
            {
                //Calculate sum
                var first = firstNumber != null ? firstNumber.val : 0;
                var second = secondNumber != null ? secondNumber.val : 0;
                int sum = first + second + carry;
                
                //Store it into a linked list, head should be preserved.
                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;

                //Calculate left-over carry
                carry = sum / 10;
                
                //Increment firstNumber and secondNumber Linked list
                firstNumber = firstNumber != null ? firstNumber.next : null;
                secondNumber = secondNumber != null ? secondNumber.next : null;
            }
            return head.next;
        }
    }

    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int val = 0, ListNode next = null)
       {
            this.val = val;
            this.next = next;
       }
    }
}
