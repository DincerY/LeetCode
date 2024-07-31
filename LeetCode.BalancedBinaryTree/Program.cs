Solution solution = new();
solution.IsBalanced(new TreeNode(3,new TreeNode(9),new TreeNode(20,new TreeNode(15),new TreeNode(7))));
//solution.IsBalanced(new TreeNode(1,
    //new TreeNode(2,new TreeNode(3, new TreeNode(4),new TreeNode(4)),new TreeNode(3)),new TreeNode(2)));


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
    public bool IsBalanced2(TreeNode root)
    {
        if(root == null)
            return true;
        return Dfs(root).Item1;
    }
    private Tuple<bool,int> Dfs(TreeNode root)  
    {
        if (root == null)
        {
            return Tuple.Create(true,0);
        }
        var left = Dfs(root.left);
        var right = Dfs(root.right);

        bool isBalanced = left.Item1 && right.Item1 && Math.Abs(left.Item2 - right.Item2) <= 1;
        
        return Tuple.Create(isBalanced, Math.Max(left.Item2, right.Item2) + 1);
    }
}
//it is not mine solution
public partial class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root==null)
        {
            return true;
        }

        int lh = getHeight(root.left);
        int rh = getHeight(root.right);

        return Math.Abs(lh-rh)<=1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int getHeight(TreeNode node)
    {
        if(node==null)
        {
            return 0;
        }
        return Math.Max(getHeight(node.left),getHeight(node.right))+1;
    }
}













