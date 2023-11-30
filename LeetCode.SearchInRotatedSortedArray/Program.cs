namespace LeetCode.SearchInRotatedSortedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.Search(new[] { 1, 2, 3 }, 2);
        }
    }
    
    
    public class Solution {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (right - left) / 2;
                if (target > nums[mid])
                {
                    if (target < nums[left])
                    {
                        
                    }
                    else
                    {
                        
                    }
                }


            }
            



            return 0;
        }
    }
}