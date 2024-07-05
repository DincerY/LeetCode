Solution solution = new Solution();
// solution.IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)),
//     new TreeNode(1, new TreeNode(2), new TreeNode(3)));


solution.IsSameTree(new TreeNode(1, new TreeNode(1)),
    new TreeNode(1, null, new TreeNode(1)));


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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        List<int> list = new();
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                list.Add(int.MinValue);
                return;
            }
            list.Add(node.val);

            Dfs(node.left);
            Dfs(node.right);
        }
            
        Dfs(p);
        var newList = list.ToList();
        list = new();
        Dfs(q);
        return newList.SequenceEqual(list);
    }
}