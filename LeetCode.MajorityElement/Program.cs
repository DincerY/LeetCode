Solution solution = new();
solution.MajorityElement2(new[]
{
    2, 2, 1, 1, 1, 2, 2
});


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length / 2;
        int index = 0;
        while (index < nums.Length)
        {
            if (nums[index] == nums[index + n])
            {
                return nums[index];
            }
            else
            {
                index++;
            }
        }

        return nums[^1];
    }
}

public partial class Solution
{
    public int MajorityElement2(int[] nums)
    {
        Array.Sort(nums);
        int n = (nums.Length - 1) / 2;
        return nums[n];
    }
}
