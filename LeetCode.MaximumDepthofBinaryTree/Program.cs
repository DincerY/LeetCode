Solution solution = new();
solution.MaxDepth3(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));



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
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int level = 0;
        void Bfs()
        {
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int queueCount = queue.Count;
                for (int i = 0; i < queueCount; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }
                level++;
            } 
        }
        Bfs();
        return level;
    }
}

public partial class Solution
{
    public int MaxDepth2(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int Dfs(TreeNode node,int level)
        {
            if (node == null)
            {
                return level;
            }

            return Math.Max(Dfs(node.left, level + 1), Dfs(node.right, level + 1));
        }
        return Dfs(root,0);
    }
    
    public int MaxDepth3(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int Dfs(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(Dfs(node.left), Dfs(node.right));
        }
        return Dfs(root);
    }
    
    public int MaxDepth4(TreeNode root)
    {
        Stack<(TreeNode, int)> stack = new();
        stack.Push((root,1));
        int res = 0;

        while (stack.Count > 0)
        {
            var (node, depth) = stack.Pop();
            if (node != null)
            {
                res = Math.Max(res, depth);
                if (node.left != null)
                {
                    stack.Push((node.left,depth + 1));
                }
                if (node.right != null)
                {
                    stack.Push((node.right,depth + 1));
                }
            }
        }
        return res;
    }
}