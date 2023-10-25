using System;

namespace LeetCode.LongestSubstring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var value = solution.LengthOfLongestSubstring("aqwertyuio");
            Console.WriteLine(value);
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            char[] chars = new char[s.Length];
            char a = s[0];
            int i = 1;
            while (a != s[i] && i< s.Length -1)
            {
                    i++;
            }
            


            return i;
        }
    }
}