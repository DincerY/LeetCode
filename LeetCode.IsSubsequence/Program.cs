Solution solution = new();
solution.IsSubsequence2("abc", "ahbgdc");

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int indexs = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (indexs == s.Length)
            {
                return true;
            }
            if (s[indexs] == t[i])
            {
                indexs++;
            }
        }
        
        return indexs >= s.Length;
    }
}


public partial class Solution
{
    public bool IsSubsequence2(string s, string t)
    {
        int i = 0;
        int j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                i++;
            }

            j++;
        }
        return i == s.Length;
    }
}