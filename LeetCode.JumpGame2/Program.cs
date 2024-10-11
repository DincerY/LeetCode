Solution solution = new();
//solution.Jump2(new[] { 2, 3, 1, 1, 4 });
//solution.Jump(new[] { 2, 3, 0, 1, 4 });
solution.Jump2(new[] { 1,2,1,1,1 });

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int Jump(int[] nums)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, int.MaxValue);
        dp[^1] = 0;

        for (int i = dp.Length - 2; i >= 0; i--)
        {
            for (int j = 1; j <= nums[i]; j++)
            {
                if (i + j < dp.Length)
                {
                    if (dp[i + j] == int.MaxValue)
                    {
                        continue;
                    }

                    dp[i] = Math.Min(dp[i], dp[i + j] + 1);
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

//LeetCode solution

public partial class Solution
{
    public int Jump2(int[] nums)
    {
        int res = 0;
        int l = 0, r = 0;

        while (r < nums.Length - 1)
        {
            int farthest = 0;
            for (int i = l; i <= r; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
            }

            l = r + 1;
            r = farthest;
            res++;
        }

        return res;
    }
}