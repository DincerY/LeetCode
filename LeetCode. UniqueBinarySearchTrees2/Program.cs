Solution solution = new();
solution.GenerateTrees(3);

// var node = solution.Insert(null,1);
// solution.Insert(node, 4);
// solution.Insert(node, 5);
// solution.Insert(node, 2);
// solution.Insert(node, 10);
// solution.Insert(node, 8);
List<string> res = new();
Geeksforgeeks.Permute(res,"1234",0,3);





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

//Neither solution belongs to me
public partial class Solution
{
    public IList<TreeNode> GenerateTrees(int n)
    {
        IList<TreeNode> Generate(int left, int right) 
        {
            var res = new List<TreeNode>();
            if (left == right) {
                res.Add(new TreeNode(left));
                return res;
            }
            if (left > right) {
                res.Add(null);
                return res;
            }
            for (int val = left; val < right+1; val++) {
                var leftTrees = Generate(left, val - 1);
                var rightTrees = Generate(val + 1, right);
                foreach (var leftTree in leftTrees) {
                    foreach (var rightTree in rightTrees) {
                        var root = new TreeNode(val, leftTree, rightTree);
                        res.Add(root);
                    }
                }
            }
            return res;
        }
        return Generate(1,n);
    }
}


public partial class Solution
{
    public IList<TreeNode> GenerateTreesCaching(int n)
    {
        Dictionary<(int, int), List<TreeNode>> dp = new Dictionary<(int, int), List<TreeNode>>();
        List<TreeNode> Generate(int left, int right) {
            if (left > right) {
                return new List<TreeNode> { null };
            }

            if (dp.ContainsKey((left, right))) {
                return dp[(left, right)];
            }

            List<TreeNode> res = new List<TreeNode>();
            for (int val = left; val <= right; val++) {
                foreach (TreeNode leftTree in Generate(left, val - 1)) {
                    foreach (TreeNode rightTree in Generate(val + 1, right)) {
                        TreeNode root = new TreeNode(val, leftTree, rightTree);
                        res.Add(root);
                    }
                }
            }

            dp[(left, right)] = res;
            return res;
        }
        return Generate(1,n);
    }
}





public class Geeksforgeeks
{
    public static void Permute(List<string> list,String str,int l, int r)  
    {  
        if (l == r)
            list.Add(str);
        else
        {  
            for (int i = l; i <= r; i++)  
            {  
                str = Swap(str, l, i);  
                Permute(list,str, l + 1, r);  
            }  
        }  
    }  
    private static String Swap(String a, int i, int j)  
    {  
        char[] charArray = a.ToCharArray();  
        (charArray[i], charArray[j]) = (charArray[j], charArray[i]);
        return new string(charArray);  
    }  
}

public class Permutation
{
    //permutasyon işlemi
    public static void Recursion(int[] nums,List<int> onePermutation,List<IList<int>> result)
    {
        if (onePermutation.Count == nums.Length)
        {
            result.Add(onePermutation.ToList());
            return;
        }
        else
        {
            foreach (var num in nums)
            {
                if (onePermutation.Contains(num))
                    continue;
                onePermutation.Add(num);
                Recursion(nums,onePermutation,result);
                onePermutation.RemoveAt(onePermutation.Count-1);
            }
        }
    }
}