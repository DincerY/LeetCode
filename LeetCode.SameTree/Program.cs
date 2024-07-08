Solution solution = new Solution();
// solution.IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)),
//     new TreeNode(1, new TreeNode(2), new TreeNode(3)));


// solution.IsSameTree(new TreeNode(1, new TreeNode(1)),
//     new TreeNode(1, null, new TreeNode(1)));

solution.IsSameTree2(new TreeNode(1, new TreeNode(1)),
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

public partial class Solution
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


public partial class Solution
{
    public bool IsSameTree2(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null || p.val != q.val)
        {
            return false;
        }

        return IsSameTree2(p.left, q.left) && IsSameTree2(p.right, q.right);
    }
}


