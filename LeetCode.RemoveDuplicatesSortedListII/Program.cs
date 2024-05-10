Solution solution = new();
solution.DeleteDuplicates(new ListNode(1,
    new ListNode(2,
        new ListNode(3,
            new ListNode(3,
                new ListNode(4,
                    new ListNode(4,
                        new ListNode(5))
                    ))))));


// solution.DeleteDuplicates(new ListNode(1,
//     new ListNode(1,
//         new ListNode(1,
//             new ListNode(2,
//                 new ListNode(3))))));



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
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;

        while (head != null)
        {
            if (head.next != null && head.val == head.next.val)
            {
                while (head.next != null && head.val == head.next.val)
                {
                    head = head.next;
                }

                prev.next = head.next;
            }
            else
            {
                prev = prev.next;
            }

            head = head.next;
        }
        return dummy.next;
    }
}


