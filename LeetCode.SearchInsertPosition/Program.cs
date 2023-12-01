using System.Linq;

namespace LeetCode.SearchInsertPosition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.SearchInsert(new[] { 1,3,5,6 }, 7);
        }
    }
    
    
    public class Solution {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left<=right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            if (left > right)
            {
                return right + 1;
            }
            else
            {
                return left;
            }
            return 0;
        }
        
    }
}