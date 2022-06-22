using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class AddTwoNumbersLL
    {
        public static void Main(string[] args)
        {
            //ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            //ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            //Debug and check why it is not working
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            ListNode l3 = AddTwoNumbers(l1, l2);
            for (ListNode l = l3; l!= null; l = l.next)
            {
                Console.WriteLine(l.val + "-> ");
            }
        }

        //Code duplication, Reverse  printed
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
                            temp = new ListNode(currentSum);

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
                            temp = new ListNode(currentSum);


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
                        temp = new ListNode(currentSum);

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

            return result;
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
