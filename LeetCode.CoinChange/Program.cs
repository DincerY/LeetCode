Solution solution = new();
solution.CoinChange(new[] { 1, 2, 5 }, 11);
solution.CoinChange(new[] { 2 }, 3);

Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount +1];
        for (int i = 1; i < amount+1; i++)
        {
            dp[i] = amount + 1;
        }

        for (int a = 1; a < dp.Length; a++)
        {
            foreach (var c in coins)
            {
                if (a - c >= 0)
                {
                    dp[a] = Math.Min(dp[a], 1 + dp[a - c]);
                }
            }
        }
        return dp[amount] != amount + 1 ? dp[amount] : -1;
    }
}