Solution solution = new();
solution.Paint(new []
{
    new []{17,2,17},
    new []{16,16,5},
    new []{14,3,19}
});

Console.WriteLine("Hello, World!");


public class Solution
{
    public int Paint(int[][] costs)
    {
        int[][] dp = new int[costs.Length][];
        Array.Fill(dp,new int[3]);
        dp[0] = costs[0].ToArray();
        
        for (int i = 1; i < costs.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int min = ArrayMin(dp[i-1], j);
                dp[i][j] = min + costs[i][j];
            }   
        }
        return ArrayMin(dp[^1],-1);
    }

    private int ArrayMin(int[] arr, int ignore)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == ignore)
            {
                continue;
            }

            min = Math.Min(min,arr[i]);
        }
        return min;
    }
}