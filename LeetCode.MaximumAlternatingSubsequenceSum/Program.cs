Solution solution = new();
solution.MaxAlternatingSum2(new[] { 4, 2, 5, 3 });
solution.MaxAlternatingSum(new[] { 5, 6, 7, 8 });


Console.WriteLine("Hello, World!");


//LeetCode solution
//too hard
public partial class Solution
{
    public long MaxAlternatingSum(int[] nums)
    {
        Dictionary<(int, bool), long> dp = new Dictionary<(int, bool), long>();

        long Dfs(int i, bool even)
        {
            if (i == nums.Length)
            {
                return 0;
            }

            if (dp.ContainsKey((i, even)))
            {
                return dp[(i, even)];
            }

            int total = even ? nums[i] : -nums[i];
            dp[(i, even)] = Math.Max(total + Dfs(i + 1, !even), Dfs(i + 1, even));
            return dp[(i, even)];
        }

        return Dfs(0, true);
    }
}

public partial class Solution
{
    public long MaxAlternatingSum2(int[] nums)
    {
        long sumEven = 0, sumOdd = 0;

        for (int i = nums.Count() - 1; i >= 0; i--)
        {
            long tmpEven = Math.Max(sumOdd + nums[i], sumEven);
            long tmpOdd = Math.Max(sumEven - nums[i], sumOdd);
            sumEven = tmpEven;
            sumOdd = tmpOdd;
        }

        return sumEven;
    }
}