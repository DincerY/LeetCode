Solution solution = new();
//solution.NumDecodings("11106");
solution.NumDecodings2("12321");


Console.WriteLine("Hello, World!");

/// <summary>
/// I got it and resolve
/// </summary>
public partial class Solution {
    public int NumDecodings(string s) {
        if (string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;
        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            int oneDigit = s[i -1] - '0';
            var twoDigit = int.Parse(s.Substring(i - 2,2));
            if (oneDigit is not 0)
                dp[i] += dp[i - 1];
            if (twoDigit is >= 10 and <= 26) 
                dp[i] += dp[i - 2];
        }
        return dp[n];
    }
}


public partial class Solution {
    public int NumDecodings2(string s)
    {
        if (s[0] == '0')
        {
            return 0;
        }
        int oneBack = 1;
        int twoBack = 1;

        for (int i = 1; i < s.Length; i++)
        {
            int current = 0;
            if (s[i] != '0')
            {
                current+=oneBack;
            }
            int twoDigit = (s[i - 1] - '0') * 10 + (s[i]-'0');
            if (10<= twoDigit && twoDigit <= 26)
            {
                current += twoBack;
            }
            (twoBack, oneBack) = (oneBack, current);
        }
        return oneBack;
    }
}