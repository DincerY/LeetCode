Solution solution = new();
solution.Tribonacci(2);

Console.WriteLine("Hello, World!");

public class Solution
{
    public int Tribonacci(int n)
    {
        int[] dp = new int[n + 1];
        int[] tmp = new[] { 0, 1, 1 };

        for (int i = 0; i < n + 1; i++)
        {
            if (i >= 3)
            {
                dp[i] = dp[i-1] + dp[i-2] + dp[i-3];
            }
            else
            {
                dp[i] = tmp[i];
            }
            
        }

        return dp[n];
    }
}