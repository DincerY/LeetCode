Solution solution = new();
solution.CountBits2(2);
solution.CountBits2(5);
solution.CountBits2(16);


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[] CountBits(int n)
    {
        int[] cache = new int[n + 1];
        int prev = 1;
        for (int i = 1; i <= n; i++)
        {
            if (int.IsPow2(i))
            {
                prev = i;
            }
            cache[i] = cache[i - prev] + 1;
        }
        return cache;
    }
}

public partial class Solution
{
    public int[] CountBits2(int n)
    {
        int[] dp = new int[n+1];
        for (int i = 1; i <= n; i++)
        {
            dp[i] = 10000;
            for (int j = 1; j <= i; j*=2)
            {
                if (i - j >= 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j]+1);
                }
            }
        }
        return dp;
    }
}
