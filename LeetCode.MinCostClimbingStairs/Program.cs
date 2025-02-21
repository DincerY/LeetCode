Solution solution = new();
solution.MinCostClimbingStairs4(new[]
{
    10, 15, 20
});
solution.MinCostClimbingStairs(new[]
{
    1, 100, 1, 1, 1, 100, 1, 1, 100, 1
});


Console.WriteLine("Hello, World!");

public partial class Solution
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


public partial class Solution
{
    public int MinCostClimbingStairs2(int[] cost)
    {
        int min = 10000;
        void Backtrack(int stair, int total)
        {
            if (stair >= cost.Length-1)
            {
                min = Math.Min(min, total);
                return;
            }
            Backtrack(stair+1,total+cost[stair+1]);
            int temp = 0;
            if (stair + 2 < cost.Length)
            {
                temp = total + cost[stair + 2];
            }
            Backtrack(stair+2,temp == 0 ? total : temp);
        }
        Backtrack(0,cost[0]);
        Backtrack(1,cost[1]);
        return min;
    }
}


public partial class Solution
{
    public int MinCostClimbingStairs3(int[] cost)
    {
        int[] dp = new int[cost.Length + 3];
        for (int i = cost.Length; i >= 1; i--)
        {
            int min = Math.Min(dp[i + 1], dp[i + 2]);
            dp[i] = min + cost[i-1];
        }
        return Math.Min(dp[1], dp[2]);
    }
}

public partial class Solution
{
    public int MinCostClimbingStairs4(int[] cost)
    {
        int firstBlock = 0;
        int secondBlock = 0;
        for (int i = cost.Length-1; i >= 0; i--)
        {
            int min = Math.Min(firstBlock, secondBlock);
            secondBlock = firstBlock;
            firstBlock = min + cost[i];
        }
        return Math.Min(firstBlock, secondBlock);
    }
}