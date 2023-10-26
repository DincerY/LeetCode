using System;

namespace LeetCode.LongestPalindromicSubstring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.LongestPalindrome("kabcbal");
        }
    }

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int a = FindIndex(s);
            Palindrome(s,a-1,a+1);
            return "";
        }

        private int FindIndex(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i+1]==s[i-1])
                {
                    return i;
                }
            }

            throw new ArgumentException("Not find palindromic value");
        }

        private void Palindrome(string s, int first, int last)
        {
            
        }

        
    }
}