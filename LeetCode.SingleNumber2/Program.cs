Solution solution = new();
//solution.SingleNumber(new[] { 0, 1, 0, 1, 0, 1, 99 });
solution.SingleNumber(new[] { 2,2,3,2 });


Console.WriteLine("Hello, World!");


public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        int i;
        for (i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                i += 2;
            }
            else
            {
                break;
            }
        }

        return nums[i];
    }
}