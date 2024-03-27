Solution solution = new();
solution.ClimbStairs(5);


Console.WriteLine("Hello, World!");

/// <summary>
/// Brute force solution
/// </summary>
public partial class Solution {
    public int ClimbStairs(int n)
    {
        int count = 0;
        void Recusion(int sum)
        {       
            if (sum > n)
            {
                return;
            }
            else if (sum == n)
            {
                count++;
            }
            Recusion(sum+1);
            Recusion(sum+2);
        }
        Recusion(0);
        return count;
    }
}

public partial class Solution {
    public int ClimbStairsDp(int n)
    {
        int[] dp = new int[n + 1];

        dp[0] = 1;

        for (int i = 1; i <= n; ++i)
        {
            dp[i] = dp[i - 1];

            if (i >= 2)
            {
                dp[i] += dp[i - 2];
            }
        }
        return dp[n];
    }
}

/// <summary>
/// It is not my solution
/// </summary>
public partial class Solution {
    public int ClimbStairs3(int n) {
        if (n <= 2) {
            return n;
        }

        int p1 = 1;
        int p2 = 2;
        int c = 0;

        for (int i = 1; i < n - 1; ++i) {
            c = p1 + p2;
            p1 = p2;
            p2 = c;
        }

        return c;
    }
}