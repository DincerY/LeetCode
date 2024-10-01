Solution solution = new();
solution.FindLongestChain2(new[]
{
    new[] { 1, 2 },
    new[] { 7, 8 },
    new[] { 4, 5 },
});
// solution.FindLongestChain2(new[]
// {
//     new[] { 1, 2 },
//     new[] { 2, 3 },
//     new[] { 3, 4 },
// });


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[0].CompareTo(b[0]));
        int[] dp = new int[pairs.Length];
        for (int i = 0; i < pairs.Length; i++)
        {
            dp[i] = 1;
        }

        for (int i = 1; i < pairs.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (pairs[i][0] > pairs[j][1])
                {
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }
            }
        }

        return dp.Max();
    }
}


//NeedCode solution
public partial class Solution
{
    public int FindLongestChain2(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));
        int length = 1;
        int end = pairs[0][1];
        for (int i = 1; i < pairs.Length; i++)
        {
            if (end < pairs[i][0])
            {
                length++;
                end = pairs[i][1];
            }
        }
        return length;
    }
}