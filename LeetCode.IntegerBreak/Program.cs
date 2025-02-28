Solution solution = new();
solution.IntegerBreak4(2);
solution.IntegerBreak4(3);
solution.IntegerBreak4(4);
solution.IntegerBreak4(5);
solution.IntegerBreak4(10);

Console.WriteLine("Hello, World!");

//NeedCode solutions
public partial class Solution
{
    public int IntegerBreak(int n)
    {
        Dictionary<int, int> dp = new Dictionary<int, int> { { 1, 1 } };

        int Dfs(int num)
        {
            if (dp.ContainsKey(num))
            {
                return dp[num];
            }

            dp[num] = (num == n) ? 0 : num;
            for (int i = 1; i < num; i++)
            {
                int val = Dfs(i) * Dfs(num - i);
                dp[num] = Math.Max(dp[num], val);
            }

            return dp[num];
        }

        return Dfs(n);
    }
}


//Dynamic programming
public partial class Solution
{
    public int IntegerBreak2(int n)
    {
        Dictionary<int, int> dp = new Dictionary<int, int> { { 1, 1 } };

        for (int num = 2; num <= n; num++)
        {
            dp[num] = (num == n) ? 0 : num;
            for (int i = 1; i < num; i++)
            {
                int val = dp[i] * dp[num - i];
                dp[num] = Math.Max(dp[num], val);
            }
        }

        return dp[n];
    }
}

public partial class Solution
{
    public int IntegerBreak3(int n)
    {
        int[] dp = new int[n+1];
        Array.Fill(dp,-1);
        dp[0] = 0;
        dp[1] = 1;

        int Backtrack(int val,int final)
        {
            if (dp[val] != -1)
            {
                return dp[val];
            }
            for (int i = 1; i <= val; i++)
            {
                int mult = Backtrack(i,final) * Backtrack(val - i,final);
                dp[val] = Math.Max(dp[val], mult);
            }

            if (val != final)
            {
                dp[val] = Math.Max(dp[val],val);
            }
            return dp[val];
        }

        return Backtrack(n,n);

    }
}

public partial class Solution
{
    public int IntegerBreak4(int n)
    {
        int[] dp = new int[n+1];
        dp[1] = 1;
        for (int i = 2; i < n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                int mult = dp[j] * dp[i-j];
                dp[i] = Math.Max(dp[i], mult);
            }
        }
        return dp[^1];
    }
}
