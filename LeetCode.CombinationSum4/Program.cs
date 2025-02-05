Solution solution = new();
solution.CombinationSum4Dif(new[] { 1, 2, 3 }, 4);
solution.CombinationSum4Dif(new[] { 9 }, 3);


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

//Dynamic programming tabulation approach
public partial class Solution
{
    public int CombinationSum4Dif(int[] nums, int target)
    {
        int[] arr = new int[target + 1];
        arr[0] = 1;
        for (int i = 1; i <= target; i++)
        {
            foreach (var num in nums)
            {
                int val = i - num;
                if (val >= 0)
                {
                    arr[i] += arr[val];
                }
            }
        }
        return arr[target];
    }
}
