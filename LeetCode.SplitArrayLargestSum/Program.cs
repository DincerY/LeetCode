Solution solution = new();
solution.SplitArray(new[] { 7, 5, 10, 8 }, 3);
solution.SplitArray(new[] { 7, 2, 5, 10, 8 }, 3);

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Dfs(int i, int m)
        {
            if (m == 1)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                }
                return sum;
            }
            if (dp.ContainsKey((i,m)))
            {
                return dp[(i, m)];
            }
            int curSum = 0;
            int res = int.MaxValue;
            for (int j = i; j < nums.Length; j++)
            {
                curSum += nums[j];
                int temp = Math.Max(curSum, Dfs(j+1,m-1));
                res = Math.Min(res, temp);
                if (curSum > res)
                {
                    break;
                }
            }
            dp[(i,m)] = res;
            return res;
        }

        return Dfs(0, k);
    }
}