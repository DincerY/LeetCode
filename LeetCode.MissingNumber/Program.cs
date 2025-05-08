Solution solution = new();
solution.MissingNumber(new[] { 3, 0, 1 });

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }

        return nums[^1]+1;
    }
}
public partial class Solution
{
    public int MissingNumber2(int[] nums)
    {
        int max = nums.Length;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        int res = (max * (max + 1)) / 2 - sum;
        if (res > 0)
        {
            return res;
        }
        else 
        {
            return 0;
        }
    }
}
//NeedCode solution
public partial class Solution
{
    public int MissingNumber3(int[] nums)
    {
        int res = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            res += (i - nums[i]);
        }
        return res;
    }
}