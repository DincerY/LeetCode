Solution solution = new();
// solution.DeleteDuplicates(new ListNode(1,
//     new ListNode(2,
//         new ListNode(3,
//             new ListNode(3,
//                 new ListNode(4,
//                     new ListNode(4,
//                         new ListNode(5))
//                     ))))));


solution.DeleteDuplicates(new ListNode(1,
    new ListNode(1,
        new ListNode(1,
            new ListNode(2,
                new ListNode(3))))));



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
    public ListNode DeleteDuplicates(ListNode head)
    {
        //solla sağı kıyasla sağla bir sağını kıyasla 2 den fazlaysa arama öğesi oluştur onu her gördüğünde bir sonraki node a geç
        ListNode left = head;
        ListNode right = head.next;

       
        


        return head;
    }
}