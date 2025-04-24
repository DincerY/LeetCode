Solution solution = new();
solution.CountNodes2(new TreeNode(1,new TreeNode(2,new TreeNode(4),new TreeNode(5)),new TreeNode(3,new TreeNode(6))));
solution.CountNodes2(new TreeNode(1,new TreeNode(2,new TreeNode(4,new TreeNode(8),new TreeNode(9)),new TreeNode(5,new TreeNode(10),new TreeNode(11))),new TreeNode(3,new TreeNode(6,new TreeNode(12)),new TreeNode(7))));

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
    public int CountNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int total = 1;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.right != null)
            {
                queue.Enqueue(node.right);
                total++;
            }
            if (node.left != null)
            {
                queue.Enqueue(node.left);
                total++;
            }
        }

        return total;
    }
}

public partial class Solution
{
    public int CountNodes2(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int lheight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + lheight(node.left);
        }
        
        int rheight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + rheight(node.right);
        }

        int l = lheight(root);
        int r = rheight(root);

        if (l > r)
        {
            return 1 + CountNodes2(root.left) + CountNodes2(root.right);
        }
        return (int)Math.Pow(2, l) - 1;
    }
}