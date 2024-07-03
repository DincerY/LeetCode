Solution solution = new();
//solution.IsValidBST(new TreeNode(2, new TreeNode(1), new TreeNode(3)));

//solution.IsValidBST2(new TreeNode(5, new TreeNode(1), new TreeNode(4,new TreeNode(3),new TreeNode(6))));
solution.IsValidBST(new TreeNode(5, new TreeNode(3), new TreeNode(7,new TreeNode(4),new TreeNode(8))));
Console.WriteLine("Hello, World!");


public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }   
}

public partial class Solution {
    public bool IsValidBST(TreeNode root)
    {
        return Dfs(root, long.MinValue, long.MaxValue);
    }
    bool Dfs(TreeNode node, long left, long right)
    {
        if (node == null)
        {
            return true;
        }

        if (node.val <= left || node.val >= right)
        {
            return false;   
        }

        return Dfs(node.left, left, node.val) &&
               Dfs(node.right, node.val, right);
    }
}




