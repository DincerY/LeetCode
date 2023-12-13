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
            //solution.TrapWithOneSpace(new []{4,2,0,3,2,5});
            solution.Trap(new[] { 0,1,0,2,1,0,1,3,2,1,2,1 });


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
            int leftPointer = 0;
            int rightPointer = height.Length - 1;
            int leftValue = height[leftPointer];
            int rightValue = height[rightPointer];
            int sum = 0;
            while (leftPointer != rightPointer)
            {
                if (leftValue <= rightValue)
                {
                    if (leftValue < height[leftPointer+1])
                    {
                        leftPointer = leftPointer + 1;
                        leftValue = height[leftPointer];
                    }
                    else
                    {
                        leftPointer++;
                        int value = leftValue - height[leftPointer];
                        if (value>0)
                        {
                            sum += value;
                        }
                    }
                }
                else
                {
                    if (rightValue < height[rightPointer-1])
                    {
                        rightPointer = rightPointer - 1;
                        rightValue = height[rightPointer];
                    }
                    else
                    {
                        rightPointer--;
                        int value = rightValue - height[rightPointer];
                        if (value>0)
                        {
                            sum += value;
                        }
                    }
                }
            }
            
            return sum;
        }

    }
}