Solution solution = new();
solution.IsSymmetric(new TreeNode(1,
    new TreeNode(2,
        new TreeNode(3), new TreeNode(4))
    ,new TreeNode(2, 
        new TreeNode(4), new TreeNode(3))));


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
    public bool IsSymmetric(TreeNode root)
    {
        
        return true;
    }
    
    public void BFS(TreeNode root)
    {
        
    }
}

