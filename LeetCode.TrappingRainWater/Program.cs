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
            solution.Trap(new []{1,2,3,4,5,6});


        }
    }
    
    
    public class Solution {
        public int Trap(int[] height)
        {
            Array.Sort(height);

            Stack<int> stack = new Stack<int>();
            
            
            // for (int i = 0; i < height.Length; i++)
            // {
            //     stack.Push(height[i]);
            // }
            
            
            





            return 0;
        }
    }
}