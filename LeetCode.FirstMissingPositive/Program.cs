using System;

namespace LeetCode.FirstMissingPositive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.FirstMissingPositive(new[] { 3,4,-1,1 });
        }
    }
    
    
    public class Solution {
        public int FirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i + 1] - nums[i] > 0)
                {
                    return nums[i + 1] - nums[i];
                }
            }
            







            return 0;
        }
    }
}