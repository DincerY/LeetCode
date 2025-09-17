Solution solution = new();
solution.MoveZeroes(new[] { 0, 1, 0, 3, 12 });

Console.WriteLine("Hello, World!");


public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        int right = 0;
        while (left < nums.Length && right < nums.Length)
        {
            if (nums[left] != 0)
            {
                left++;
                continue;
            }

            if (nums[right] == 0)
            {
                right++;
                continue;
            }

            (nums[left], nums[right]) = (nums[right], nums[left]);
            left++;
        }
    }
}