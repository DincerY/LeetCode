Solution solution = new();
solution.LongestCommonSubsequenceNoMemory("abcde", "ace");
solution.LongestCommonSubsequenceNoMemory("bl", "yby");

Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        int[,] dp = new int[text1.Length + 1, text2.Length + 1];

        for (int i = text1.Length - 1; i >= 0; i--)
        {
            for (int j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    dp[i, j] = 1 + dp[i + 1, j + 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i, j + 1], dp[i + 1, j]);
                }
            }
        }

        return dp[0, 0];
    }
}



public partial class Solution
{
    public int LongestCommonSubsequence2(string text1, string text2)
    {
        int[,] dp = new int[text2.Length+1,text1.Length+1];
        for (int i = text2.Length-1; i >= 0 ; i--)
        {
            for (int j = text1.Length-1; j >= 0; j--)
            {
                if (text2[i] == text1[j])
                {
                    dp[i, j] += dp[i + 1, j + 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i+1,j],dp[i, j + 1]);
                }
            }
        }
        return dp[0,0];
    }
}


public partial class Solution
{
    public int LongestCommonSubsequenceNoMemory(string text1, string text2)
    {
        int[] dp = new int[text1.Length+1];
        for (int i = text2.Length-1; i >= 0 ; i--)
        {
            int prev = 0;
            for (int j = text1.Length-1; j >= 0; j--)
            {
                int temp = dp[j];
                if (text2[i] == text1[j])
                {
                    dp[j] = prev + 1;
                }
                else
                {
                    dp[j] = Math.Max(dp[j], dp[j+1]);
                }
                prev = temp;
            }
        }
        return dp[0];
    }
}