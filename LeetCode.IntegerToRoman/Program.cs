using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.IntegerToRoman
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a =solution.IntToRoman(122);
            Console.WriteLine(a);
        }

       
    }
    public class Solution
    {
        private Dictionary<int,string> _romen;
        public Solution()
        {
            _romen =  new Dictionary<int, string>();
            _romen.Add(1000, "M");
            _romen.Add(900, "CM");  
            _romen.Add(500, "D");      
            _romen.Add(400, "CD");
            _romen.Add(100, "C");
            _romen.Add(90, "XC");
            _romen.Add(50, "L");
            _romen.Add(40, "XL");
            _romen.Add(10, "X");
            _romen.Add(9, "IX");
            _romen.Add(5, "V");
            _romen.Add(4, "IV");
            _romen.Add(1, "I");

        }
        public string IntToRoman(int num)
        {
            string result = "";
            foreach (var romen in _romen)
            {
                if (num / romen.Key != 0)
                {
                    int count = num / romen.Key;
                    num = num % romen.Key;
                    if (count>1)
                    {
                        for (int i = 1; i < count; i++)
                        {
                            result += romen.Value;
                        }
                    }
                    result += romen.Value;
                }
                
            }


            return result;
        }

        
    }
}