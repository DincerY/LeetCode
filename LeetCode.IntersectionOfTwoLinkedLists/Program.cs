Solution solution = new();
var headA = new ListNode(4);
headA.next = new ListNode(1);

var intersection = new ListNode(8);
intersection.next = new ListNode(4);
intersection.next.next = new ListNode(5);

var headB = new ListNode(5);
headB.next = new ListNode(6);
headB.next.next = new ListNode(1);
headB.next.next.next = intersection;

headA.next.next = intersection;

solution.GetIntersectionNode(headA,headB);


Console.WriteLine("Hello, World!");


public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
    }
}

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        Dictionary<ListNode,int> dic = new();
        while (headA != null)
        {  
            dic.Add(headA,headA.val);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (!dic.TryAdd(headB, headB.val))
            {
                break;
            }
            headB = headB.next;
        }
        return headB;
    }
}