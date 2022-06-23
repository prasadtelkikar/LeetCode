using System;

namespace Easy_Problems
{
    public class AddTwoNumbersLL
    {
        public static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            ListNode l3 = AddTwoNumbers(l1, l2);
            for (ListNode l = l3; l!= null; l = l.next)
            {
                Console.Write(l.val + "-> ");
            }
        }


        //Refactor the code
        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            int carry = 0;
            for (int i = 0; i < 100; i++)
            {
                ListNode temp = null;
                int currentSum = 0;
                if (l1 == null && l2 == null)
                    break;
                else if (l1 == null)
                {
                    while(l2 != null)
                    {
                        currentSum = l2.val + carry;
                        if(currentSum > 9)
                        {
                            var lastDigit = currentSum % 10;
                            carry = currentSum / 10;
                            temp = new ListNode(lastDigit);
                        }
                        else
                        {
                            temp = new ListNode(currentSum);
                            carry = 0;
                        }

                        if (result == null)
                            result = temp;
                        else
                        {
                            temp.next = result;
                            result = temp;
                        }
                        l2 = l2.next;
                    }
                }    
                else if (l2 == null)
                {
                    while(l1 != null)
                    {
                        currentSum = l1.val + carry;
                        if (currentSum > 9)
                        {
                            var lastDigit = currentSum % 10;
                            carry = currentSum / 10;
                            temp = new ListNode(lastDigit);
                        }
                        else
                        {
                            temp = new ListNode(currentSum);
                            carry = 0;
                        }

                        if (result == null)
                            result = temp;
                        else
                        {
                            temp.next = result;
                            result = temp;
                        }
                        l1 = l1.next;
                    }
                }
                else
                {
                    currentSum = l1.val + l2.val + carry;
                    if (currentSum > 9)
                    {
                        var lastDigit = currentSum % 10;
                        carry = currentSum / 10;
                        temp = new ListNode(lastDigit);
                    }
                    else
                    {
                        carry = 0;
                        temp = new ListNode(currentSum);
                    }

                    l1 = l1.next;
                    l2 = l2.next;

                    if (result == null)
                        result = temp;
                    else
                    {
                        temp.next = result;
                        result = temp;
                    }
                }


            }
            if(carry != 0)
            {
                var temp = new ListNode(carry);
                temp.next = result;
                result = temp;
            }

            result = Reverse(result);
            return result;
        }

        private static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode currentNode = head;
            while(currentNode != null)
            {
                ListNode nextNode = currentNode.next;
                currentNode.next = prev;
                prev = currentNode;
                currentNode = nextNode;
            }
            return prev;
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
}
