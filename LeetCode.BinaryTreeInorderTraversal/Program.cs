using System.Drawing;

Solution solution = new();
solution.InorderTraversal(new TreeNode(1,null,new TreeNode(2,new TreeNode(3),null)));

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
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> result = new();

        void Dfs(TreeNode tree)
        {
            if (tree != null)
            {
                result.Add(tree.val);
                Dfs(tree.left);
                Dfs(tree.right);
            }
        }
        
        Dfs(root);
        return result;
    }
}