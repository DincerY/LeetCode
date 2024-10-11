Solution solution = new();
solution.Jump(new[] { 2, 3, 1, 1, 4 });
//solution.Jump(new[] { 2, 3, 0, 1, 4 });
//solution.Jump(new[] { 1,2,1,1,1 });

Console.WriteLine("Hello, World!");

public class Solution
{
    public int Jump(int[] nums)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp,int.MaxValue);
        dp[^1] = 0;

        for (int i = dp.Length - 2; i >= 0; i--)
        {
            for (int j = 1; j <= nums[i]; j++)
            {
                if (i + j < dp.Length)
                {
                    if (dp[i+j] == int.MaxValue)
                    {
                        continue;
                    }
                    dp[i] = Math.Min(dp[i], dp[i+j] + 1);
                }
                else
                {
                    break;
                }
            }
        }
        
        return dp[0];
    }
}