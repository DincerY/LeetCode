Solution solution = new();
solution.InsertionSortList2(new ListNode(4,new ListNode(2,new ListNode(1,new ListNode(3)))));
//solution.InsertionSort(new int[]{2,5,7,10,9,6,11,21,19,17,16,15});


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
    public ListNode InsertionSortList(ListNode head)
    {
        List<int> list = new();
        ListNode temp = head;
        while (temp != null)
        {
            list.Add(temp.val);
            temp = temp.next;
        }

        var arr = list.ToArray();
        Array.Sort(arr);
        temp = new ListNode(arr[0]);
        head = temp;
        for (int i = 1; i < arr.Length; i++)
        {
            temp.next = new ListNode(arr[i]);
            temp = temp.next;
        }
        return head;
    }
}



//it is not mine solution
public partial class Solution {
    public ListNode InsertionSortList2(ListNode head) {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = head;
        ListNode cur = head?.next;

        while (cur != null) {
            if (cur.val >= prev.val) {
                prev = cur;
                cur = cur.next;
                continue;
            }
            ListNode tmp = dummy;
            while (cur.val > tmp.next.val) {
                tmp = tmp.next;
            }
            prev.next = cur.next;
            cur.next = tmp.next;
            tmp.next = cur;
            cur = prev.next;
        }
        return dummy.next;
    }
}




//Insertion sort example
public partial class Solution
{
    public int[] InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i;
            int val = arr[i];
            while (val < arr[j-1])
            {
                arr[j] = arr[j - 1];
                j--;
            }

            arr[j] = val;
        }
        return arr;
    }
}