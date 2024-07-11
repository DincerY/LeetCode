Solution solution = new Solution();
solution.ZigzagLevelOrder(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));


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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> list = new();


        return list;
    }
}