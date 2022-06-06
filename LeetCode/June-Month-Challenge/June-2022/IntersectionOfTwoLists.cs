using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class IntersectionOfTwoLists
    {
        public static void Main(string[] args)
        {
            //4,1,8,4,5
            ListNode headA = new ListNode(1, new ListNode(9, new ListNode(1, new ListNode(2, new ListNode(4)))));
            ListNode headB = new ListNode(3);
            headB.next = headA.next.next.next;

            ListNode instance = new ListNode();
            var result = instance.GetIntersectionNode(headA, headB);
            for(ListNode i = result; i != null; i = i.next)
                Console.WriteLine(i.val);
        }
    }

    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }

        public ListNode(int value = 0, ListNode nextNode=null)
        {
            this.val = value;
            this.next = nextNode;
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            Stack<ListNode> stackHeadA = new Stack<ListNode>();
            Stack<ListNode> stackHeadB = new Stack<ListNode>();

            for (ListNode t = headA; t != null; t = t.next)
                stackHeadA.Push(t);

            for (ListNode t = headB; t != null; t = t.next)
                stackHeadB.Push(t);

            ListNode temp = null;
            while (true)
            {
                if (stackHeadA.Count == 0 || stackHeadB.Count == 0)
                    return temp;

                var topStackHeadA = stackHeadA.Pop();
                var topStackHeadB = stackHeadB.Pop();

                if (topStackHeadA != topStackHeadB)
                    return temp;
                else
                    temp = topStackHeadA;

                if (topStackHeadA == null || topStackHeadB == null)
                    return temp;
            }
        }
    }
}
