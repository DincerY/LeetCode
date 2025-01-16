Solution solution = new();
solution.Rob2(new[]
{
    2, 3, 2
});

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        int val1 = Helper(nums[1..]);
        int val2 = Helper(nums[..^1]);
        return Math.Max(val1, val2);
    }

    private int Helper(int[] arr)
    {
        int rob1 = 0;
        int rob2 = 0;
        bool isFirst = false;
        foreach (var n in arr)
        {
            int tmp = Math.Max(n + rob1, rob2);
            rob1 = rob2;
            rob2 = tmp;
        }

        return rob2;
    }
}



public partial class Solution
{
    public int Rob2(int[] nums)
    {
        int Max(int[] arr)
        {
            int left, right =0;
            for (int i = 0; i < arr.Length; i++)
            {
                var temp = nums[i] + ((i - 2) >= 0 ? nums[i - 2] : 0);
                left = right;
                right = Math.Max(left,temp);
            }
            return right;
        }
        
        
        return Math.Max(Max(nums[1..]),Max(nums[..^1]));
    }
}
