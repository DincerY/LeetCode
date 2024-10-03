Solution solution = new();
solution.MinCostClimbingStairs(new[]
{
    10, 15, 20
});
solution.MinCostClimbingStairs(new[]
{
    1, 100, 1, 1, 1, 100, 1, 1, 100, 1
});


Console.WriteLine("Hello, World!");

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] dp = new int[cost.Length + 2];
        dp[0] = 0;
        dp[1] = 0;
        for (int i = 0; i < cost.Length; i++)
        {
            int j = i + 2;
            dp[j] = cost[i] + Math.Min(dp[j - 1], dp[j - 2]);
        }
        return Math.Min(dp[^1], dp[^2]);
    }
}