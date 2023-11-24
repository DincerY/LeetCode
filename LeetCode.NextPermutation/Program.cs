using System;
using System.Linq;

namespace LeetCode.NextPermutation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.NextPermutation(new[] { 1,1 });
        }
    }


    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i>=0)
            {
                int j = nums.Length - 1;

                while (nums[j] <= nums[i])
                {
                    j--;
                }
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
            

            nums.AsSpan(i+1, nums.Length - i-1).Reverse();
        }

    }
}