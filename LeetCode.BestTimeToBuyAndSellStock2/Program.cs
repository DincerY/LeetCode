Solution solution = new();
//solution.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
//solution.MaxProfit(new[] { 1,2,3,4,5 });
//solution.MaxProfit(new[] { 7, 6, 4, 3, 1 });
solution.MaxProfit(new[] { 1, 7, 4, 2 });


Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int r = 1;
        int l = 0;
        int profit = 0;
        while (r < prices.Length - 1)
        {
            if (prices[r] < prices[l])
            {
                l = r;
            }
            else
            {
                if (prices[r] < prices[r + 1])
                {
                    r++;
                }
                else
                {
                    profit += prices[r] - prices[l];
                    l = r + 1;
                    r = l + 1;
                }
            }
        }

        if (r < prices.Length && prices[r] - prices[l] > 0)
        {
            profit += prices[r] - prices[l];
        }

        if (profit < 0)
        {
            return 0;
        }

        return profit;
    }
}