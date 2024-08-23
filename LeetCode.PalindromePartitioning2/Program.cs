Solution solution = new();
//solution.MinCut("ababababababababababababcbabababababababababababa");
solution.MinCut("aab");



Console.WriteLine("Hello, World!");

//time limit exceeded
public partial class Solution
{
    public int MinCut(string s)
    {
        List<string> res = new List<string>();
        List<List<string>> list = new List<List<string>>();

        void Dfs(int i)
        {
            if (i >= s.Length)
            {
                list.Add(res.ToList());
                return;
            }

            for (int j = i; j < s.Length; j++)
            {
                if (IsPalindrome(s, i, j))
                {
                    res.Add(s.Substring(i, j - i + 1));
                    Dfs(j + 1);
                    res.RemoveAt(res.Count - 1);
                }
            }
        }

        Dfs(0);
        int min = int.MaxValue;
        foreach (var l in list)
        {
            min = Math.Min(min, l.Count);
        }

        return min - 1;
    }

    private bool IsPalindrome(string s, int l, int r)
    {
        while (r > l)
        {
            if (s[l] == s[r])
            {
                r--;
                l++;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
