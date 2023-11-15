using System;
using System.Net.NetworkInformation;

namespace LeetCode.MergeTwoSortedLists
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            ListNode list1 = new(1);
            list1.next = new(2);
            list1.next.next = new(3);

            ListNode list2 = new(4);
            list2.next = new(8);
            list2.next.next = new ListNode(11);

            var a = solution.MergeTwoLists(list1, list2);

            Solutionn solutionn = new();
            var b = solutionn.MergeTwoLists(list1, list2);
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode newNode = new();
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            if (list1.val < list2.val)
            {
                newNode.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                newNode.val = list2.val;
                list2 = list2.next;
            }

            newNode.next = Merge(list1, list2, newNode.next);
            

            return newNode;
        }

        private ListNode Merge(ListNode list1, ListNode list2, ListNode newNode)
        {
            newNode = new ListNode();
            if (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    newNode.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    newNode.val = list2.val;
                    list2 = list2.next;
                }

                newNode.next = Merge(list1, list2, newNode.next);
            }
            else if (list1 != null)
            {
                newNode = list1;
            }
            else if (list2 != null)
            {
                newNode = list2;
            }
            else
            {
                return null;
            }

            return newNode;
        }
    }
    
    
    public class Solutionn {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            
            if (list2 == null)
            {
                return list1;
            }
            
            ListNode head = null;
            ListNode tail = null;

            while (list1 != null && list2 != null)
            {
                ListNode node;
                
                if (list1.val <= list2.val)
                {
                    node = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    node = new ListNode(list2.val);
                    list2 = list2.next;
                }

                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail!.next = node;
                    tail = tail.next;
                }
            }
      
            
            if (list1 == null)
            {
                tail.next = list2;
                return head;
            }

            if (list2 == null)
            {
                tail.next = list1;
                return head;
            }

            return head;
        }
    }
}







































