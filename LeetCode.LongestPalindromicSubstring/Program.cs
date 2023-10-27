using System;


namespace LeetCode.LongestPalindromicSubstring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var str = solution.LongestPalindrome("babad");
            Console.Write(str);
        }
    }

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int maxLength = 0;
            int startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int start = i;
                int end = i;
                while (end <s.Length-1 && s[start] == s[end+1])
                {
                    end++;
                }

                while (end < s.Length-1 && start > 0 && s[start-1] == s[end+1])
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
    
}