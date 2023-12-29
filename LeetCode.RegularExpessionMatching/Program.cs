using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace LeetCode.RegularExpessionMatching
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.IsMatchMemoization("aab","c*a*b");
            Console.WriteLine(a);
        }
    }
    

    public class Solution
    {
        // private Dictionary<(int, int), bool?> cache;
        // public bool IsMatchWithCache(string s, string p)
        // {
        //     cache = new Dictionary<(int, int), bool?>();
        //     
        //     
        //     bool DFS(int i, int j)
        //     {
        //         if (cache.ContainsKey((i, j)))
        //         {
        //             return cache[(i, j)].Value;
        //         }
        //
        //         bool result;
        //
        //         if (i == s.Length && j == p.Length)
        //         {
        //             result = true;
        //         }
        //         else if (j == p.Length)
        //         {
        //             result = false;
        //         }
        //         else
        //         {
        //             bool match = (i < s.Length) && (s[i] == p[j] || p[j] == '.');
        //
        //             if (j + 1 < p.Length && p[j + 1] == '*')
        //             {
        //                 result = DFS(i, j + 2) || (match && DFS(i + 1, j));
        //             }
        //             else
        //             {
        //                 result = match && DFS(i + 1, j + 1);
        //             }
        //         }
        //
        //         cache[(i, j)] = result;
        //         return result;
        //     }
        //     
        //
        //     return DFS(0, 0);
        // }
        
        // public bool IsMatch(string s, string p)
        // {
        //     bool DeepForSearch(int i, int j)
        //     {
        //         if (i >= s.Length && j>= p.Length)
        //             return true;
        //
        //         if (j>= p.Length)
        //             return false;
        //
        //         bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
        //         if ((j+1) < p.Length && p[j+1] == '*')
        //         {
        //             return DeepForSearch(i, j + 2) ||              //dont use *
        //                    (match && DeepForSearch(i + 1, j));     //use *
        //             
        //         }
        //
        //         if (match)
        //         {
        //             return DeepForSearch(i + 1, j + 1);
        //         }
        //
        //         return false;
        //     }
        //
        //     return DeepForSearch(0, 0);
        //
        // }

        public bool IsMatchMemoization(string s, string p)
        {
            
            bool Recursive(int i,int j)
            {
                if (j >= p.Length && i >= s.Length)
                {
                    return true;
                }

                if (j >= p.Length)
                {
                    return false;
                }

                bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');

                if ((j+1) < p.Length && p[j+1] == '*')
                {
                    return Recursive(i, j + 2) || (match && Recursive(i + 1, j));
                }

                if (match)
                {
                    return Recursive(i +1, j+1);
                }
                return false;
            }
            


            return Recursive(0,0);
            
        }
        


    }
}