Solution solution = new();
solution.BuildTree(new []{3,9,20,15,7},
    new []{9,3,15,20,7});

solution.InOrder(new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5)),new TreeNode(3,new TreeNode(6),new TreeNode(7))));


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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        List<int> preOrder = preorder.ToList();
        List<int> inOrder = inorder.ToList();
        TreeNode node = new TreeNode(preOrder[0]);
        preOrder.Remove(preorder[0]);
        int preIndex = 1;
        int inIndex = 0;    
        
        
        

        return node;
    }
}



public partial class Solution
{
    public List<int> PreOrder(TreeNode root)
    {
        //Root -> Left -> Right
        List<int> list = new();
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node.val);
            Dfs(node.left);
            Dfs(node.right);
        }
        Dfs(root);
        return list;
    }
    
    public List<int> InOrder(TreeNode root)
    {
        //Left -> Root -> Right
        List<int> list = new();
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Dfs(node.left);
            list.Add(node.val);
            Dfs(node.right);

        }
        Dfs(root);
        return list;
    }
}