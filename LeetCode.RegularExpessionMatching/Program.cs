using System.Collections.Generic;

Solution solution = new();
//solution.IsMatch2("aa", "a*");

solution.IsMatch3("aab", "c*a*b");

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

public partial class Solution
{
    public bool IsMatch3(string s, string p)
    {
        Dictionary<(int, int), bool> dp = new();
        bool Backtrack(int sIndex, int pIndex)
        {
            if (dp.ContainsKey((sIndex,pIndex)))
            {
                return dp[(sIndex,pIndex)];
            }
            if (sIndex >= s.Length && pIndex >= p.Length)
            {
                return true;
            }
            if (pIndex >= p.Length)
            {
                return false;
            }

            var match = sIndex < s.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '.');
            if ((pIndex+1) < p.Length && p[pIndex+1] == '*')
            {
                dp[(sIndex,pIndex)] = Backtrack(sIndex, pIndex + 2) || (match && Backtrack(sIndex + 1, pIndex));
                return dp[(sIndex, pIndex)];
            }

            if (match)
            {
                dp[(sIndex,pIndex)] = Backtrack(sIndex + 1, pIndex + 1);
                return dp[(sIndex, pIndex)];
            }
            dp[(sIndex, pIndex)] = false;
            return false;
        }
        return Backtrack(0,0);
    }
}
