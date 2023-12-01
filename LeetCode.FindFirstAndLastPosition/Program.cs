using System.Diagnostics.Eventing.Reader;

namespace LeetCode.FindFirstAndLastPosition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.SearchRange(new[] { 5,7,7,8,8,10 }, 8);
        }
    }

    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int left = BinarySearch(nums, target, true);
            int right = BinarySearch(nums, target, false);
            return new[] { left, right };

        }

        private int BinarySearch(int[] nums,int target,bool leftBias)
        {
            int left = 0;
            int right = nums.Length - 1;
            int i = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if(nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    i = mid;
                    if (leftBias)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return i;
        }
    }
}