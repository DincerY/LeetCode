using System;

Solution solution = new Solution();
/*var str = solution.LongestPalindrome3("babad");
var strr = solution.LongestPalindrome3("cbbd");*/
solution.LongestPalindrome3("aaaa");



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



public partial class Solution
{
    public string LongestPalindrome3(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            int left = i;
            int right = i;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                var temp = s.Substring(left, right - left + 1);
                if (temp.Length > res.Length)
                {
                    res = temp;
                }
                left--;
                right++;
            }
            left = i;
            right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                var temp = s.Substring(left, right - left + 1);
                if (temp.Length > res.Length)
                {
                    res = temp;
                }
                left--;
                right++;
            }
        }
        
        /*for (int i = 0; i < s.Length; i++)
        {
            int left= i;
            int right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                var temp = s.Substring(left, right - left + 1);
                if (temp.Length > res.Length)
                {
                    res = temp;
                }
                left--;
                right++;
            }
        }*/

        return res;
    }
}
