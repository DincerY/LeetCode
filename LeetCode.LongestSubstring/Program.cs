using System;
using System.Collections.Generic;
using System.Linq;

Solution solution = new Solution();

solution.LengthOfLongestSubstring2("dvdf");
solution.LengthOfLongestSubstring2("abcabcbb");
solution.LengthOfLongestSubstring2("bbbbb");
solution.LengthOfLongestSubstring2("aquertapl");

Console.WriteLine("Hello World!");

public partial class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var aPointer = 0;
        var bPointer = 0;
        var max = 0;
    
        var hashSet = new HashSet<char>();
    
        while (bPointer < s.Length)
        {
            if (!hashSet.Contains(s[bPointer]))
            {
                hashSet.Add(s[bPointer]);
                bPointer++;
                max = Math.Max(hashSet.Count, max);
            }
            else
            {
                hashSet.Remove(s[aPointer]);
                aPointer++;
            }
        }
        return max;
    }
    
    
}
public partial class Solution
{
    public int LengthOfLongestSubstring2(string s)
    {
        HashSet<char> hashSet = new();
        int res = 0;
        int l = 0;
        int r = 0;
        while (r < s.Length && l <= r)
        {
            if (!hashSet.Contains(s[r]))
            {
                hashSet.Add(s[r]);
                r++;
            }
            else
            {
                hashSet.Remove(s[l]);
                l++;
            }
            res = Math.Max(res, r - l);
        }
        return res;
    }
}

public partial class Solution
{
    public int LengthOfLongestSubstring3(string s)
    {
        HashSet<char> hashSet = new();
        int res = 0;
        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            while (hashSet.Contains(s[r]))
            {
                hashSet.Remove(s[l]);
                l++;
            }

            hashSet.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
    

