Solution solution = new();
solution.LevelOrderBottom(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));

// solution.LevelOrderBottom(new TreeNode(1,
//     new TreeNode(2, new TreeNode(4), new TreeNode(5)),
//     new TreeNode(3,
//         new TreeNode(6),
//         new TreeNode(7))));

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
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        
        List<IList<int>> res = new();
        if (root == null)
            return res;
        List<int> temp = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int count = 1;
        while (queue.Count > 0)
        {
            int y = count;
            count = 0;
            for (int i = 0; i < y; i++)
            {
                var queueVal = queue.Dequeue();
                temp.Add(queueVal.val);
                if (queueVal.left != null)
                {
                    queue.Enqueue(queueVal.left);
                    count++;
                }
                if (queueVal.right != null)
                {
                    queue.Enqueue(queueVal.right);
                    count++;
                }
            }
            res.Add(temp.ToList());
            temp.Clear();
        }
        res.Reverse();
        return res;
    }
}