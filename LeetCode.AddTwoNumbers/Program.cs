using System;

namespace LeetCode.AddTwoNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution s = new Solution();
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            ListNode node = l1.next;
            node.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            ListNode node2 = l2.next;
            node2.next = new ListNode(4);
            ListNode resultNode = s.AddTwoNumbers(l1, l2);
            Console.Read();
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

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode result = new ListNode(0);
                ListNode ptr = result;

                int carry = 0;

                while (l1 != null || l2 != null)
                {
                    int sum = 0 + carry;
                    if (l1 != null)
                    {
                        sum += l1.val;
                        l1 = l1.next;
                    }

                    if (l2 != null)
                    {
                        sum += l2.val;
                        l2 = l2.next;
                    }

                    carry = sum / 10;
                    sum = sum % 10;
                    ptr.next = new ListNode(sum);
                    ptr = ptr.next;
                }

                if (carry == 1) 
                    ptr.next = new ListNode(1);

                return result.next;
            }
        }
    }
}