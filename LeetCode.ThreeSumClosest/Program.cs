using System;
using System.Collections.Generic;

namespace LeetCode.ThreeSumClosest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var a =solution.ThreeSumClosest(new[] { -1, 2, 1, -4 }, 1);
            Console.WriteLine(a);
        }
    }

    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int resultSum = nums[0] + nums[1] + nums[2];
            int minDifference = int.MaxValue;

            for (int i = 0; i < nums.Length-2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        return target;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }

                    int diffToTarget = Math.Abs(sum - target);
                    if (diffToTarget < minDifference)
                    {
                        resultSum = sum;
                        minDifference = diffToTarget;
                    }
                }
            }

            return resultSum;
        }
    }
}