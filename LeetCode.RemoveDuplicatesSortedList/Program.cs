Solution solution = new Solution();
// solution.DeleteDuplicates(new ListNode(1, 
//     new ListNode(1, 
//         new ListNode(2,
//             new ListNode(3,
//                 new ListNode(3))))));



solution.DeleteDuplicates(new ListNode(1, 
    new ListNode(1, 
        new ListNode(2,
            new ListNode(3,
                new ListNode(3,
                    new ListNode(3)))))));

Console.WriteLine("Hello, World!");


public class ListNode{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution {
     public ListNode DeleteDuplicates(ListNode head)
     {
         if (head == null)
             return head;
         ListNode left = head;
         ListNode right = head.next;
         while (right != null)   
         {
             if (left.val != right.val)
             {
                 left.next = right;
                 left = right;
                 right = right.next;
 
             }
             else
             {
                 right = right.next;
             }
         }

         left.next = right;
 
         return head;
     }
 }