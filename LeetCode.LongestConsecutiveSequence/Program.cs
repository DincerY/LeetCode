using System.ComponentModel;

Solution solution = new();
//solution.LongestConsecutive(new []{100,4,200,1,3,2});
//solution.LongestConsecutive(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
solution.LongestConsecutive(new[] { 1, 2, 0, 1 });


Console.WriteLine("Hello, World!");

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }
        
        int max = 0;
        int temp = 0;
        Array.Sort(nums);
        List<int> list = new();
        list.Add(nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                list.Add(nums[i]);
            }
        }

        nums = list.ToArray();
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == 1)
            {
                temp++;
            }
            else
            {
                max = Math.Max(max, temp);
                temp = 0;
            }
        }

        max = Math.Max(max, temp);

        return max + 1;
    }
}