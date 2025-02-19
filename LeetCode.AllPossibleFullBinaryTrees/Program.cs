Solution solution = new Solution();
solution.AllPossibleFBT4(7);
solution.AllPossibleFBT3(3);

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

//NeetCode solutions
public partial class Solution
{
    public IList<TreeNode> AllPossibleFBT(int n)
    {
        IList<TreeNode> Backtrack(int n)
        {
            if (n == 0)
            {
                return new List<TreeNode>();
            }

            if (n == 1)
            {
                return new List<TreeNode> { new TreeNode() };
            }

            var res = new List<TreeNode>();

            for (int l = 0; l < n; l++)
            {
                int r = n - 1 - l;
                var leftTrees = Backtrack(l);
                var rightTrees = Backtrack(r);

                foreach (var t1 in leftTrees)
                {
                    foreach (var t2 in rightTrees)
                    {
                        res.Add(new TreeNode(0, t1, t2));
                    }
                }
            }

            return res;
        }

        return Backtrack(n);
    }
}

public partial class Solution
{
    public IList<TreeNode> AllPossibleFBT2(int n)
    {
        Dictionary<int, List<TreeNode>> dp = new Dictionary<int, List<TreeNode>>()
        {
            { 0, new List<TreeNode>() },
            { 1, new List<TreeNode>() { new TreeNode() } }
        };
        List<TreeNode> Backtrack(int n)
        {
            if (dp.ContainsKey(n))
            {
                return dp[n].ToList();
            }
            List<TreeNode> res = new List<TreeNode>();
            for (int l = 0; l < n; l++)
            {
                int r = n - 1 - l;
                List<TreeNode> leftTrees = Backtrack(l);
                List<TreeNode> rightTrees = Backtrack(r);

                foreach (TreeNode t1 in leftTrees)
                {
                    foreach (TreeNode t2 in rightTrees)
                    {
                        res.Add(new TreeNode(0, t1, t2));
                    }
                }
            }
            dp[n] = res;
            return res;
        }
        return Backtrack(n);
    }
}

public partial class Solution
{
    public IList<TreeNode> AllPossibleFBT3(int n)
    {
        /*Dictionary<int, TreeNode> dp = new();
        dp.Add(0,null);
        dp.Add(1,new TreeNode(0));*/
        Dictionary<int, int> dp = new();
        dp.Add(0,0);
        dp.Add(1,1);


        int Backtrack(int val)
        {
            if (dp.ContainsKey(val))
            {
                return dp[val];
            }

            for (int i = 0; i < val; i++)
            {
                int tempVal = Backtrack(i) * Backtrack(val - i - 1);
                if (dp.ContainsKey(val))
                {
                    dp[val]+= tempVal;
                }
                else
                {
                    dp.Add(val,tempVal);
                }
            }
            return dp[val];
        }

        Backtrack(n);
        return null;
    }
}
public partial class Solution
{
    public IList<TreeNode> AllPossibleFBT4(int n)
    {
        List<TreeNode> Backtrack(int n)
        {
            List<TreeNode> result = new List<TreeNode>();
            if (n == 1) {
                result.Add(new TreeNode(0));
                return result;
            }
            if (n % 2 == 0) {
                return result;
            }
            for (int i = 1; i < n; i += 2) {
                IList<TreeNode> leftSubtrees = Backtrack(i);
                IList<TreeNode> rightSubtrees = Backtrack(n - i - 1);
            
                foreach (TreeNode left in leftSubtrees) {
                    foreach (TreeNode right in rightSubtrees) {
                        TreeNode root = new TreeNode(0);
                        root.left = left;
                        root.right = right;
                        result.Add(root);
                    }
                }
            }
            return result;
        }
        return Backtrack(n);
    }
}