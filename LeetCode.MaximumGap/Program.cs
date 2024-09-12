Solution solution = new();
solution.MaximumGap(new[]
{
    3, 6, 9, 1
});


Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaximumGap(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 0;
        }
        Array.Sort(nums);
        List<int> list = new();
        for (int i = 1; i < nums.Length; i++)
        {
            list.Add(nums[i] - nums[i-1]);
        }
        
        return list.Max();
    }
}