Solution solution = new();
solution.MaxProfit2(
    new[] { 7, 1, 5, 3, 6, 4 });
// solution.MaxProfit2(
//     new[] { 7, 6, 4, 3 , 1 });


Console.WriteLine("Hello, World!");


//time limit exceeded
public partial class Solution {
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[i] < prices[j])
                {
                    profit = Math.Max(profit, Math.Abs(prices[i] - prices[j]));
                }
            }
        }


        return profit;
    }
}

public partial class Solution {
    public int MaxProfit2(int[] prices)
    {
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i -1])
            {
                profit = Math.Max(profit, prices[i] - prices[i - 1]);
                prices[i] = prices[i - 1];
            }
        }
        return profit;
    }
}