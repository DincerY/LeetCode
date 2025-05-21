Solution solution = new();
solution.InvertTree(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)),
    new TreeNode(7, new TreeNode(6), new TreeNode(9))));

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
    public TreeNode InvertTree(TreeNode root)
    {
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            (node.left, node.right) = (node.right, node.left);
            Dfs(node.left);
            Dfs(node.right);
        }
        Dfs(root);
        return root;
    }
}