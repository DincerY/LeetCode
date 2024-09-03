Solution solution = new();
var head = new ListNode(3);
head.next = new ListNode(2);
head.next.next = new ListNode(0);
head.next.next.next = new ListNode(-4);
head.next.next.next.next = head.next;
solution.HasCycle2(head);



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

//Floyd’s Cycle Finding Algorithm
public partial class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
        {
            return false;
        }
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                return true;
            }
        }
        return false;
    }
}

//HashMap Approach
public partial class Solution
{
    public bool HasCycle2(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        HashSet<ListNode> hash = new();
        while (head != null)
        {
            var res = hash.Add(head);
            if (!res)
            {
                return true;
            }

            head = head.next;
        }

        return false;
    }
}