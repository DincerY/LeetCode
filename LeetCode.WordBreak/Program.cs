Solution solution = new();
//solution.WordBreak("leetcode", new List<string>() { "leet", "code" });
//solution.WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" });
//solution.WordBreak("applepenapple", new List<string>() { "apple", "pen" });
//solution.WordBreak("cars", new List<string>() { "car", "ca","rs" });


//solution.WordBreak2("leetcode", new List<string>() { "le", "et","co","de" });
//solution.WordBreak2("leetcode", new List<string>() { "leet","code" });
//solution.WordBreak3("applepenapple", new List<string>() { "apple", "pen" });


solution.WordBreak3("aaaaaaa", new List<string>() { "aaaa", "aaa" });



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

public partial class Solution
{
    public bool WordBreak2(string s, IList<string> wordDict)
    {
        bool res = false;
        void Dfs(int i)
        {
            if (i >= s.Length)
            {
                if (i == s.Length)
                {
                    res = true;
                }
                return;
            }

            for (int j = 0; j < wordDict.Count; j++)
            {
                var sub = s.Substring(i, wordDict[j].Length);
                if (wordDict[j] == sub)
                {
                    Dfs(i + wordDict[j].Length);
                }
            }
        }
        Dfs(0);
        return res;
    }
}
//Not work
public partial class Solution
{
    public bool WordBreak3(string s, IList<string> wordDict)
    {
        bool[] res = new bool[s.Length+1];
        res[^1] = true;
        int lastIndex = s.Length;
        for (int i = s.Length-1; i >= 0; i--)
        {
            var sub = s.Substring(i, lastIndex- i);

            if (wordDict.Contains(sub))
            {
                res[i] = res[i + sub.Length];
                lastIndex = i;
            }
        }

        return res[0];
    }
}
//NeedCode solution
public partial class Solution {
    public bool WordBreak4(string s, IList<string> wordDict) {
        bool[] dp = new bool[s.Length + 1];
        dp[^1] = true;

        for (int i = s.Length; i >= 0; i--) {
            foreach (string w in wordDict) {
                if (i + w.Length <= s.Length && s.Substring(i, w.Length) == w) {
                    dp[i] = dp[i + w.Length];
                }
                if (dp[i]) {
                    break;
                }
            }
        }
        return dp[0];
    }
}

