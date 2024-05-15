Solution solution = new();
// solution.Partition(new ListNode(1,
//     new ListNode(4,
//         new ListNode(3,
//             new ListNode(2,
//                 new ListNode(5,
//                     new ListNode(2)))))), 3);


solution.Partition(new ListNode(2,
    new ListNode(1)), 2);



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
    public ListNode Partition(ListNode head, int x)
    {
        if (head == null)
            return head;
        ListNode dummy = new ListNode();
        ListNode left = dummy;
        ListNode right = head;
        while (right != null)
        {
            if (right.val >= x)
            {
                left.next = new ListNode(right.val);
                left = left.next;
            }

            right = right.next;
        }

        left = head;
        right = head.next;
        
        while (right != null)
        {
            if (right.val < x)
            {
                left.next = right;
                left = left.next;
            }
            right = right.next;
        }
        left.next = dummy.next;

        if (head.val >= x)
            return head.next;

        return head;
    }
}