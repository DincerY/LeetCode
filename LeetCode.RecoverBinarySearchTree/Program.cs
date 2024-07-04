Solution solution = new();
//solution.RecoverTree(new TreeNode(1,new TreeNode(3,null,new TreeNode(2))));
//solution.RecoverTree2(new TreeNode(3,new TreeNode(1),new TreeNode(4,new TreeNode(2))));
solution.RecoverTree2(new TreeNode(2,new TreeNode(3),new TreeNode(1)));


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
    public void RecoverTree(TreeNode root)
    {
        var wrongRoot  = Dfs(root, int.MinValue, int.MaxValue);
        (root.val, wrongRoot.val) = (wrongRoot.val, root.val);
    }

    private TreeNode Dfs(TreeNode node, int left, int right)
    {
        if (node == null)
        {
            return null;
        }
        if (node.val < left || node.val > right)
        {
            return node;
        }
        
        var a = Dfs(node.left, left, node.val);
        var b =  Dfs(node.right, node.val, right);

        if (a != null)
        {
            return a;
        }

        if (b != null)
        {
            return b;
        }

        return null;
    }
}


public partial class Solution
{
    private TreeNode first;
    private TreeNode prev;
    private TreeNode middle;
    private TreeNode last;
    public void RecoverTree2(TreeNode root)
    {
        first = null;
        middle = null;
        last = null;
        prev = new TreeNode(int.MinValue);
        Inorder(root);
        if (first != null && last != null)
        {
            (first.val, last.val) = (last.val, first.val);
        }
        else if (first != null && middle != null)
        {
            (first.val, middle.val) = (middle.val, first.val);
        }
    }
    private void Inorder(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        Inorder(root.left);
        if (prev != null && root.val < prev.val)
        {
            if (first == null)
            {
                first = prev;
                middle = root;
            }
            else
            {
                last = root;
            }
        }
        prev = root;
        Inorder(root.right);
    }
}   