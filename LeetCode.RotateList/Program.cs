Solution solution = new();
solution.RotateRight(new ListNode(1)
{
    next = new ListNode(2)
    {
        next = new ListNode(3)
        {
            next = new ListNode(4)
            {
                next = new ListNode(5)
            }
        }
    }
}, 2);


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

public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        for (int i = 0; i < k; i++)
        {
            var first = head;
            ListNode last = null;
            while (head.next != null)
            {
                if (head.next.next == null)
                {
                    last = head.next;
                    head.next = null;
                    break;
                }
                head = head.next;
            }

            last.next = first;
            head = last;
        }
   
        return head;
    }
}