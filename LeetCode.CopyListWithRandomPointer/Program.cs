Solution solution = new();
solution.CopyRandomList(new Node(7).next = new Node(13));


Console.WriteLine("Hello, World!");


public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}


public class Solution
{
    public Node CopyRandomList(Node head)
    {
        Node temp = head.next;
        Node newHead = new Node(head.val);
        newHead.random = head.random;
        Node newTemp = newHead;
        while (temp == null)
        {
            newTemp.next = new Node(temp.val);
            newTemp.random = new Node(temp.random.val);
            temp = temp.next;
            newTemp = newTemp.next;
        }
        return newHead;
    }
}