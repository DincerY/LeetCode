Solution solution = new();
//solution.IsBalanced(new TreeNode(3,new TreeNode(9),new TreeNode(20,new TreeNode(15),new TreeNode(7))));
solution.IsBalanced(new TreeNode(1,
    new TreeNode(2,new TreeNode(3, new TreeNode(4),new TreeNode(4)),new TreeNode(3)),new TreeNode(2)));


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

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        var left = FindDepth(root.left,0);
        maxDepth = 0;
        var right = FindDepth(root.right, 0);
        if (left - right == 1 || right - left == 1 || right - left == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    int maxDepth = 0;
    private int FindDepth(TreeNode root, int depth)
    {
        if (root == null)
        {
            return depth - 1;
        }

        maxDepth = Math.Max(maxDepth, depth);
        FindDepth(root.left, depth + 1);
        FindDepth(root.right, depth + 1);

        return maxDepth;
    }
}