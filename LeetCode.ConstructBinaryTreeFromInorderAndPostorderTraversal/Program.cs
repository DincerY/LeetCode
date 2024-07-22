Solution solution = new();
solution.BuildTree(new []{9,3,15,20,7},
    new []{9,15,7,20,3});

solution.PostOrder(new TreeNode(3, 
    new TreeNode(9), 
    new TreeNode(20, 
        new TreeNode(15), 
        new TreeNode(7))));


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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {

        TreeNode Recursive(int[] newinorder, int[] newpostorder)
        {
            int rootVal = newpostorder[^1];
            TreeNode root = new TreeNode(rootVal);

            var inOrderInd = Array.IndexOf(newinorder, rootVal);
            
            
            root.left = Recursive(newinorder.Take(1).ToArray(), newpostorder.Take(newpostorder.Length - 1).Reverse().ToArray());
            root.right = Recursive(null,null);

            return root;
        }
        
        return Recursive(inorder, postorder);
    }
}

public partial class Solution
{
    public List<int> PostOrder(TreeNode root)
    {
        List<int> list = new();
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Dfs(node.left);
            Dfs(node.right);
            list.Add(node.val);
        }
        Dfs(root);
        return list;
    }
}