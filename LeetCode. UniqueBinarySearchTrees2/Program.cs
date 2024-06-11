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
public partial class Solution
{
    public IList<TreeNode> GenerateTrees(int n)
    {
        List<TreeNode> res = new();
        List<IList<int>> per = new();
        int[] arr = new int[n];
        for (int i = 0; i < 3; i++) arr[i] = i+1;
        Recursion(arr,new List<int>(),per);
         

        foreach (var i in per)
        {
            TreeNode temp = null;
            foreach (var val in i)
            {
                temp = Insert(temp, val);
            }
            if (!res.Contains(temp))
            {
                res.Add(temp);
            }
        }
        return res;
        
    }
    
    //permutasyon işlemi
    public void Recursion(int[] nums,List<int> onePermutation,List<IList<int>> result)
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


public partial class Solution
{
    public TreeNode Insert(TreeNode Node,int n)
    {
        if (Node == null)
        {
            return new TreeNode(n);
        }
        if (n < Node.val)
        {
            Node.left = Insert(Node.left, n);
        }
        if (n > Node.val)
        {
            Node.right = Insert(Node.right, n);
        }
        return Node;
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