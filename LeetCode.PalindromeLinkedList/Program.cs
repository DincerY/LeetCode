Solution solution = new();
solution.IsPalindrome(new ListNode(1,new ListNode(2,new ListNode(2,new ListNode(1)))));
solution.IsPalindrome(new ListNode(1,new ListNode(2)));

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
        return false;
    }
}