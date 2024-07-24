Solution solution = new();
solution.BuildTree(new[] { 9, 3, 15, 20, 7 },
    new[] { 9, 15, 7, 20, 3 });

// solution.BuildTree2(new []{2,1},
//     new []{2,1});

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
    private int[] postOrderList { get; set; }
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        postOrderList = postorder.ToArray();
        TreeNode Recursive(int[] inorder)
        {
            if (inorder.Length == 0)
                return null;
            var rootVal = postOrderList[^1];
            var indx = Array.IndexOf(inorder, rootVal);
            postOrderList = postOrderList[..(postOrderList.Length - 1)];
            TreeNode root = new TreeNode(rootVal);

            root.right = Recursive(inorder[(indx + 1)..]);
            root.left = Recursive(inorder[..indx]);
            return root;
        }
        return Recursive(inorder);
    }
}


//it is not mine solution
public partial class Solution
{
    public TreeNode BuildTree3(int[] inorder, int[] postorder)
    {
        Dictionary<int, int> inorderIdx = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
        {
            inorderIdx[inorder[i]] = i;
        }

        int postIndex = postorder.Length - 1;

        TreeNode Helper(int l, int r)
        {
            if (l > r)
            {
                return null;
            }

            TreeNode root = new TreeNode(postorder[postIndex--]);

            int idx = inorderIdx[root.val];
            root.right = Helper(idx + 1, r);
            root.left = Helper(l, idx - 1);
            return root;
        }

        return Helper(0, inorder.Length - 1);
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