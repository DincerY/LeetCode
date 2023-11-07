using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LeetCode.LetterCombinations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var r = solution.LetterCombinations("");
            foreach (var v in r)
            {
                Console.Write($"{v} ");
            }
        }
    }
    
    public class Solution {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> res = new();
            Dictionary<char, string> digitToChar = new()
            {
                {'2', "abc" }, {'3', "def"},
                {'4', "ghi"}, {'5', "jkl"}, {'6', "mno"},
                {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
            };
            if(digits == "")
            {
                return new List<string>();
            }

            if (digits != null)
            {
                BackTrack(0,"");
            }
            
            
            return res;
            
            void BackTrack(int i, string curStr)
            {
                if (curStr.Length == digits.Length)
                {
                    res.Add(curStr);
                    return;
                }

                foreach (var c in digitToChar[digits[i]])
                {
                    BackTrack(i+1,curStr + c);
                }
            }
        }

        

        
    }
}