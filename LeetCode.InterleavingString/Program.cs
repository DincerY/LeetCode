Solution solution = new();
//solution.IsInterleave2("aabcc", "dbbca", "aadbbcbcac");
solution.IsInterleave2("aabcc", "dbbca", "aadbbbaccc");


Console.WriteLine("Hello, World!");

public partial class Solution {
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int s1Index = 0;
        int s2Index = 0;

        foreach (var value in s3)
        {
            if(s2Index < s2.Length && s2[s2Index] == value)
            {
                s2Index++;
            }
            else if (s1Index < s1.Length && s1[s1Index] == value)
            {
                s1Index++;
            }
            else
            {
                return false;
            }
        }

        if (s1Index >= s1.Length && s2Index >= s2.Length)
        {
            return true;
        }
        return false;
    }
}


//Solutions are not mine solution
public partial class Solution {
    private Dictionary<(int, int), bool> dp = new Dictionary<(int, int), bool>();

    public bool IsInterleave2(string s1, string s2, string s3) {
        return Dfs(s1, s2, s3, 0, 0);
    }

    private bool Dfs(string s1, string s2, string s3, int i, int j) {
        if (i == s1.Length && j == s2.Length) {
            return true;
        }

        if (dp.ContainsKey((i, j))) {
            return dp[(i, j)];
        }

        if (i < s1.Length && s1[i] == s3[i + j] && Dfs(s1, s2, s3, i + 1, j)) {
            return dp[(i, j)] = true;
        }

        if (j < s2.Length && s2[j] == s3[i + j] && Dfs(s1, s2, s3, i, j + 1)) {
            return dp[(i, j)] = true;
        }

        return dp[(i, j)] = false;
    }
}


public partial class Solution {
    public bool IsInterleave3(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) {
            return false;
        }
        
        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[s1.Length, s2.Length] = true;
        
        for (int i = s1.Length; i >= 0; i--) {
            for (int j = s2.Length; j >= 0; j--) {
                if (i < s1.Length && s1[i] == s3[i + j] && dp[i + 1, j]) {
                    dp[i, j] = true;
                }
                if (j < s2.Length && s2[j] == s3[i + j] && dp[i, j + 1]) {
                    dp[i, j] = true;
                }
            }
        }
        
        return dp[0, 0];
    }
}



