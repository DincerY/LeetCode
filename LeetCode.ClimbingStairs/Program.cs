﻿Solution solution = new();
solution.ClimbStairs4(5);


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

/// <summary>
/// Dinamik programlama tabulation yaklaşımı
/// </summary>
public partial class Solution {
    public int ClimbStairsDp(int n)
    {
        int[] dp = new int[n +1];
        dp[^1] = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            if (n - i >= 2)
            {
                dp[i] = dp[i + 1];
                dp[i] += dp[i + 2];
            }
            else
                dp[i] = dp[i + 1];
        }
        return dp[0];
    }
}


public partial class Solution {
    public int ClimbStairs2(int n)
    {
        var one = 1;
        var two = 1;
        for (int i = 0; i < n - 1; i++)
        {
            var sum = one + two;
            one = two;
            two = sum;
        }
        return two;
    }
}

public partial class Solution {
    public int ClimbStairs3(int n)
    {
        Dictionary<int, int> dp = new Dictionary<int, int>();
        int Backtrack(int step)
        {
            if (step >= n)
            {
                return step == n ? 1 : 0;
            }

            if (dp.ContainsKey(step))
            {
                return dp[step];
            }
            
            dp[step] = Backtrack(step+1) + Backtrack(step+2);
            return dp[step];
        }
        return Backtrack(0);
    }
    
    public int ClimbStairs4(int n)
    {
        int[] dp = new int[n + 1];
        dp[^1] = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            if (n - i >= 2)
            {
                dp[i] = dp[i + 1];
                dp[i] += dp[i + 2];
            }
            else
            {
                dp[i] = dp[i + 1];
            }
        }

        return dp[0];
    }
    
    public int ClimbStairs5(int n)
    {
        int ptrL = 1;
        int ptrR = 1;
        for (int i = 0; i < n-1; i++)
        {
            int sum = ptrL + ptrR;
            ptrR = ptrL;
            ptrL = sum;
        }

        return ptrL;
    }
}