using System.Collections;

Solution solution = new();
solution.LevelOrder(new TreeNode(3, 
     new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15),
        new TreeNode(7))));


// solution.LevelOrder(new TreeNode(1));


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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> list = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int difLevel = 1;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int sqrt = (int)Math.Sqrt(difLevel);
            if (sqrt == 1 && difLevel < 2)
            {
                sqrt = 0;
            }
            TreeNode curr = queue.Dequeue();
            Console.WriteLine(curr.val + "---" + sqrt);

            if (list.Count == sqrt)
            {
                list.Add(new List<int>());
            }
            list[sqrt].Add(curr.val);
            
            if (curr.left != null)
            {
                queue.Enqueue(curr.left);
            }

            if (curr.right != null)
            {
                queue.Enqueue(curr.right);
            }

            difLevel++;
        }
        return list;
    }
}