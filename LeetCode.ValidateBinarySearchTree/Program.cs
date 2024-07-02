Solution solution = new();
//solution.IsValidBST(new TreeNode(2, new TreeNode(1), new TreeNode(3)));

solution.IsValidBST(new TreeNode(5, new TreeNode(1), new TreeNode(4,new TreeNode(3),new TreeNode(6))));
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

public class Solution {
    public bool IsValidBST(TreeNode root)
    {
        return Dfs(root);
    }

    bool Dfs(TreeNode node)
    {
        if (node.left != null || node.right != null)
        {
            Dfs(node.left);
            Dfs(node.right);
        }

        return true;
    }
}