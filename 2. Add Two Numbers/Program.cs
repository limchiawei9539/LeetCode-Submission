using System;
using System.Collections.Generic;

namespace _2._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode() { val = 2, next = new ListNode() { val = 4, next = new ListNode() { val = 3 } } };
            ListNode l2 = new ListNode() { val = 5, next = new ListNode() { val = 6, next = new ListNode() { val = 4 } } };
            Console.WriteLine(AddTwoNumbers(l1, l2));
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = 0;
                this.next = next;
            }
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            while (l1.val != null)
            {
                list1.Add(l1.val);
                if (l1.next != null)
                {
                    l1 = l1.next;
                }
                else
                {
                    break;
                }
            }

            while (l2.val != null)
            {
                list2.Add(l2.val);
                if (l2.next != null)
                {
                    l2 = l2.next;
                }
                else
                {
                    break;
                }
            }

            list1.Reverse();
            list2.Reverse();

            var num1 = String.Empty;
            var num2 = String.Empty;

            foreach (var l in list1)
            {
                num1 += l;
            }

            foreach (var l in list2)
            {
                num2 += l;
            }

            var sum = System.Numerics.BigInteger.Parse(num2) + System.Numerics.BigInteger.Parse(num1);
            var sumstring = sum.ToString();

            //
            ListNode ll = null;
            for (int i = 0; i < sumstring.Length; i++)
            {
                ll = new ListNode(Int32.Parse(sumstring[i].ToString()), ll);
            }
            return ll;
        }
    }
}
