Solution solution = new();
solution.Rob(new[]
{
    2, 7, 9, 3, 1
});

Console.WriteLine("Hello, World!");

public class Solution
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