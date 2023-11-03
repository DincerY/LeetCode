using System;
using System.Collections;
using System.Security.Policy;

namespace LeetCode.RegularExpessionMatching
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.IsMatch("sssafh", "s*b");
            Console.WriteLine(a);
        }
    }
    

    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            bool DeepForSearch(int i, int j)
            {
                if (i >= s.Length && j>= p.Length)
                    return true;
    
                if (j>= p.Length)
                    return false;
    
                bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
                if ((j+1) < p.Length && p[j+1] == '*')
                {
                    return DeepForSearch(i, j + 2) ||              //dont use *
                           (match && DeepForSearch(i + 1, j));     //use *
                    
                }
    
                if (match)
                {
                    return DeepForSearch(i + 1, j + 1);
                }
    
                return false;
            }
    
            return DeepForSearch(0, 0);
    
        }
    }
}