Solution solution = new();
solution.MincostTickets(new[]
    {
        1, 4, 6, 7, 8, 20
    },
    new[]
    {
        2, 7, 15
    });

Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
{
    public int MincostTickets(int[] days, int[] costs)
    {
        Dictionary<int, int> dp = new Dictionary<int, int>();
        for (int i = days.Length - 1; i >= 0; i--)
        {
            dp[i] = int.MaxValue;
            for (int j = 0; j < costs.Length; j++)
            {
                int d = (j == 0) ? 1 : (j == 1) ? 7 : 30;
                int k = i;
                while (k < days.Length && days[k] < days[i] + d)
                {
                    k++;
                }
    
                dp[i] = Math.Min(dp[i], costs[j] + (dp.ContainsKey(k) ? dp[k] : 0));
            }
        }
        return dp[0];
    }
}