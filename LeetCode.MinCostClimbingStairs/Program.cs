Solution solution = new();
solution.MinCostClimbingStairs3(new[]
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

//Bu kod tam bitmedi (devam edicem)
public partial class Solution
{
    public int MinCostClimbingStairs2(int[] cost)
    {
        int min = 10000;
        void Backtrack(int stair, int total)
        {
            if (stair >= cost.Length)
            {
                min = Math.Min(min, total);
                return;
            }
            Backtrack(stair+1,total+cost[stair]);
            var temp = 0;
            if (stair+2 < cost.Length)
            {
                temp = total + cost[stair + 2];
            }
            Backtrack(stair+2,temp==0?total:temp);
        }
        Backtrack(0,0);
        return 0;
    }
}

//bunu bir array yerine sadece iki tane değişken ile yapabiliriz (devam edicem)
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