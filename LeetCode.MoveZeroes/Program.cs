Solution solution = new();
solution.MoveZeroes2(new[] { 0, 1, 0, 3, 12 });
solution.MoveZeroes2(new[] { 1, 0, 3, 12 });
solution.MoveZeroes2(new[] { 1, 0, 1});

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
                right = left;
                continue;
            }

            if (nums[right] == 0)
            {
                right++;
                continue;
            }

            if (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
            }
            else
            {
                break;
            }
        }
    }

    public void MoveZeroes2(int[] nums)
    {
        int nonZeroPosition = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[nonZeroPosition]) = (nums[nonZeroPosition], nums[i]);
                nonZeroPosition++;
            }
        }
    }
}