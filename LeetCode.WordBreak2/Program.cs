Solution solution = new();
solution.WordBreak2("catsanddog", new List<string>()
{
    "cat", "cats", "and", "sand", "dog"
});
// solution.WordBreak("pineapplepenapple", new List<string>()
// {
//     "apple", "pen", "applepen", "pine", "pineapple"
// });


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        List<List<string>> res = new();
        List<string> list = new();

        void Dfs(string temp)
        {
            for (int i = 1; i < temp.Length + 1; i++)
            {
                if (wordDict.Contains(temp.Substring(0, i)))
                {
                    list.Add(temp.Substring(0, i));
                    Dfs(temp.Substring(i));
                    if (i == temp.Length)
                    {
                        res.Add(list.ToList());
                    }

                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        Dfs(s);
        foreach (var re in res)
        {
            var val = string.Join(" ", re);
            list.Add(val);
        }

        return list;
    }
}

//NeedCode memoization solution
public partial class Solution
{
    public IList<string> WordBreak2(string s, IList<string> wordDict)
    {
        HashSet<string> wordSet = new HashSet<string>(wordDict);
        Dictionary<int, IList<string>> cache = new Dictionary<int, IList<string>>();

        IList<string> Backtrack(int i)
        {
            if (i == s.Length)
            {
                return new List<string> { "" };
            }
            if (cache.ContainsKey(i))
            {
                return cache[i];
            }
            IList<string> res = new List<string>();
            for (int j = i; j < s.Length; j++)
            {
                string w = s.Substring(i, j - i + 1);
                if (!wordSet.Contains(w))
                {
                    continue;
                }
                IList<string> strings = Backtrack(j + 1);
                if (strings.Count == 0)
                {
                    continue;
                }
                foreach (string substr in strings)
                {
                    string sentence = w;
                    if (!string.IsNullOrEmpty(substr))
                    {
                        sentence += " " + substr;
                    }
                    res.Add(sentence);
                }
            }
            cache[i] = res;
            return res;
        }
        return Backtrack(0);
    }
}