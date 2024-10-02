Solution solution = new();
solution.LongestPalindromeSubseq("bbbab");


Console.WriteLine("Hello, World!");

public class Solution
{
    public int LongestPalindromeSubseq(string s)
    {
        int[,] dp = new int[s.Length + 1,s.Length + 1];
        string reverse = new string(s.Reverse().ToArray());


        for (int i = s.Length - 1; i >= 0; i--)
        {
            for (int j = s.Length - 1; j >= 0; j--)
            {
                if (s[i] == reverse[j])
                {
                    dp[i,j] = 1 + dp[i + 1, j + 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }
            }
        }


        return dp[0,0];
    }
}