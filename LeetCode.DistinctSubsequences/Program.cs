Solution solution = new();
solution.NumDistinct5("rabbbit", "rabbit");
solution.NumDistinct5("babgbag", "bag");


//var a = solution.NumDistinct3("adbdadeecadeadeccaeaabdabdbcdabddddabcaaadbabaaedeeddeaeebcdeabcaaaeeaeeabcddcebddebeebedaecccbdcbcedbdaeaedcdebeecdaaedaacadbdccabddaddacdddc", "bcddceeeebecbc");
//Console.WriteLine(a);


Console.WriteLine("Hello, World!");

//It is true but not efficient so it is brute force solution
public partial class Solution
{
    public int NumDistinct(string s, string t)
    {
        int val = 0;
        bool isFor = false;
        void Recursion(int idx, int tidx)
        {
            for (int i = idx; i < s.Length; i++)
            {
                if (tidx == t.Length)
                {
                    val++;
                    isFor = true;
                    break;
                }
                if (s[i] == t[tidx])
                {
                    Recursion(i + 1, tidx + 1);
                }
            }
            if (!isFor && tidx == t.Length)
            {
                val++;
            }
            isFor = false;
        }
        Recursion(0, 0);
        return val;
    }
}


//it is not mine solution
public partial class Solution
{
    public int NumDistinct2(string s, string t)
    {
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();

        int Dfs(int i, int j)
        {
            if (j == t.Length)
            {
                return 1;
            }

            if (i == s.Length)
            {
                return 0;
            }

            if (cache.ContainsKey((i, j)))
            {
                return cache[(i, j)];
            }

            if (s[i] == t[j])
            {
                cache[(i, j)] = Dfs(i + 1, j + 1) + Dfs(i + 1, j);
            }
            else
            {
                cache[(i, j)] = Dfs(i + 1, j);
            }

            return cache[(i, j)];
        }

        return Dfs(0, 0);
    }
}



public partial class Solution
{
    public int NumDistinct3(string s, string t)
    {
        int res = 0;
        void Backtrack(int sIndex, int tIndex)
        {
            if (tIndex == t.Length)
            {
                res++;
            }
            if (sIndex >= s.Length || tIndex >= t.Length)
            {
                return;
            }
            if (s[sIndex] == t[tIndex])
            {
                Backtrack(sIndex+1,tIndex+1);
            }
            Backtrack(sIndex+1,tIndex);
        }
        Backtrack(0,0);
        return res;
    }
}
//dp solution memoization
public partial class Solution
{
    public int NumDistinct4(string s, string t)
    {
        Dictionary<(int,int), int> dp = new();
        int Backtrack(int sIndex, int tIndex)
        {
            if (tIndex == t.Length)
                return 1;
            
            if (sIndex == s.Length)
                return 0;
            
            if (dp.ContainsKey((sIndex,tIndex)))
            {
                return dp[(sIndex, tIndex)];
            }
            if (s[sIndex] == t[tIndex])
            {
                dp[(sIndex,tIndex)] = Backtrack(sIndex+1,tIndex+1) + Backtrack(sIndex+1,tIndex);
            }
            else
            {
                dp[(sIndex,tIndex)] = Backtrack(sIndex+1,tIndex);
            }

            return dp[(sIndex, tIndex)];
        }
        Backtrack(0,0);
        return dp[(0,0)];
    }
}

//dp solution tabulation
public partial class Solution {
    public int NumDistinct5(string s, string t) {
        int m = s.Length;
        int n = t.Length;
        int[,] dp = new int[m + 1, n + 1];
        
        for (int i = 0; i <= m; i++) {
            dp[i, n] = 1;
        }
        for (int sIndex = m - 1; sIndex >= 0; sIndex--) {
            for (int tIndex = n - 1; tIndex >= 0; tIndex--) {
                dp[sIndex, tIndex] = dp[sIndex + 1, tIndex];

                if (s[sIndex] == t[tIndex]) {
                    dp[sIndex, tIndex] += dp[sIndex + 1, tIndex + 1];
                }
            }
        }
        return dp[0, 0];
    }
}