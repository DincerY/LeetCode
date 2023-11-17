namespace LeetCode.RemoveElement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.RemoveElement(new[] { 0,1,2,2,3,0,4,2 }, 2);
        }
    }


    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != val)
                {
                    nums[l] = nums[r];
                    l++;
                }
            }
            return l;
        }
    }
}