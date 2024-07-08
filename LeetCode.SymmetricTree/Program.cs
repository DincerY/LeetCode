Solution solution = new();
solution.IsSymmetric(new TreeNode(1,
    new TreeNode(2,
        new TreeNode(3), new TreeNode(4))
    , new TreeNode(2,
        new TreeNode(4), new TreeNode(3))));

TreeNode root = new TreeNode(10);
root.left = new TreeNode(5);
root.right = new TreeNode(15);
root.left.left = new TreeNode(3);
root.left.right = new TreeNode(7);
root.right.right = new TreeNode(18);

// Ağacı BFS ile dolaşın
solution.BFS(root);

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
    public bool IsSymmetric(TreeNode root)
    {
        return true;
    }
    
}

public partial class Solution
{
    public void BFS(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode currentNode = queue.Dequeue();
            Console.WriteLine(currentNode.val); // Düğüm değerini yazdırın

            if (currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }

            if (currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }
        }
    }
}