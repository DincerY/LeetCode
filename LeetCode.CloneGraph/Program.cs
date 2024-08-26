Solution solution = new Solution();
solution.CloneGraph(new Node(1, new List<Node>(new[] { new Node(2), new Node(4) })));


Console.WriteLine("Hello, World!");


public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}


public class Solution
{
    public Node CloneGraph(Node node)
    {
        return null;
    }
}