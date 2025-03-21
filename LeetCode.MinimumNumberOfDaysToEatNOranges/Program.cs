Solution solution = new();
solution.MinDays3(10);
solution.MinDays3(6);

Console.WriteLine("Hello, World!");


public partial class Solution {
    public int MinDays(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        int min = 10000000;
        void Backtrack(int val,int days)
        {
            if (val == 0)
            {
                min = Math.Min(min, days);
                return;
            }
            Backtrack(val-1,days+1);
            if (val % 3 == 0)
            {
                Backtrack(val -((val / 3) * 2),days+1);
            }

            if (val % 2 == 0)
            {
                Backtrack(val - (val/2),days+1);
            }
        }
        Backtrack(n,0);
        return min;
    }
}


public partial class Solution {
    public int MinDays2(int n)
    {
        int[] dp = new int[n+1];
        for (int i = n-1; i >= 0; i--)
        {
            var val = n - i;
            dp[i] = dp[i + 1] + 1;
            
            if (val % 2 == 0)
            {
                int temp = i + (val / 2);
                dp[i] = Math.Min(dp[i], dp[temp]+1);
            }

            if (val % 3 == 0)
            {
                int temp = i + ((val / 3) * 2);
                dp[i] = Math.Min(dp[i],dp[temp]+1);
            }
        }
        return dp[0];
    }
}
public partial class Solution {
    public int MinDays3(int n) 
    {
        Dictionary<int, int> dp = new Dictionary<int, int> 
        {
            { 0, 0 },
            { 1, 1 }
        };
        int Dfs(int val) 
        {
            if (dp.ContainsKey(val)) 
            {
                return dp[val];
            }
            int one = 1 + (val % 2) + Dfs(val / 2);
            int two = 1 + (val % 3) + Dfs(val / 3);
            dp[val] = Math.Min(one, two);
            return dp[val];
        }
        return Dfs(n);
    }
}