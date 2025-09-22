Solution solution = new();
solution.MaxOperations(new[] { 1, 2, 3, 4 }, 5);
solution.MaxOperations(new[] { 3, 1, 3, 4, 3 }, 6);
Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;
        int res = 0;
        while (left < right)
        {
            int total = nums[left] + nums[right];
            if (total == k)
            {
                left++;
                right--;
                res++;
            }
            else if (total < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return res;
    }
}