Solution solution = new();
solution.ReverseBetween(
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

public class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
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

        var a = list.Slice(left, right - left + 1);
        a.Reverse();
        var b = a.ToArray();
        int k = 0;
        for (int i = left; i <= right; i++)
        {
            arr[i] = b[k];
            k++;
        }

        
        
        
        return head;
    }
}