Solution solution = new();
solution.CountVowelStrings(1);
solution.CountVowelStrings(2);
solution.CountVowelStrings(3);
solution.CountVowelStrings(33);

Console.WriteLine("Hello, World!");


public class Solution
{
    //a, e, i, o, u
    public int CountVowelStrings(int n)
    {
        int[] dp = [1, 1, 1, 1, 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = dp.Length-2; j >= 0; j--)
            {
                dp[j] += dp[j + 1];
            }
        }
        return dp[0];
    }
}