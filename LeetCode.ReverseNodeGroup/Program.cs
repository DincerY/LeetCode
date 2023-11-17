using System;
using System.CodeDom;

namespace LeetCode.ReverseNodeGroup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);
            list.next.next.next.next = new ListNode(5);

            Solution solution = new();
            var a =solution.ReverseKGroup(list, 2);
            Console.WriteLine();
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

    public class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k == 1)
            {
                return head;
            }
            
            int count = 0;
            ListNode current = head;
            while (current != null && count < k)
            {
                current = current.next;
                count++;
            }

            if (count < k)
            {
                return head; 
            }

       
            ListNode prev = null;
            ListNode next = null;
            current = head;
            for (int i = 0; i < k; i++)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            
            head.next = ReverseKGroup(current, k);

            return prev; 
        }
    }
}


























