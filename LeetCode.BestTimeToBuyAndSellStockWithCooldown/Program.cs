Solution solution = new();
solution.MaxProfit(new[] { 1, 2, 3, 0, 2 });

Console.WriteLine("Hello, World!");

//NeedCode solution 
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        Dictionary<(int, bool), int> dp = new Dictionary<(int, bool), int>();

        int Dfs(int i, bool buying)
        {
            if (i >= prices.Length)
            {
                return 0;
            }

            if (dp.ContainsKey((i, buying)))
            {
                return dp[(i, buying)];
            }

            int cooldown = Dfs(i + 1, buying);
            if (buying)
            {
                int buy = Dfs(i + 1, !buying) - prices[i];
                dp[(i, buying)] = Math.Max(buy, cooldown);
            }
            else
            {
                int sell = Dfs(i + 2, !buying) + prices[i];
                dp[(i, buying)] = Math.Max(sell, cooldown);
            }

            return dp[(i, buying)];
        }

        return Dfs(0, true);
    }
}