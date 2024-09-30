Solution solution = new();
// solution.FindLongestChain(new[]
// {
//     new[] { 1, 2 },
//     new[] { 7, 8 },
//     new[] { 4, 5 },
// });
solution.FindLongestChain(new[]
{
    new[] { 1, 2 },
    new[] { 2, 3 },
    new[] { 3, 4 },
});


Console.WriteLine("Hello, World!");


public class Solution
{
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[0].CompareTo(b[0]));
        Dictionary<int, int> dp = new();

        for (int i = pairs.Length-1; i >= 0; i--)
        {
            dp[i] = 1;
            for (int j = i + 1; j < pairs.Length; j++)
            {
                if (pairs[i][1] < pairs[j][0])
                {
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }
            }
        }

        return dp[0];
    }
}