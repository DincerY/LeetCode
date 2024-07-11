using System.Collections;

Solution solution = new();
// solution.LevelOrder(new TreeNode(3, 
//      new TreeNode(9), 
//     new TreeNode(20, 
//         new TreeNode(15),
//         new TreeNode(7))));

// solution.LevelOrder(new TreeNode(1,
//     new TreeNode(2,
//         new TreeNode(3,
//             new TreeNode(4,
//                 new TreeNode(5))))));

solution.LevelOrder(new TreeNode(1,
    new TreeNode(2,new TreeNode(4),new TreeNode(5)),new TreeNode(3,new TreeNode(6),new TreeNode(7))));

// solution.LevelOrder(new TreeNode(1, 
//     new TreeNode(2)));


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

public partial class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> list = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int queueLen = queue.Count;
            List<int> res = new List<int>();
            for (int i = 0; i < queueLen; i++)
            {
                TreeNode curr = queue.Dequeue();
                if (curr.val != null)
                {
                    res.Add(curr.val);
                }

                if (curr.left is not null)
                {
                    queue.Enqueue(curr.left);
                }

                if (curr.right is not null)
                {
                    queue.Enqueue(curr.right);
                }
            }

            list.Add(res.ToList());
            res.Clear();
        }
        return list;
    }
}