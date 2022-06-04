using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MergeTwoLists
    {
        public static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(5))));
            ListNode listNode2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var result = MergeTwoListsFunc(listNode1, listNode2);
            for(var item = result; item != null; item = item.next)
                Console.Write(item.val + "-> ");
            Console.WriteLine("null");
        }

        public ListNode MergeTwoListsFunc(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            ListNode result;
            if (list1.val < list2.val)
            {
                result = list1;
                result.next = MergeTwoListsFunc(list1.next, list2);
            }
            else
            {
                result = list2;
                result.next = MergeTwoListsFunc(list1, list2.next);
            }
            return result;
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
