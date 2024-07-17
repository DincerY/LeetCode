Solution solution = new();
solution.MaxDepth2(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));

solution.FindDepth(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))),0);


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
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Dfs(node.left);
            Dfs(node.right);
        }




        return 0;
    }
    
    public int FindDepth(TreeNode root, int x)
    {
    
        // Base case
        if (root == null)
            return -1;

        // Initialize distance as -1
        int dist = -1;

        // Check if x is current node=
        if ((root.val == x)|| (dist = FindDepth(root.left, x)) >= 0 || (dist = FindDepth(root.right, x)) >= 0)
            return dist + 1;
        
        return dist;
    }
}