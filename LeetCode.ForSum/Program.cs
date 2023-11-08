using System;
using System.CodeDom;
using System.Collections.Generic;

namespace LeetCode.ForSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FourSum(new[] { 1, 0, -1, 0, -2, 2 }, 0);
        }
    }
    
    public class Solution {
        public IList<IList<int>> FourSum(int[] nums, int target) {
        
            Array.Sort(nums);
            int len = nums.Length;
            long sum;
            int left;
            int right;
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < len-3; i++) 
            {
                for (int j = i+1; j < len-2; j++)
                {
                    left = j + 1;
                    right = len - 1;

                    while (left < right) 
                    {
                        sum  = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];
                        if (sum == target) {
                            CheckAndAdd(result, nums[i], nums[j], nums[left], nums[right]);
                            left++;
                            right--;
                        }
                        else if (sum < target) {
                            left++;
                        }
                        else {
                            right--;
                        }
                    }
                    while (j < len-2 && nums[j+1] == nums[j]) 
                    {
                        j++;
                    }
                }

                while (i < len-3 && nums[i+1] == nums[i]) 
                {
                    i++;
                }
            }
            return result;
        } 

        static void CheckAndAdd(IList<IList<int>> result, int a, int b, int c, int d) {
            if (result.Count == 0) {
                result.Add(new List<int> {a, b, c, d});
            }
            else if (result[result.Count-1][0] != a || result[result.Count-1][1] != b || result[result.Count-1][2] != c) {
                result.Add(new List<int> {a, b, c, d});
            }
            return;
        }
    }

}