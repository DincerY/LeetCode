Solution solution = new();
solution.SortList(new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3)))));
solution.MergeSort(new int[] { 3, 7, 8, 5, 4, 2, 6, 1 },0, 7);


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
    public ListNode SortList(ListNode head)
    {
        return null;
    }
}


public partial class Solution
{
    public void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }
    }

    private void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] left = new int[n1];
        int[] right = new int[n2];
        int i, j;

        for (i = 0; i < n1; i++)
        {
            left[i] = arr[l + i];
        }

        for (j = 0; j < n2; j++)
        {
            right[j] = arr[m + 1 + j];
        }

        i = 0;
        j = 0;

        int k = l;
        while (i < n1 && j < n2)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < n1) {
            arr[k] = left[i];
            i++;
            k++;
        }
        while (j < n2) {
            arr[k] = right[j];
            j++;
            k++;
        }
    }
}