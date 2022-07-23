using Easy_II.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class PalindromeLinkedList
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = LinkedListHelper.BuildLinkedList(arr);
            bool result = IsPalindrome(head);
            Console.WriteLine(result);
        }

        private static bool IsPalindrome(ListNode head)
        {
            ListNode fastPointer = head;
            ListNode slowPointer = head;
            if (head == null || head.next == null)
                return true;

            while(fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }
            Console.WriteLine(slowPointer.val);
            Stack<ListNode> stack = new Stack<ListNode>();
            while(slowPointer != null)
            {
                stack.Push(slowPointer);
                slowPointer = slowPointer.next;
            }

            ListNode current = head;
            while(stack.Count > 0)
            {
                if (current == null && stack.Count > 0)
                    return false;
                if (stack.Count == 0 && current != null)
                    return false;

                ListNode stackPop = stack.Pop();
                if(stackPop.val != current.val)
                    return false;
                current = current.next;
            }

            return true;
        }
    }
}
