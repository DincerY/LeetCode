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
        List<int> res = new();
        List<int> res2 = new();
        
        FindNode(root,p.val,res);
        FindNode(root,q.val,res2);
        int min = Int32.MaxValue;
        foreach (var r in res)
        {
            if (res2.Contains(r))
            {
                min = Math.Min(min, r);
            }
        }
        return new TreeNode(min);
    }
    private void FindNode(TreeNode node,int val,List<int> res)
    {
        if (node.val == val)
        {
            if (!res.Contains(node.val))
            {
                res.Add(node.val);
            }
            return;
        }
        if(node.val > val)
        {
            if (!res.Contains(node.val))
            {
                res.Add(node.val);
            }
            FindNode(node.left,val,res);
        }
        else
        {
            if (!res.Contains(node.val))
            {
                res.Add(node.val);
            }
            FindNode(node.right,val,res);
        }
    }
}