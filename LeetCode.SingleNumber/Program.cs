Solution solution = new();
solution.SingleNumber(new[] { 2, 2, 1 });
solution.SingleNumber(new[] { 4, 1, 2, 1, 2 });


Console.WriteLine("Hello, World!");


public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        int i;
        for (i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                i++;
            }
            else
            {
                break;
            }
        }

        return nums[i];
    }
}