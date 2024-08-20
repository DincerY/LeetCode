Solution solution = new();
//solution.MaxProfit(new[] { 3, 3, 5, 0, 0, 3, 1, 4 });
solution.MaxProfit(new[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 });


Console.WriteLine("Hello, World!");

//it is not accepted
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 1)
        {
            return 0;
        }

        List<int> list = new();
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
            else
            {
                list.Add(profit);
                profit = 0;
            }
        }

        if (profit != 0)
        {
            list.Add(profit);
        }

        var arr = list.ToArray();
        if (arr[0] < 0)
        {
            return 0;
        }

        Array.Sort(arr);
        Array.Reverse(arr);
        if (arr.Length > 1)
        {
            return arr[0] + arr[1];
        }
        else
        {
            return arr[0];
        }
    }
}