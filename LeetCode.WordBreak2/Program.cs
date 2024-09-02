Solution solution = new();
solution.WordBreak("catsanddog", new List<string>()
{
    "cat", "cats", "and", "sand", "dog"
});
// solution.WordBreak("pineapplepenapple", new List<string>()
// {
//     "apple", "pen", "applepen", "pine", "pineapple"
// });


Console.WriteLine("Hello, World!");


public class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        List<List<string>> res = new();
        List<string> list = new();

        void Dfs(string temp)
        {
            for (int i = 0; i < temp.Length + 1; i++)
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
        list.Clear();
        foreach (var re in res)
        {
            string val = "";
            foreach (var r in re)
            {
                val += r;
                val += " ";
            }

            val = val.TrimEnd(' ');
            list.Add(val);
        }

        return list;
    }
}