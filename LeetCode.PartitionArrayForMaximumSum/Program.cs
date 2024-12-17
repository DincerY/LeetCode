Solution solution = new();
//solution.MaxSumAfterPartitioningDp(new[] { 1, 15, 7, 9, 2, 5, 10 }, 3);
solution.MaxSumAfterPartitioningMemory(new[] { 1, 2, 3, 4, 6 }, 3);


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int MaxSumAfterPartitioningDp(int[] arr, int k)
    {
        Dictionary<int, int> cache = new Dictionary<int, int>();

        int Dfs(int i)
        {
            if (i >= arr.Length)
            {
                return 0;
            }
            if (cache.ContainsKey(i))
            {
                return cache[i];
            }

            int curMax = 0;
            int res = 0;
            for (int j = i; j < Math.Min(arr.Length, i + k); j++)
            {
                curMax = Math.Max(curMax, arr[j]);
                int windowSize = j - i + 1;
                res = Math.Max(res, Dfs(j + 1) + curMax * windowSize);
            }
            cache[i] = res;
            return res;
        }
        return Dfs(0);
    }
}


public partial class Solution
{
    public int MaxSumAfterPartitioning(int[] arr, int k)
    {
        int[] res = new int[arr.Length+1];
        res[1] = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            res[i + 1] = arr[i] + res[i];
            int maxVal = arr[i];

            for (int j = i-1; j >= 0 && i-j < k; j--)
            {
                maxVal = Math.Max(maxVal, arr[j]);
                res[i + 1] = Math.Max(res[i+1],(maxVal * (i-j+1)) + res[j]);
            }
        }


        return res[^1];

    }
}

//kayıtları bir uzun array yerine 3 tane veri tutan array ile tuttuk ve bu şekilde bellekten tasarruf ettik

public partial class Solution
{
    public int MaxSumAfterPartitioningMemory(int[] arr, int k)
    {
        int[] dp = new int[k];
        dp[0] = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            int curMax = 0;
            int maxAtI = 0;
            for (int j = i; j >= i - k + 1; j--)
            {
                if (j < 0)
                {
                    break;
                }
                curMax = Math.Max(curMax, arr[j]);
                int windowSize = i - j + 1;
                int curSum = curMax * windowSize;
                int subSum = (j > 0) ? dp[(j - 1) % k] : dp[k - 1];
                maxAtI = Math.Max(maxAtI, curSum + subSum);
            }
            dp[i % k] = maxAtI;
        }
        return dp[(arr.Length - 1) % k];
    }
}