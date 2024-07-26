Solution solution = new();
solution.SortedArrayToBST(new[] { -10, -3, 0, 5, 9 });
//solution.SortedArrayToBST(new[] { 0, 1, 2, 3, 4, 5 });

//solution.SortedArrayToBST(new[] { 1,2});

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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length < 1)
        {
            return null;
        }
        TreeNode Recursive(int l, int r)
        {
            int mid = (r + l) / 2;
            if (l > r)
            {
                return null;
            }
            TreeNode root = new(nums[mid]);

            root.left = Recursive(l,mid - 1);
            root.right = Recursive(mid + 1,r);

            return root;
        }

        return Recursive(0,nums.Length-1);
    }
}