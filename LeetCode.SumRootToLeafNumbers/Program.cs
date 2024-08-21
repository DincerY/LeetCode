Solution solution = new();
//solution.SumNumbers(new TreeNode(1, new TreeNode(2), new TreeNode(3)));
//solution.SumNumbers(new TreeNode(4, new TreeNode(9, new TreeNode(5),new TreeNode(1)), new TreeNode(0)));
solution.SumNumbers(new TreeNode(4, new TreeNode(9, null,new TreeNode(1)), new TreeNode(0)));


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
    public int SumNumbers(TreeNode root)
    {
        int sum = 0;
        void Dfs(TreeNode node, int val)
        {
            if (node == null)
            {
                val /= 10;
                sum += val;
                return;
            }

            val += node.val;
            Dfs(node.left, val * 10);
            Dfs(node.right, val * 10);
        }

        Dfs(root, 0);

        return sum / 2;
    }
}