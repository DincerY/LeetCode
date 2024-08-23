Solution solution = new();
solution.Partition("aab");


Console.WriteLine("Hello, World!");

//it is not mine solution
public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        var res = new List<IList<string>>();
        var part = new List<string>();
        void Dfs(int i)
        {
            if (i >= s.Length)
            {
                res.Add(new List<string>(part));
                return;
            }
            for (int j = i; j < s.Length; j++)
            {
                if (IsPali(s, i, j))
                {
                    part.Add(s.Substring(i, j - i + 1));
                    Dfs(j + 1);
                    part.RemoveAt(part.Count - 1);
                }
            }
        }
        Dfs(0);
        return res;
    }
    private bool IsPali(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}