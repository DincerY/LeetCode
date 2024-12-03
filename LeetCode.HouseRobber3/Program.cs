Solution solution = new();
solution.Rob(new TreeNode(3,new TreeNode(2,null,new TreeNode(3)),new TreeNode(3,null,new TreeNode(1))));

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
        return 0;
    }
}