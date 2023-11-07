using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeetCode.ThreeSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.ThreeSum(new[] { -1, -2, 0, 7, 1, 2,3, 3 });
            foreach (var ab in a)
            {
                foreach (var abc in ab)
                {
                    Console.Write($"{abc}");
                }
                Console.WriteLine();
            }
        }
    }
    
    public class Solution {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length <= 2)
                return result;
            
            Array.Sort(nums);
            int start = 0;
            int left;
            int right;
            int target;

            while (start < nums.Length - 2)
            {
                target = nums[start] * -1;
                left = start + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[left] + nums[right] > target)
                    {
                        --right;
                    }
                    else if (nums[left] + nums[right] < target)
                    {
                        ++left;
                    }
                    else
                    {
                        List<int> OneArray = new List<int>() { nums[start], nums[left], nums[right] };
                        result.Add(OneArray);

                        while (left<right && nums[left] == OneArray[1]) 
                            ++left;

                        while (left<right && nums[right] == OneArray[2]) 
                            --right;
                    }
                    
                }
                int currentStart = nums[start];
                while (start < nums.Length - 2 && nums[start] == currentStart)
                {
                    ++start;
                }
            }

            return result;

        }
    }
}