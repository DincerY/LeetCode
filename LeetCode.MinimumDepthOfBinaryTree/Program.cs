Solution solution = new();
// solution.MinDepth(new TreeNode(3,
//     new TreeNode(9),
//     new TreeNode(20,
//         new TreeNode(15),new TreeNode(7))));


solution.MinDepth(new TreeNode(2,
    null,
    new TreeNode(3,
        null,new TreeNode(4,null,new TreeNode(5,null,new TreeNode(6))))));




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
    //breath first search yapıp ilk sağı solu null olan node a geldiğimde derinliği döndürücem
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        var val = 1;
        while (queue.Count > 0)
        {
            var end = queue.Count;
            for (int i = 0; i < end; i++)
            {
                var tempNode = queue.Dequeue();
                if (tempNode.left == null && tempNode.right == null)
                {
                    return val;
                }

                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }
            val++;
        }
        return 0;
    }

   
}
