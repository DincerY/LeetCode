using System;

namespace LeetCode.RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            // var a = solution.RemoveDuplicates(new[] {1,1,2});
            var b = solution.RemoveDuplicates(new []{0,0,1,1,1,2,2,3,3,4});
            Console.WriteLine();
        }
    }


    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int l = 1;

            for (int r = 1; r < nums.Length; r++)
            {
                if (nums[r] != nums[r-1])
                {
                    nums[l] = nums[r];
                    l += 1;
                }
            }

            return l;
        }
        
    }
}