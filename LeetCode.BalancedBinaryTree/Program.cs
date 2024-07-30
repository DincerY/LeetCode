Solution solution = new();
//solution.IsBalanced(new TreeNode(3,new TreeNode(9),new TreeNode(20,new TreeNode(15),new TreeNode(7))));
solution.IsBalanced(new TreeNode(1,
    new TreeNode(2,new TreeNode(3, new TreeNode(4),new TreeNode(4)),new TreeNode(3)),new TreeNode(2)));

solution.PostOrder(new TreeNode(3,new TreeNode(9),new TreeNode(20,new TreeNode(15),new TreeNode(7))));


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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        var left = Dfs(root.left,0);
        var right = Dfs(root.right, 0);
        if (left - right == 1 || right - left == 1 || right - left == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private int Dfs(TreeNode root,int depth)
    {
        if (root == null)
        {
            return depth - 1;
        }
        var left = Dfs(root.left, depth+1);
        var right = Dfs(root.right, depth+1);
        return Math.Max(left, right);
    }
}


public partial class Solution
{
    public int PostOrder(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        PostOrder(root.right);
        PostOrder(root.left);
        Console.WriteLine(root.val);
        return 0;
    }
}












