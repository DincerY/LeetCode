Solution solution = new();
solution.MaxProfit(2, new []
{
    3,2,6,5,0,3
});
solution.MaxProfit(2, new []
{
    3,3,5,0,0,3,1,4
});

Console.WriteLine("Hello, World!");

//it is not worked
public partial class Solution
{
    public int MaxProfit(int k, int[] prices)
    {
        List<int> list = new();
        for (int i = 0; i < prices.Length-1; i++)
        {
            int j;
            if (prices[i] < prices[i+1])
            {
                j = i + 1;
                while (j < prices.Length - 1)
                {
                    if (prices[j + 1] > prices[j])
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
                list.Add(prices[j] - prices[i]);
                i = j;
            }
        }

        int sum = 0;
        var arr = list.ToArray();
        Array.Sort(arr);
        arr = arr.Reverse().ToArray();
        k = k > arr.Length ? arr.Length : k;
        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
}
