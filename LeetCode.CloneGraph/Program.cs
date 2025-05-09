Solution solution = new Solution();
var node1 = new Node(1, new List<Node>());
var node2 = new Node(2, new List<Node>());
var node3 = new Node(3, new List<Node>());
var node4 = new Node(4, new List<Node>());
node1.neighbors.Add(node2);
node1.neighbors.Add(node4);
node2.neighbors.Add(node1);
node2.neighbors.Add(node3);
node3.neighbors.Add(node2);
node3.neighbors.Add(node4);
node4.neighbors.Add(node1);
node4.neighbors.Add(node3);
solution.CloneGraph(node1);

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

//NeedCode solution
public partial class Solution
{
    public Node CloneGraph(Node node)
    {
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();

        Node Dfs(Node n)
        {
            if (oldToNew.ContainsKey(n))
            {
                return oldToNew[n];
            }

            Node copy = new Node(n.val);
            oldToNew[n] = copy;
            foreach (var nei in n.neighbors)
            {
                copy.neighbors.Add(Dfs(nei));
            }

            return copy;
        }

        return node != null ? Dfs(node) : null;
    }
}