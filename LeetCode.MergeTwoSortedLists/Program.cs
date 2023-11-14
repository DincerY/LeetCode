using System.Net.NetworkInformation;

namespace LeetCode.MergeTwoSortedLists
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            ListNode list1 = new(1);
            list1.Next = new(2);
            list1.Next.Next = new(3);

            ListNode list2 = new(5);
            list2.Next = new(8);
            list2.Next.Next = new ListNode(9);

            solution.MergeTwoLists(list1,list2);
        }
    }


    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
    
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            Merge(list1,list2);



            return null;
        }

        private ListNode Merge(ListNode list1, ListNode list2)
        {
            ListNode newNode = new();
            ListNode newNodeHead = newNode;
            if (list1.Val<list2.Val)
            {
                newNode.Val = list1.Val;
                newNode.Next = new();
                list1 = list1.Next;
            }
            else
            {
                newNode.Val = list1.Val;
                newNode.Next = null;
                list2 = list2.Next;
            }
            while (list1 != null) 
            {
                if (list1.Val<list2.Val)
                {
                    newNode.Next.Val = list1.Val;
                    newNode.Next.Next = new();
                    list1 = list1.Next;
                }
            }

            while (list2 != list1)
            {
                if (list2.Val<list1.Val)
                {
                    newNode.Next.Val = list2.Val;
                    newNode.Next.Next = new();
                    list2 = list2.Next;
                }
            }

            return null;

        }
    }
} 














































