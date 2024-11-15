using System;

Solution solution = new Solution();
var str = solution.LongestPalindrome2("babad");
str = solution.LongestPalindrome2("cbbd");

Console.Write(str);


public partial class Solution
{
    public string LongestPalindrome(string s)
    {
        int startIndex = 0;
        int maxLength = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int start = i;
            int end = i;
            while (end < s.Length - 1 && s[start] == s[end + 1])
            {
                end++;
            }

            while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1])
            {
                end++;
                start--;
            }

            if (maxLength < end - start + 1)
            {
                maxLength = end - start + 1;
                startIndex = start;
            }
        }

        return s.Substring(startIndex, maxLength);
    }
}

//very efficient
public partial class Solution
{
    public string LongestPalindrome2(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            int l = i;
            int r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l >= res.Length)
                {
                    res = s.Substring(l,r - l +1);
                }
                l--;
                r++;
            }

            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                if (r - l >= res.Length)
                {
                    res = s.Substring(l,r - l + 1);
                }
                l--;
                r++;
            }
        }
        return res;
    }
}