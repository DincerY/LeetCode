Solution solution = new();
solution.RotateRight2(new ListNode(1)
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
}, 7);


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
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }

        var result = NodeQuantity(head);
        k = k % result;
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

    private int NodeQuantity(ListNode head)
    {
        int result = 0;
        while (head != null)
        {
            result++;
            head = head.next;
        }
        return result;
    }
}

public partial class Solution
{
    public ListNode RotateRight2(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }

        var result = NodeQuantity(head);
        k = k % result;

        if (k == 0)
        {
            return head;
        }
        
        ListNode firstPointer = head;
        ListNode secondPointer = null;
        for (int i = 1; i < result - k; i++)
        {
            firstPointer = firstPointer.next;
      
        }
        secondPointer = firstPointer.next;
        firstPointer.next = null;

        firstPointer = secondPointer;

        while (firstPointer.next != null)
        {
            firstPointer = firstPointer.next;
        }

        firstPointer.next = head;
        return secondPointer;
    }
}

