Solution solution = new();

solution.MaxProfit4(new[] { 1,2 });
solution.MaxProfit4(new[] { 7, 1, 5, 3, 6, 4 });
solution.MaxProfit4(new[] { 7, 6, 4, 3 , 1 });

Console.WriteLine("Hello, World!");

//time limit exceeded
public partial class Solution
{
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

public partial class Solution
{
    public int MaxProfit2(int[] prices)
    {
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit = Math.Max(profit, prices[i] - prices[i - 1]);
                prices[i] = prices[i - 1];
            }
        }

        return profit;
    }
}

//it is not mine solution
public partial class Solution
{
    public int MaxProfit3(int[] prices)
    {
        int l = 0, r = 1;
        int maxP = 0;
        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
            {
                maxP = Math.Max(maxP, prices[r] - prices[l]);
            }
            else
            {
                l = r;
            }
            r++;
        }
        return maxP;
    }
}

public partial class Solution
{
    public int MaxProfit4(int[] prices)
    {
        int l = 0;
        int r = 1;
        int max = 0;
        while (r < prices.Length && l < prices.Length)
        {
            if (l < r)
            {
                max = Math.Max(max, (prices[r] - prices[l]));
            }
            if (prices[l] <= prices[r])
            {
                r++;
            }
            else
            {
                l++;
            }
        }
        return max;
    }
}
