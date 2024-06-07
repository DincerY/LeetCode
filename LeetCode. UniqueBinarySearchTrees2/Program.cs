Solution solution = new();
solution.GenerateTrees(3);

var node = solution.Insert(null,1);
solution.Insert(node, 4);
solution.Insert(node, 5);
solution.Insert(node, 2);
solution.Insert(node, 10);
solution.Insert(node, 8);




Console.WriteLine("Hello, World!");


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public partial class Solution
{
    public IList<TreeNode> GenerateTrees(int n)
    {




        return null;
    }
}



public partial class Solution
{
    public TreeNode Insert(TreeNode Node,int n)
    {
        if (Node == null)
        {
            return new TreeNode(n);
        }

        if (n < Node.val)
        {
            Node.left = Insert(Node.left, n);
        }
        if (n > Node.val)
        {
            Node.right = Insert(Node.right, n);
        }

        return Node;
    }
}