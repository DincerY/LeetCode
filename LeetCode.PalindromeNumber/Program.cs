using System;

namespace LeetCode.PalindromeNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var a  =solution.IsPalindrome(1001);
            Console.WriteLine(a);
        }
    }
    
    public class Solution {
        public bool IsPalindrome(int x)
        {
            int baseInteger = x;
            int result = 0;
            int a = 0;
            int b = 0;
            if (x < 10 && x>-1)
            {
                return true;
            }
            while (x >= 10)
            {
                a = x % 10;
                b = x / 10;
                result = result * 10 + a;
                x = b;
            }

            
            result = result * 10 + b;


            if (result == baseInteger)
            {
                return true;
            }
            
            return false;
        }
        
    }
}