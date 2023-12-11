using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.FirstMissingPositive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.FirstMissingPositive(new[] { 1 });
            solution.FirstMissingPositiveAnotherSolution(new[] { 1,2,0});
        }
    }
    
    
    public class Solution {
        public int FirstMissingPositive(int[] nums)
        {
            HashSet<int> hashSet = new();
            int a = 1;
            
            
            for (int i = 0; i < nums.Length; i++)
            {
                hashSet.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(a))
                {
                    a++;
                }
            }
            
            return a;
        }
        
        
        public int FirstMissingPositiveAnotherSolution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = 0;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int value = Math.Abs(nums[i]);
                if (value >= 1 && value <= nums.Length)
                {
                    int index = value - 1;
                    if (nums[index] > 0)
                    {
                        nums[index] *= -1;
                    }
                    else if (nums[index] == 0)
                    {
                        nums[index] = -1 * (nums.Length + 1);
                    }
                }
                
            }

            for (int i = 1; i < nums.Length + 1; i++)
            {
                if (nums[i - 1] >= 0)
                {
                    return i;
                }
            }

            return nums.Length + 1;
        }


    }
} 