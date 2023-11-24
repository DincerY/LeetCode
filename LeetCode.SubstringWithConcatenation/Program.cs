using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SubstringWithConcatenation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.FindSubstring("", new[] { "ab", "cd","ef"});
        }
    }

    public class Solution
    {
        public List<string> Combination { get; set; }

        public Solution()
        {
            Combination = new List<string>();
        }
        public IList<int> FindSubstring(string s, string[] words)
        {
            int length = words.Length * (words.Length - 1);
            
            s.Contains("");
            CombinateWords(words);

            Console.WriteLine(Combination);
            
            
            
            return null;
        }

        private void CombinateWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var deneme = words[i];
                for (int j = 0; j < words.Length; j++)
                {
                    if (j==i)
                    {
                        continue;
                    }

                    deneme += words[j];
                }
                Combination.Add(deneme);
            }
        }
    }
}

