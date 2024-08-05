Solution solution = new();
solution.HasPathSum2(new TreeNode(5,
    new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
    new TreeNode(8,new TreeNode(13),new TreeNode(4,null,new TreeNode(1)))),22);

// solution.HasPathSum(new TreeNode(2,
//     new TreeNode(2)),1);

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
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        bool val = false;
        int sum = 0;
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            sum += node.val;
            
            Dfs(node.left);
            Dfs(node.right);
            if (node.left == null && node.right == null && sum == targetSum)
            {
                val = true;
                return;
            }
            sum -= node.val;
        }
        Dfs(root);
        return val;
    }
}

public partial class Solution
{
    public bool HasPathSum2(TreeNode root, int targetSum)
    {
        bool val = false;
        int Dfs(TreeNode node,int sum)
        {
            if (node == null)
            {
                return 0;
            }

            sum += node.val;
            Dfs(node.left,sum);
            Dfs(node.right,sum);
            if (node.left == null && node.right == null && sum == targetSum)
            {
                val = true;
                return 0;
            }
            return 0;
        }
        Dfs(root,0);
        return val;
    }
}

//It is not mine solution
public partial class Solution
{
    public bool HasPathSum3(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;

        Stack<TreeNode> path = new Stack<TreeNode>();
        Stack<int> sumPath = new Stack<int>();

        path.Push(root);
        sumPath.Push(root.val);

        while (path.Count > 0) {
            TreeNode temp = path.Pop();
            int tempVal = sumPath.Pop();

            if (temp.left == null && temp.right == null && tempVal == targetSum)
                return true;

            if (temp.right != null) {
                path.Push(temp.right);
                sumPath.Push(temp.right.val + tempVal);
            }

            if (temp.left != null) {
                path.Push(temp.left);
                sumPath.Push(temp.left.val + tempVal);
            }
        }
        return false;
    }
}