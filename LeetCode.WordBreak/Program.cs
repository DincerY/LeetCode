Solution solution = new();
//solution.WordBreak("leetcode", new List<string>() { "leet", "code" });
solution.WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" });
solution.WordBreak("applepenapple", new List<string>() { "apple", "pen" });


Console.WriteLine("Hello, World!");


public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        foreach (var word in wordDict)
        {
            var idx = s.IndexOf(word);
            if (idx >= 0)
            {
                if (idx != 0)
                {
                    s = s.Substring(0, s.Length - word.Length);
                }
                else
                {
                    s = s.Substring(idx + word.Length);
                }
            }
        }

        if (s == "")
        {
            return true;
        }
        else
        {
            foreach (var word in wordDict)
            {
                if (s.Contains(word))
                {
                    return true;
                }
            }
        }

        return false;
    }
}