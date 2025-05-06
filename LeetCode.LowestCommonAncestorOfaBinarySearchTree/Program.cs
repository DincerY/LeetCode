Solution solution = new();
var root = new TreeNode(6)
{
    left = new TreeNode(2)
    {
        left = new TreeNode(0),
        right = new TreeNode(4)
        {
            left = new TreeNode(3),
            right = new TreeNode(5)
        }
    },
    right = new TreeNode(8)
    {
        left = new TreeNode(7),
        right = new TreeNode(9)
    }
};
solution.LowestCommonAncestor(root,new TreeNode(2),new TreeNode(8));

var root2 = new TreeNode(6)
{
    left = new TreeNode(2)
    {
        left = new TreeNode(0),
        right = new TreeNode(4)
        {
            left = new TreeNode(3),
            right = new TreeNode(5)
        }
    },
    right = new TreeNode(8)
    {
        left = new TreeNode(7),
        right = new TreeNode(9)
    }
};
solution.LowestCommonAncestor(root2,new TreeNode(3),new TreeNode(5));

Console.WriteLine("Hello, World!");


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x)
    {
        val = x;
    }
}

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode cur = root;

        while (cur != null)
        {
            if (p.val > cur.val && q.val > cur.val)
            {
                cur = cur.right;
            }
            else if (p.val < cur.val && q.val < cur.val)
            {
                cur = cur.left;
            }
            else
            {
                return cur;
            }
        }

        return null;
    }
  
}