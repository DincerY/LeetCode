Solution solution = new();
solution.MaxProfit2(new[] { 7, 1, 5, 3, 6, 4 });
//solution.MaxProfit(new[] { 1,2,3,4,5 });
//solution.MaxProfit(new[] { 7, 6, 4, 3, 1 });
//solution.MaxProfit(new[] { 1, 7, 4, 2 });


Console.WriteLine("Hello, World!");


public partial class Solution
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

//it is not mine solution
public partial class Solution
{
    public int MaxProfit2(int[] prices)
    {
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += (prices[i] - prices[i - 1]);
            }
        }
        return profit;
    }
}