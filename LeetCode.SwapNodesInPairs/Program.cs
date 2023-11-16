using System;
using System.Collections.Generic;

namespace LeetCode.SwapNodesInPairs
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
            list.next.next.next.next.next = new ListNode(6);
            Solution solution = new();
            var a =solution.SwapPairs(list);
            Console.WriteLine(a);
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
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }
            ListNode headNode = head;
            ListNode tailNode = head.next;
            
            headNode.next = tailNode.next;

            tailNode.next = headNode;

            //as a result of change
            headNode = tailNode;
            headNode.next.next = SwapPairs(headNode.next.next);

            

            return headNode;
        }
    }
}























