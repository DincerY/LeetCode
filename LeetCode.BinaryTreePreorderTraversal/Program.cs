Solution solution = new();
solution.PreorderTraversal(new TreeNode(1,null,new TreeNode(2,new TreeNode(3))));


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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> list = new();
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node.val);
            Dfs(node.left);
            Dfs(node.right);
        }
        Dfs(root);
        return list;
    }
}