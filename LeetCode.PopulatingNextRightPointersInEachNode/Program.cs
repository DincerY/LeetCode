Solution solution = new();
solution.Connect(new Node(1,
    new Node(2,
        new Node(4),new Node(5),null),
    new Node(3,
        new Node(6),new Node(7),null),null));


Console.WriteLine("Hello, World!");


public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node()
    {
    }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null)
        {
            return null;
        }
        Node lastNode = null;
        int queueCount = 0;
        Queue<Node> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            queueCount = queue.Count;
            for (int i = 0; i < queueCount; i++)
            {
                var tempNode = queue.Dequeue();
                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }

                if (lastNode == null && queueCount != 1)
                {
                    lastNode = tempNode;
                }
                if (i != 0)
                {
                    lastNode.next = tempNode;
                    lastNode = tempNode;
                }
            }

            lastNode = null;
        }

        return root;
    }
}