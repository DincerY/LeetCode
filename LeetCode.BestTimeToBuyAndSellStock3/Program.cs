Solution solution = new();
//solution.MaxProfit(new[] { 3, 3, 5, 0, 0, 3, 1, 4 });
//solution.MaxProfit(new[] { 1,2,3,4,5 });
//solution.MaxProfit(new[] { 7, 6, 4, 3, 1 });
solution.MaxProfit(new[] { 2, 1, 4 });


Console.WriteLine("Hello, World!");

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 1)
        {
            return 0;
        }

        int left = 0;
        int right = 1;
        List<int> list = new();

        while (right < prices.Length)
        {
            if (right != prices.Length - 1)
            {
                if (prices[left] < prices[right] && prices[right] > prices[right + 1])
                {
                    list.Add(prices[right] - prices[left]);
                    left = right + 1;
                    right = left + 1;
                }
                else
                {
                    right++;
                }
            }
            else
            {
                if (right - left > 0)
                {
                    list.Add(prices[right] - prices[left]);
                    break;
                }
            }
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