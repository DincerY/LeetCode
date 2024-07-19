Solution solution = new();
// solution.BuildTree(new []{3,9,20,15,7},
//     new []{9,3,15,20,7});

solution.BuildTree(new []{1,2,4,5,3,6,7},
    new []{4,2,5,1,6,3,7});

solution.BuildTree2(new []{1,2,3,4,5,6});


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
/// <summary>
/// it is not mine solution
/// </summary>
public partial class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder == null || preorder.Length == 0 || inorder == null || inorder.Length == 0)
            return null;
            
        TreeNode root = new TreeNode(preorder[0]);
        int mid = Array.IndexOf(inorder, preorder[0]);
        root.left = BuildTree(preorder.Skip(1).Take(mid).ToArray(), inorder.Take(mid).ToArray());
        root.right = BuildTree(preorder.Skip(mid + 1).ToArray(), inorder.Skip(mid + 1).ToArray());
        return root;
    }
}
public partial class Solution
{
    public TreeNode BuildTree2(int[] preorder)
    {
        if (preorder.Length == 0)
        {
            return null;
        }
        TreeNode node = new TreeNode(preorder[0]);

        node.left = BuildTree2(preorder[1..]);
        node.right = BuildTree2(new int[0]);
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