using System;
using System.Collections.Generic;

Solution solution = new();
solution.MergeKLists2(new ListNode[]
{
    new ListNode(1,new ListNode(4,new ListNode(5))),
    new ListNode(1,new ListNode(3,new ListNode(4))),
    new ListNode(2,new ListNode(6)),
});

Console.WriteLine("Hello, World!");

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


public partial class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0 || lists[0] == null)
        {
            return null;
        }
        Queue<ListNode> queue = new();
        List<int> minList = new List<int>();
        int nullValue = 0;
        while (lists != null && nullValue < lists.Length)
        {
            nullValue = 0;
            int min = 2100000;
            int index = 0;
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null)
                {
                    nullValue++;
                    continue;
                }
                if (lists[i].val < min)
                {
                    min = lists[i].val;
                    index = i;
                }
            }

            if (nullValue >= lists.Length)
            {
                break;
            }
            minList.Add(lists[index].val);
            lists[index] = lists[index].next;
         
        }

        ListNode node = new ListNode(minList[0]);
        ListNode head = node;
        for (int i = 1; i < minList.Count; i++)
        {
            node.next = new ListNode(minList[i]);
            node = node.next;
        }
        return head;
    }
}

public partial class Solution {
    public ListNode MergeKLists2(ListNode[] lists) {
        if (lists.Length == 0)
        {
            return null;
        }
        
        while (lists.Length > 1)
        {
            var mergedLists = new ListNode[(lists.Length + 1) / 2];
            for (int i = 0; i < lists.Length; i += 2)
            {
                var l1 = lists[i];
                var l2 = (i + 1 < lists.Length) ? lists[i + 1] : null;
                mergedLists[i/2] = (MergeLists(l1, l2));
            }
            lists = mergedLists;
        }
        
        return lists[0];
    }
    
    public ListNode MergeLists(ListNode l1, ListNode l2)
    {
        var sorted = new ListNode();
        var current = sorted;
        
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }
        
        if (l1 != null)
        {
            current.next = l1;
        } else 
        {
            current.next = l2;
        }
        
        return sorted.next;
    }
}