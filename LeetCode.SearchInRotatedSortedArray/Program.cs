using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;

namespace LeetCode.SearchInRotatedSortedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.Search(new[] { 4,5,6,7,0,1,2 }, 0);
        }
    }


    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            return NumsDivided(nums, 0, nums.Length - 1, target);
        }

        private int NumsDivided(int[] arr, int left, int right, int target)
        {
            int mid = (left + right) / 2;

            if (left > right)
            {
                return -1;
            }

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] >= arr[left])
            {
                //left half
                if (arr[mid] >= target && arr[left] <= target)
                {
                    return NumsDivided(arr, left, mid - 1, target);
                }
                else
                {
                    return NumsDivided(arr, mid + 1, right, target);
                }
            }
            else
            {
                //right half

                if (arr[mid] <= target && arr[right] >= target)
                {
                    return NumsDivided(arr, mid+1, right, target);
                }
                else
                {
                    return NumsDivided(arr, left, mid-1, target);
                }
            }


            return -1;
        }
    }
}