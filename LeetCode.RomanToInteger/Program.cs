using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.RomanToInteger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a =solution.RomanToInt("MCMXCIV");
            Console.WriteLine(a);
        }
    }

    public class Solution
    {
        private Dictionary<char, int> _romen;

        public Solution()
        {
            _romen = new Dictionary<char, int>();
            _romen.Add('M',1000);
            _romen.Add('D',500);
            _romen.Add('C',100);
            _romen.Add('L',50);
            _romen.Add('X',10);
            _romen.Add('V',5);
            _romen.Add('I',1);
        }

        public int RomanToInt(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var value = _romen[s[i]];
                if (i < s.Length-1)
                {
                    if (_romen[s[i]] < _romen[s[i+1]])
                    {
                        value = _romen[s[i + 1]] - _romen[s[i]];
                        i++;
                    }
                }
                
                result += value;
            }
            return result;
        }
        
        
    }
}