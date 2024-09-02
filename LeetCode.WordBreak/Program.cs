Solution solution = new();
//solution.WordBreak("leetcode", new List<string>() { "leet", "code" });
//solution.WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" });
//solution.WordBreak("applepenapple", new List<string>() { "apple", "pen" });
//solution.WordBreak("cars", new List<string>() { "car", "ca","rs" });
solution.WordBreak("leetcode", new List<string>() { "le", "et","co","de" });


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        bool[] dp = new bool[s.Length + 1];
        dp[^1] = true;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            foreach (var w in wordDict)
            {
                if (i + w.Length <= s.Length && s.Substring(i, w.Length) == w)
                {
                    dp[i] = dp[i + w.Length];
                }

                if (dp[i])
                {
                    break;
                }
            }
        }
        
        return dp[0];
    }
}
