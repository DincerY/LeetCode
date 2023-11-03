using System;
using System.Data.SqlTypes;

namespace LeetCode.StringToInteger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var a = solution.MyAtoi("2147483647");
            Console.WriteLine(a);
        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();
            int i = 0;
            int plusOrMinus = 1;
            int result = 0;

            if (s.Length == 0)
            {
                return 0;
            }
            if (s[i] == '-' || s[i] == '+')
            {
                plusOrMinus = s[i++] == '-' ? -1 : 1;
                //i++;
            }

            while (i <s.Length && char.IsDigit(s[i]))
            {
                int a = s[i] -'0';

                if (result > int.MaxValue / 10 || result == int.MaxValue / 10 && a > 7)
                {
                    return plusOrMinus == -1 ? int.MinValue : int.MaxValue;
                }
                
                result = result * 10 + a;
                i++;
            }

            result *= plusOrMinus;
            
            
            return result;
        }
    }
}