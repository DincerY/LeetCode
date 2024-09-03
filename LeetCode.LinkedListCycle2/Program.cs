Solution solution = new();
var head = new ListNode(3);
head.next = new ListNode(2);
head.next.next = new ListNode(0);
head.next.next.next = new ListNode(-4);
head.next.next.next.next = head.next;
solution.DetectCycle2(head);


Console.WriteLine("Hello, World!");

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public partial class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }
        HashSet<ListNode> hash = new();
        while (head != null)
        {
            var res = hash.Add(head);
            if (!res)
            {
                return head;
            }
            head = head.next;
        }

        return null;
    }
}

//it is not mine solution
public partial class Solution
{
    public ListNode DetectCycle2(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                break;
            }
        }
        if (fast == null || fast.next == null)
        {
            return null;
        }
        slow = head;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        return slow;
    }
}