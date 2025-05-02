Solution solution = new();
solution.IsPalindrome2(new ListNode(1,new ListNode(2,new ListNode(2,new ListNode(1)))));
solution.IsPalindrome2(new ListNode(1,new ListNode(2)));

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
    public bool IsPalindrome(ListNode head)
    {
        var temp = head;
        int index = 0;
        int len = 0;
        void Recursion(ListNode node)
        {
            if (node == null)
            {
                return;
            }

            len++;
            Recursion(node.next);
            if (index <= len)
            {
                if (temp.val == node.val)
                {
                    temp = temp.next;
                    index++;
                }
            }
        }
        Recursion(head);
        return index == len;
    }
}

public partial class Solution
{
    public bool IsPalindrome2(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        // find the middle (slow)
        while (fast != null && fast.next != null) 
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        // reverse second half
        ListNode prev = null;
        while (slow != null) 
        {
            ListNode tmp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = tmp;
        }

        // check palindrome
        ListNode left = head;
        ListNode right = prev;
        while (right != null) 
        {
            if (left.val != right.val) 
            {
                return false;
            }
            left = left.next;
            right = right.next;
        }
        return true;
    }
}