Solution solution = new();
solution.IntegerBreak3(2);
solution.IntegerBreak3(3);
solution.IntegerBreak3(4);
solution.IntegerBreak3(5);
solution.IntegerBreak3(10);

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
        if (n == 2)
        {
            return 1;
        }

        if (n == 3)
        {
            return 2;
        }
        int res;
        int count = (int)Math.Sqrt(n);
        int val = n / count;
        res = count * val;
        int temp = 0;
        for (int i = 0; i < count-1; i++)
        {
            temp += val;
        }

        if (res != n)
        {
            res *= (n - temp);
        }
        return res;   
    }
}
