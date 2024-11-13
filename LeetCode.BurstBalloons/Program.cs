Solution solution = new();
solution.MaxCoins(new[] { 3, 1, 5, 8 });

Console.WriteLine("Hello, World!");

//NeedCode's solution
public partial class Solution
{
    public int MaxCoins(int[] nums)
    {
        List<int> newNums = new List<int> { 1 };
        newNums.AddRange(nums);
        newNums.Add(1);
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Dfs(int l, int r)
        {
            if (l > r)
            {
                return 0;
            }

            if (dp.ContainsKey((l, r)))
            {
                return dp[(l, r)];
            }

            dp[(l, r)] = 0;
            for (int i = l; i <= r; i++)
            {
                int coins = newNums[l - 1] * newNums[i] * newNums[r + 1];
                coins += Dfs(l, i - 1) + Dfs(i + 1, r);
                dp[(l, r)] = Math.Max(dp[(l, r)], coins);
            }

            return dp[(l, r)];
        }

        return Dfs(1, newNums.Count - 2);
    }
}

