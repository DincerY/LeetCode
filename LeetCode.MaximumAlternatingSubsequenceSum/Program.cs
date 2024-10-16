Solution solution = new();
solution.MaxAlternatingSum(new[] { 4, 2, 5, 3 });
solution.MaxAlternatingSum(new[] { 5, 6, 7, 8 });


Console.WriteLine("Hello, World!");


//LeetCode solution
//too hard
public partial class Solution
{
    public int MaxAlternatingSum(int[] nums)
    {
        Dictionary<(int, bool), int> dp = new Dictionary<(int, bool), int>();

        int Dfs(int i, bool even)
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