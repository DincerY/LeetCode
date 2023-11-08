using System;
using System.CodeDom;
using System.Security.Cryptography;

namespace LeetCode.RemoveNthNode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            ListNode head = new ListNode()
            {
                next = new ListNode()
                {
                    next = new ListNode()
                    {
                        next = new ListNode()
                        {
                            next = new ListNode()
                            {
                                next = null
                                , val = 5
                            }, val = 4
                        }, val = 3
                    },
                    val = 2
                },
                val = 1
            };


            ListNode head2 = new ListNode();
            head2.val = 4;
            head2.next = new ListNode();
            head2.next.val = 5;
            head2.next.next = new ListNode();
            head2.next.next.val = 4;
            ListNode result = solution.RemoveNthFromEnd(head2, 1);
            var b = solution.FindElementValueFromEnd(head2, 2);
        
            
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }
            else
            {
                ListNode prev = null;
                ListNode curr = head;
                int deleteValue = FindElementValueFromEnd(head, n);
                while (curr.next !=null)
                {
                    prev = curr;
                    curr = curr.next;
                    if (curr.val == deleteValue)
                    {
                        prev.next = curr.next;
                        return head;
                    }

                    if (curr.next == null && prev.val == deleteValue)
                    {
                        return curr;
                    }
                    if (curr.next != null && prev.val == deleteValue)
                    {
                        return curr;
                    }
               
                }

                return null;
            }
            
        }

     
        
        public int FindElementValueFromEnd(ListNode head,int a)
        {
            ListNode slowPtr = head;
            ListNode fastPtr = head;

            int count = 0;
            while (count < a)
            {
                if (fastPtr == null)
                    throw new InvalidOperationException("Bağlı liste yeterince uzun değil.");
            
                fastPtr = fastPtr.next;
                count++;
            }

            while (fastPtr != null)
            {
                fastPtr = fastPtr.next;
                slowPtr = slowPtr.next;
            }

            return slowPtr.val;
        }
    }


}  















