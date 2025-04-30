Solution solution = new();
solution.KthSmallest2(new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), 1);
solution.KthSmallest2(
    new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), new TreeNode(6)), 5
);

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
    public int KthSmallest(TreeNode root, int k)
    {
        int res = -1;
        int level = 0;
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Dfs(node.left);
            level++;
            if (level == k)
            {
                res = node.val;
            }
            Dfs(node.right);
        }
        Dfs(root);
        return res;
    }
}
//NeedCode solution
public partial class Solution {
    public int KthSmallest2(TreeNode root, int k)
    {
        int n = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;

        while (stack.Count > 0 || curr != null) {
            while (curr != null) {
                stack.Push(curr);
                curr = curr.left;
            }
            curr = stack.Pop();
            n++;
            if (n == k) {
                return curr.val;
            }
            curr = curr.right;
        }

        return -1;
    }
}