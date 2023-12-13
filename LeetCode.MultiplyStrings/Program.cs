using System;
using System.Numerics;

namespace LeetCode.MultiplyStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.Multiply("123", "456");
            Console.WriteLine(a);
        }
    }


    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            BigInteger a = new BigInteger();
            long intNum1 = 0;
            long intNum2 = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                intNum1 += num1[i] - 48;
                if (i != num1.Length-1)
                {
                    intNum1 *= 10;
                }
            }
            
            for (int i = 0; i < num2.Length; i++)
            {
                intNum2 += num2[i] - 48;
                if (i != num2.Length-1)
                {
                    intNum2 *= 10;
                }
                
            }
            
            return (intNum1 * intNum2).ToString();
        }
    }
}