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
                                next = null, val = 5
                            },
                            val = 4
                        },
                        val = 3
                    },
                    val = 2
                },
                val = 1
            };


            ListNode head2 = new ListNode();
            head2.val = 1;
            head2.next = new ListNode();
            head2.next.val = 2;
            ListNode result = solution.RemoveNthFromEnd(head2, 2);


            Solutionn sol = new();
            sol.Remove(head, 2);
        }
    }

    //[8,2,8,7]  n=2
    //[4,5,4]   n=1


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
            int count = CountOfElementList(head);
            int targetNode = count - n;

            ListNode prev = null;
            ListNode cur = head;

            if (cur.next == null)
            {
                return null;
            }

            for (int i = 0; i < targetNode; i++)
            {
                prev = cur;
                cur = cur.next;
            }

            if (targetNode == 0)
            {
                return cur.next;
            }


            if (cur.next == null)
            {
                prev.next = cur.next;
            }


            return head;
        }

        public int CountOfElementList(ListNode head)
        {
            ListNode ptr = head;
            int count = 1;
            while (ptr.next != null)
            {
                ptr = ptr.next;
                count++;
            }

            return count;
        }

        #region RecursiveAlgorithm

        public ListNode RemoveNthFromEndRecursive(ListNode head, int n)
        {
            var i = 0;

            ListNode RemoveNthFromEndHelper(ListNode head, int n)
            {
                if (head == null) return null;

                head.next = RemoveNthFromEndHelper(head.next, n);
                i++;
                return (n == i) ? head.next : head;
            }

            return RemoveNthFromEndHelper(head, n);
        }

        #endregion
        
        
        #region DontRun

        //We will not use this algorithm :D;
        public int FindElementValueFromEnd(ListNode head, int a)
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

        #endregion
    }


    public class Solutionn
    {
        
      
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var i = 0;

            ListNode RemoveNthFromEndHelper(ListNode head, int n)
            {
                if (head == null) return null;

                head.next = RemoveNthFromEndHelper(head.next, n);
                i++;
                return (n == i) ? head.next : head;
            }

            return RemoveNthFromEndHelper(head, n);
        }
    }
}















