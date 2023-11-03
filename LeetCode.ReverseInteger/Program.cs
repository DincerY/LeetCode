using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace LeetCode.ReverseInteger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var a = solution.Reverse(153423649);
            Console.WriteLine(a);
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            if (x < 10 && x > -10)
            {
                return x;
            }
            return Divide(x, 0);
        }
        

        public int Divide(int a, int result)
        {

            var reminder = a % 10;
            var divide = a / 10;
            var temp = result * 10 + reminder;
            if (divide >= 10 || divide <= -10)
            {
                temp = Divide(divide, temp);
            }
            else
            {
                if (temp <= 214748364.7 && temp >= -214748364.7)
                {
                    temp *= 10;
                    temp += divide;
                }
                else
                    return 0;
            }
            return temp;
        }
    }
}