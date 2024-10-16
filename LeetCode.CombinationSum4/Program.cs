Solution solution = new();
solution.CombinationSum4Dp(new[] { 1, 2, 3 }, 4);
solution.CombinationSum4(new[] { 9 }, 3);


Console.WriteLine("Hello, World!");

//Time Limit Exceeded
public partial class Solution
{
    public int CombinationSum4(int[] nums, int target)
    {
        int res = 0;

        void Backtrack(int value)
        {
            if (value > target)
            {
                return;
            }

            if (value == target)
            {
                res++;
            }

            foreach (var num in nums)
            {
                Backtrack(value + num);
            }
        }

        Backtrack(0);
        return res;
    }
}

//NeetCode solution
public partial class Solution
{
    public int CombinationSum4Dp(int[] nums, int target)
    {
        Dictionary<int, int> dp = new Dictionary<int, int> { { 0, 1 } };

        for (int total = 1; total <= target; total++)
        {
            dp[total] = 0;
            foreach (int n in nums)
            {
                dp[total] += dp.ContainsKey(total - n) ? dp[total - n] : 0;
            }
        }

        return dp.ContainsKey(target) ? dp[target] : 0;
    }
}