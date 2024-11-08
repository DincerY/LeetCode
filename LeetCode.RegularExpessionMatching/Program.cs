using System.Collections.Generic;

Solution solution = new();
//solution.IsMatch2("aa", "a*");

solution.IsMatch2("aab", "c*a*b");

//NeedCode solutions
public partial class Solution
{
    public bool IsMatch(string s, string p)
    {
        bool Dfs(int i, int j)
        {
            if (i >= s.Length && j >= p.Length)
            {
                return true;
            }

            if (j >= p.Length)
            {
                return false;
            }

            bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                return Dfs(i, j + 2) || (match && Dfs(i + 1, j));
            }

            if (match)
            {
                return Dfs(i + 1, j + 1);
            }

            return false;
        }

        return Dfs(0, 0);
    }
}


public partial class Solution
{
    private Dictionary<(int, int), bool> cache = new Dictionary<(int, int), bool>();

    public bool IsMatch2(string s, string p)
    {
        bool Dfs(int i, int j)
        {
            if (cache.ContainsKey((i, j)))
            {
                return cache[(i, j)];
            }

            if (i >= s.Length && j >= p.Length)
            {
                return true;
            }

            if (j >= p.Length)
            {
                return false;
            }

            bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                cache[(i, j)] = Dfs(i, j + 2) || (match && Dfs(i + 1, j));
                return cache[(i, j)];
            }

            if (match)
            {
                cache[(i, j)] = Dfs(i + 1, j + 1);
                return cache[(i, j)];
            }

            cache[(i, j)] = false;
            return false;
        }

        return Dfs(0, 0);
    }
}