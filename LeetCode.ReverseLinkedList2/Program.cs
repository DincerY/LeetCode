Solution solution = new();
solution.ReverseBetween2(
    new ListNode(1,
        new ListNode(2,
            new ListNode(3,
                new ListNode(4,
                    new ListNode(5))))), 2, 4);


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
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode dummy = head;
        ListNode temp = head;
        List<int> list = new();
        list.Add(0);

        while (temp != null)
        {
            list.Add(temp.val);
            temp = temp.next;
        }
        int[] arr = new int[list.Count];
        arr = list.ToArray();

        var slicedList = list.Slice(left, right - left + 1);
        slicedList.Reverse();
        var slicedArr = slicedList.ToArray();
        int k = 0;
        for (int i = left; i <= right; i++)
        {
            arr[i] = slicedArr[k];
            k++;
        }
        for (int i = 1; i < arr.Length; i++)
        {
            dummy.next = new ListNode(arr[i]);
            dummy = dummy.next;
        }

        return head.next;
    }
}

public partial class Solution
{
    public ListNode ReverseBetween2(ListNode head, int left, int right)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode leftPrev = dummy;
        ListNode cur = head;

        for (int i = 0; i < left-1; i++)
        {
            leftPrev = cur;
            cur = cur.next;
        }

        ListNode prev = null;
        for (int i = 0; i < right - left + 1; i++)
        {
            ListNode tempNext = cur.next;
            cur.next = prev;
            prev = cur;
            cur = tempNext;
        }

        leftPrev.next.next = cur;
        leftPrev.next = prev;

        return dummy.next;
    }
}