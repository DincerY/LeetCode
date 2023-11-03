using System;
using System.Runtime.InteropServices;

namespace LeetCode.ContainerWithMostWater
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Console.WriteLine(a);
        }
    }


    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int i = 0, j = height.Length-1;
            int result = 0;
            while (i < j)
            {
                int minHeight = Min(height[i], height[j]);
                int maxArea = minHeight * (j - i);
                result = Max(result, maxArea);
                if (height[i] == minHeight)
                {
                    i++;
                }
                else
                {
                    j--;
                }

            }

            return result;

        }

        private int Min(int a, int b)
        {
            if (a<b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public int Max(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        #region n^2 solution

        // public int MaxArea(int[] height)
        // {
        //     int result = 0;
        //     for (int i = 0; i < height.Length; i++)
        //     {
        //         for (int j = i+1; j < height.Length; j++)
        //         {
        //             int minHeight = Math.Min(height[i], height[j]);
        //             int a = minHeight * (j - i);
        //             result = Math.Max(a, result);
        //         }
        //     }
        //
        //     return result;
        //
        //
        // }

        #endregion
    }
}