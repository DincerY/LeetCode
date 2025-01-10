Solution solution = new();
//solution.NumDecodings("11106");
solution.NumDecodings4("12");
solution.NumDecodings4("226");

solution.NumDecodings4("12321");
solution.NumDecodings4("06");


Console.WriteLine("Hello, World!");

/// <summary>
/// I got it and resolve
/// </summary>
public partial class Solution
{
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;
        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            int oneDigit = s[i - 1] - '0';
            var twoDigit = int.Parse(s.Substring(i - 2, 2));
            if (oneDigit is not 0)
                dp[i] += dp[i - 1];
            if (twoDigit is >= 10 and <= 26)
                dp[i] += dp[i - 2];
        }

        return dp[n];
    }
}


public partial class Solution
{
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
                current += oneBack;
            }

            int twoDigit = (s[i - 1] - '0') * 10 + (s[i] - '0');
            if (10 <= twoDigit && twoDigit <= 26)
            {
                current += twoBack;
            }

            (twoBack, oneBack) = (oneBack, current);
        }

        return oneBack;
    }
}


public partial class Solution
{
    public int NumDecodings3(string s)
    {
        Dictionary<int, int> dp = new Dictionary<int, int> { { s.Length, 1 } };

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '0')
            {
                dp[i] = 0;
            }
            else
            {
                dp[i] = dp[i + 1];
            }

            if (i + 1 < s.Length && (s[i] == '1' || (s[i] == '2' && "0123456".Contains(s[i + 1]))))
            {
                dp[i] += dp[i + 2];
            }
        }

        return dp[0];
    }
}


public partial class Solution
{
    public int NumDecodings4(string s)
    {
        int res = 0;

        void Backtrack(int index)
        {
            if (index >= s.Length)
            {
                if (index == s.Length)
                {
                    res++;
                }

                return;
            }

            if (s[index] - 48 > 0)
            {
                Backtrack(index + 1);
            }
            else
            {
                return;
            }
            if (s[index] != 0 && index + 1 < s.Length)
            {
                var val = int.Parse(s.Substring(index, 2));
                if (val < 27)
                {
                    Backtrack(index + 2);
                }
            }
        }
        Backtrack(0);
        return res;
    }
}