Solution solution = new();
//solution.MaxPathSum(new TreeNode(1,new TreeNode(2),new TreeNode(3)));
//solution.MaxPathSum(new TreeNode(-10, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))));
solution.MaxPathSum(new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4), new TreeNode(5))));


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
 
//it is not mine solution
public class Solution
{
    public int MaxPathSum(TreeNode root)
    {
        int[] res = { root.val };

        int Dfs(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftMax = Dfs(node.left);
            int rightMax = Dfs(node.right);
            leftMax = Math.Max(leftMax, 0);
            rightMax = Math.Max(rightMax, 0);

            res[0] = Math.Max(res[0], node.val + leftMax + rightMax);
            return node.val + Math.Max(leftMax, rightMax);
        }

        Dfs(root);
        return res[0];
    }
}