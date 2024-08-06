Solution solution = new();
solution.PathSum3(new TreeNode(5,
    new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
    new TreeNode(8, new TreeNode(13), new TreeNode(4, new TreeNode(5), new TreeNode(1)))), 22);

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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        List<IList<int>> res = new();
        List<int> list = new();
        if (root == null)
        {
            return res;
        }
        Dfs(root);
        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node.val);
            Dfs(node.left);
            Dfs(node.right);
            int a = ListToInt(list);
            if (a == targetSum && node.left == null && node.right == null)
            {
                res.Add(list.ToList());
            }
            list.RemoveAt(list.Count - 1);
        }
        return res;
    }

    private int ListToInt(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }

        return sum;
    }


    public IList<IList<int>> PathSum3(TreeNode root, int targetSum)
        {
            List<IList<int>> res = new();
            List<int> list = new();
            if (root == null)
            {
                return res;
            }
            Dfs(root,targetSum);
            void Dfs(TreeNode node, int sum)
            {
                if (node == null)
                {
                    return;
                }
                list.Add(node.val);
                Dfs(node.left, sum - node.val);
                Dfs(node.right, sum - node.val);
                if (sum == node.val && node.left == null && node.right == null)
                {
                    res.Add(list.ToList());
                }
                list.RemoveAt(list.Count - 1);
            }
            return res;
        }
}

//it is not mine solution
public partial class Solution
{
    public IList<IList<int>> PathSum2(TreeNode root, int targetSum)
    {
        List<IList<int>> result = new();
        pathSum(root, targetSum, new List<int>(), result);
        return result;
    }

    private void pathSum(TreeNode root, int sum, List<int> path, List<IList<int>> res)
    {
        if (root == null)
        {
            return;
        }
        path.Add(root.val);
        if (root.left == null && root.right == null && sum == root.val)
        {
            res.Add(path.ToList());
        }
        pathSum(root.left, sum - root.val, path,res);
        pathSum(root.right, sum - root.val, path,res);
        path.RemoveAt(path.Count - 1);
    }
}