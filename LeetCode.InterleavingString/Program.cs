Solution solution = new();
solution.IsInterleaveDp("aabcc", "dbbca", "aadbbcbcac");
//solution.IsInterleave4("aabcc", "dbbca", "aadbbbaccc");


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int s1Index = 0;
        int s2Index = 0;

        foreach (var value in s3)
        {
            if (s2Index < s2.Length && s2[s2Index] == value)
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


//Solution is not mine solution
public partial class Solution
{
    public bool IsInterleave3(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
        {
            return false;
        }

        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[s1.Length, s2.Length] = true;

        for (int i = s1.Length; i >= 0; i--)
        {
            for (int j = s2.Length; j >= 0; j--)
            {
                if (i < s1.Length && s1[i] == s3[i + j] && dp[i + 1, j])
                {
                    dp[i, j] = true;
                }

                if (j < s2.Length && s2[j] == s3[i + j] && dp[i, j + 1])
                {
                    dp[i, j] = true;
                }
            }
        }

        return dp[0, 0];
    }
}

//it is mine solution
public partial class Solution
{
    public bool IsInterleave4(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length > s3.Length)
        {
            return false;
        }
        bool Recursion(int i, int j)
        {
            if (i < s1.Length && s1[i] == s3[i + j] && Recursion(i + 1, j))
            {
                return true;
            }

            if (j < s2.Length && s2[j] == s3[i + j] && Recursion(i, j + 1))
            {
                return true;
            }

            if (i + j == s3.Length)
            {
                return true;
            }
            else
                return false;
        }

        return Recursion(0, 0);
    }
}


//Time limit exceeded
public partial class Solution
{
    public bool IsInterleave5(string s1, string s2, string s3)
    {
        bool isInterleave = false;
        void Backtrack(int s1Index, int s2Index)
        {
            if (s1Index == s1.Length && s2Index == s2.Length)
            {
                isInterleave = true;
            }
            int s3Index = s1Index + s2Index;
            if (s1Index < s1.Length && s2Index < s2.Length && s1[s1Index] == s2[s2Index] && s1[s1Index] == s3[s3Index])
            {
                Backtrack(s1Index + 1, s2Index);
                Backtrack(s1Index, s2Index + 1);
            }

            if (s1Index < s1.Length && s1[s1Index] == s3[s3Index])
            {
                Backtrack(s1Index + 1, s2Index);
            }
            if (s2Index < s2.Length && s2[s2Index] == s3[s3Index])
            {
                Backtrack(s1Index, s2Index + 1);
            }
        }

        if (s3.Length != s1.Length + s2.Length)
        {
            return false;
        }
        Backtrack(0, 0);
        return isInterleave;
    }
}

public partial class Solution
{
    public bool IsInterleave5Cache(string s1, string s2, string s3)
    {
        Dictionary<(int, int), bool> dp = new Dictionary<(int, int), bool>();

        bool Backtrack(int i, int j)
        {
            if (i == s1.Length && j == s2.Length)
            {
                return true;
            }

            if (dp.ContainsKey((i, j)))
            {
                return dp[(i, j)];
            }

            if (i < s1.Length && s1[i] == s3[i + j] && Backtrack(i + 1, j))
            {
                return true;
            }

            if (j < s2.Length && s2[j] == s3[i + j] && Backtrack(i, j + 1))
            {
                return true;
            }

            dp[(i, j)] = false;
            return false;
        }

        return Backtrack(0, 0);
    }
}

public partial class Solution {
    public bool IsInterleaveDp(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) 
        {
            return false;
        }

        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[s1.Length, s2.Length] = true;

        for (int i = s1.Length; i >= 0; i--) 
        {
            for (int j = s2.Length; j >= 0; j--) 
            {
                if (i < s1.Length && s1[i] == s3[i + j] && dp[i + 1, j]) 
                {
                    dp[i, j] = true;
                }
                if (j < s2.Length && s2[j] == s3[i + j] && dp[i, j + 1]) 
                {
                    dp[i, j] = true;
                }
            }
        }

        return dp[0, 0];
    }
}
