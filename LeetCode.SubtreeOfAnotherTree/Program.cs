Solution solution = new();
solution.IsSubtree(new TreeNode(3,
    new TreeNode(4,
        new TreeNode(1),
        new TreeNode(2)),
    new TreeNode(5)),
    new TreeNode(4,
        new TreeNode(1),
        new TreeNode(2)));

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

//NeedCode solution 
public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
        {
            return root == subRoot;
        }

        if (root.val == subRoot?.val && IsSameTree(root, subRoot))
        {
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null || q == null)
        {
            return p == q;
        }

        return p.val == q.val
               && IsSameTree(p.left, q.left)
               && IsSameTree(p.right, q.right);
    }
}