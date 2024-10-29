Solution solution = new();
solution.IntegerBreak2(2);
solution.IntegerBreak2(4);
solution.IntegerBreak2(10);

Console.WriteLine("Hello, World!");

//NeedCode solutions
public partial class Solution
{
    public int IntegerBreak(int n)
    {
        Dictionary<int, int> dp = new Dictionary<int, int> { { 1, 1 } };

        int Dfs(int num)
        {
            if (dp.ContainsKey(num))
            {
                return dp[num];
            }

            dp[num] = (num == n) ? 0 : num;
            for (int i = 1; i < num; i++)
            {
                int val = Dfs(i) * Dfs(num - i);
                dp[num] = Math.Max(dp[num], val);
            }

            return dp[num];
        }

        return Dfs(n);
    }
}


//Dynamic programming
public partial class Solution
{
    public int IntegerBreak2(int n)
    {
        Dictionary<int, int> dp = new Dictionary<int, int> { { 1, 1 } };

        for (int num = 2; num <= n; num++)
        {
            dp[num] = (num == n) ? 0 : num;
            for (int i = 1; i < num; i++)
            {
                int val = dp[i] * dp[num - i];
                dp[num] = Math.Max(dp[num], val);
            }
        }

        return dp[n];
    }
}