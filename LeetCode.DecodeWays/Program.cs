Solution solution = new();
solution.NumDecodings2("11106");


Console.WriteLine("Hello, World!");





public partial class Solution {
    public int NumDecodings(string s)
    {


        return 0;
    }
}


/// <summary>
/// It is not mine solution
/// </summary>
public partial class Solution {
    public int NumDecodings2(string s) {
        if (string.IsNullOrEmpty(s) || s[0] == '0') {
            return 0;
        }

        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= n; ++i) {
            int oneDigit = s[i - 1] - '0';
            int twoDigits = int.Parse(s.Substring(i - 2, 2));

            if (oneDigit != 0) {
                dp[i] += dp[i - 1];
            }

            if (10 <= twoDigits && twoDigits <= 26) {
                dp[i] += dp[i - 2];
            }
        }

        return dp[n];
    }
}