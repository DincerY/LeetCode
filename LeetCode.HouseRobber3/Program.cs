Solution solution = new();
solution.Rob(new TreeNode(3,new TreeNode(2,null,new TreeNode(3)),new TreeNode(3,null,new TreeNode(1))));
solution.Rob(new TreeNode(3,new TreeNode(20,new TreeNode(100),null),new TreeNode(4,null,new TreeNode(1))));

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

public class Solution
{
    public int Rob(TreeNode root)
    {
        //bir üst seviyeye çıktığımızda aslında bir alt seviyenin en büyüğünü hesaplamış oluyoruz ondan tekrar hesaplamaya gerek yok
        (int withRoot,int withoutRoot) Dfs(TreeNode node)
        {
            if (node == null)
            {
                return (0,0);
            }
            var left = Dfs(node.left);
            var right =  Dfs(node.right);
            return (left.withoutRoot + right.withoutRoot + node.val,Math.Max(left.withRoot,left.withoutRoot) + Math.Max(right.withRoot,right.withoutRoot));
        }
        
        var values = Dfs(root);
        return Math.Max(values.withRoot, values.withoutRoot);
    }
}