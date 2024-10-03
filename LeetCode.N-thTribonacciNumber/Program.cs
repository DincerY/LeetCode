Solution solution = new();
solution.Tribonacci(4);

Console.WriteLine("Hello, World!");

public class Solution
{
    public int Tribonacci(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 1;

        for (int i = 3; i < n + 1; i++)
        {
            if (i >= 3)
            {
                dp[i] = dp[i-1] + dp[i-2] + dp[i-3];
            }
            
        }

        return dp[n];
    }
}