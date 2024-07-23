Solution solution = new();
// solution.BuildTree(new []{9,3,15,20,7},
//      new []{9,15,7,20,3});

solution.BuildTree(new []{1,2},
    new []{2,1});

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
    public int[] arr { get; set; }
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        arr = postorder;
        TreeNode Recursive(int[] newinorder)
        {
            if (newinorder.Length == 1)
            {
                var val = new TreeNode(arr[^1]);
                arr = arr.Take(arr.Length-1).Reverse().ToArray();
                return val; 
            }

            if (arr.Length == 0 || inorder.Length == 0)
            {
                return null;
            }
            int rootVal = arr[^1];
            TreeNode root = new TreeNode(rootVal);
            arr = arr.Take(arr.Length-1).Reverse().ToArray();
            
            var inOrderInd = Array.IndexOf(newinorder, rootVal);
            
            
            root.left = Recursive(newinorder.Take(inOrderInd).ToArray());
            root.right = Recursive(newinorder.Skip(inOrderInd + 1).ToArray());

            return root;
        }
        
        return Recursive(inorder);
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

