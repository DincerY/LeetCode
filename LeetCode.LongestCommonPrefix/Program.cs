using System;

namespace LeetCode.LongestCommonPrefix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.LongestCommonPrefix(new[] { "flower","flow","flight" });
            Console.WriteLine(a);

        }
    }
    
    
    public class Solution {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            int stringCount = CountOfString(strs);
            int count = 0;
            for (int i = 0; i < stringCount; i++)
            {
                char a = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (a == strs[j][i])
                    {
                        count++;
                    }
                }

                if (result.Length != i)
                {
                    break;
                }
                if (count == strs.Length -1)
                {
                    result += a;
                }
                count = 0;
            }
            
            return result;
        }

        private int CountOfString(string[] strs)
        {
            string temp = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                if (temp.Length > strs[i].Length)
                {
                    temp = strs[i];
                }
            }

            return temp.Length;
        }
    }
}