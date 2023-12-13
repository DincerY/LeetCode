using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.TrappingRainWater
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.TrapWithOneSpace(new []{4,2,0,3,2,5});


        }
    }
    
    
    public class Solution {
        public int TrapWithOneSpace(int[] height)
        {
            int[] minLeftRight = new int[height.Length];
            int maxValue = height[0];
            int maxRightValue = height[height.Length - 1];
            int sum = 0;
            
            //Find Max Value For Every Left Of Number And Add minLeftRight Array
            for (int i = 1; i < height.Length; i++)
            {
                if (maxValue < height[i-1])
                {
                    maxValue = height[i - 1];
                }

                minLeftRight[i] = maxValue;
            }
            //Find Max Value For Every Right Of Number And Compare minLeftRight Array And Again Add Min Value minLeftRight Array
            for (int i = height.Length-1; i >= 0; i--)
            {
                minLeftRight[i] = Math.Min(minLeftRight[i], maxRightValue);
                if (height[i] > maxRightValue)
                {
                    maxRightValue = height[i];
                }
            }
            for (int i = 0; i < height.Length; i++)
            {
                int a = minLeftRight[i] - height[i];
                if (a < 0)
                {
                    sum += 0;
                }
                else
                {
                    sum += a;
                }
            }
            return sum;
        }
        
        public int Trap(int[] height)
        {

            





            return 0;
        }

    }
}