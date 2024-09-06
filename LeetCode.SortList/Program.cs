Solution solution = new();
solution.SortList(new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3)))));
int[] arr = new[] { 3, 7, 8, 5, 4, 2, 6, 1 };
solution.MergeSort(arr);


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

//it is Needcode solution
public partial class Solution
{
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode left = head;
        ListNode right = GetMid(head);
        ListNode tmp = right.next;
        right.next = null;
        right = tmp;

        left = SortList(left);
        right = SortList(right);
        return Merge(left, right);
    }

    private ListNode GetMid(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private ListNode Merge(ListNode list1, ListNode list2)
    {
        ListNode tail = new ListNode();
        ListNode dummy = tail;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;
        }

        if (list1 != null)
        {
            tail.next = list1;
        }

        if (list2 != null)
        {
            tail.next = list2;
        }

        return dummy.next;
    }
}

//MergeSort Example
public partial class Solution
{
    public void MergeSort(int[] arr)
    {
        if (arr.Length == 1)
        {
            return;
        }

        int mid = arr.Length / 2;
        int[] left = arr.Take(mid).ToArray();
        int[] right = arr.Skip(mid).ToArray();
        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }

    private void Merge(int[] arr, int[] leftArr, int[] rightArr)
    {
        int i = 0, l = 0, r = 0;
        while (r < rightArr.Length && l < leftArr.Length)
        {
            if (leftArr[l] < rightArr[r])
            {
                arr[i] = leftArr[l];
                l++;
                i++;
            }
            else
            {
                arr[i] = rightArr[r];
                r++;
                i++;
            }
        }

        while (l < leftArr.Length)
        {
            arr[i] = leftArr[l];
            l++;
            i++;
        }

        while (r < rightArr.Length)
        {
            arr[i] = rightArr[r];
            r++;
            i++;
        }
    }
}