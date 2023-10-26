using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LongestSubstring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int a = solution.LengthOfLongestSubstring("asdasd");
            Console.WriteLine(a);

        }
    }

    public class Solution
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
        
        
        // public int LengthOfLongestSubstring(string s)
        // {
        //     char[] chars = new char[s.Length];
        //     int i = 0;
        //     while (i < s.Length)
        //     {
        //         if (i != 0)
        //         {
        //             int dubliceIndex = Dublicate(chars,s[i]);
        //             if (dubliceIndex != -1)
        //             {
        //                 chars[dubliceIndex] = ' ';
        //             }
        //         }
        //         chars[i] = s[i];
        //         i++;
        //     }
        //
        //     for (int j = 0; j < chars.Length; j++)
        //     {
        //         if (chars[j] != ' ')
        //         {
        //             Console.Write($"{chars[j]}-");
        //         }
        //     }
        //     return 0;
        // }
        // private int Dublicate(char[] chars, char c)
        // {
        //     if (chars.Contains(c))
        //     {
        //         for (int i = 0; i < chars.Length; i++)
        //         {
        //             if (chars[i] == c)
        //             {
        //                 return i;
        //             }
        //         }
        //     }
        //
        //     return -1;
        // }
    }
    

}