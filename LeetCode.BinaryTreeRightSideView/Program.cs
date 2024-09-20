Solution solution = new();
//solution.RightSideView(new TreeNode(1,new TreeNode(2,null,new TreeNode(5)),new TreeNode(3,null,new TreeNode(4))));
solution.RightSideView(new TreeNode(1,new TreeNode(2,new TreeNode(4)),new TreeNode(3)));


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
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> list = new();
        if (root == null)
        {
            return list;
        }
        Queue<TreeNode> queue = new();  
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode rightSide = null;
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var tmp = queue.Dequeue();
                rightSide = tmp;
                if (tmp.left != null)
                {
                    queue.Enqueue(tmp.left);
                }
                if (tmp.right != null)
                {
                    queue.Enqueue(tmp.right);
                }
            }

            if (rightSide != null)
            {
                list.Add(rightSide.val);
            }
        }

        return list;
    }
}


