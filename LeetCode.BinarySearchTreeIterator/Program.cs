BSTIterator bstIterator = new(new TreeNode(7, new TreeNode(3),new TreeNode(15,new TreeNode(9),new TreeNode(20))));

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

public class BSTIterator
{
    private TreeNode _root;
    private Queue<int> _queue;
    public BSTIterator(TreeNode root)
    {
        _root = root;
        _queue = new Queue<int>();
        Dfs(root);
    }

    public int Next()
    {
        return _queue.Dequeue();
    }

    public bool HasNext()
    {

        return _queue.Count > 0 ? true : false;
    }

    private void Dfs(TreeNode node)
    {
        if (node == null)
        {
            return;
        }
        Dfs(node.left);
        _queue.Enqueue(node.val);
        Dfs(node.right);
    }
}