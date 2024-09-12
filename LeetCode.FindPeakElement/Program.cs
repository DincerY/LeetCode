Solution solution = new();
// solution.FindPeakElement2(new[]
// {
//     1, 2, 3, 1
// });

solution.FindPeakElement2(new[]
{
    1, 2, 1, 3, 5, 6, 4
});


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int FindPeakElement(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        if (nums[0] > nums[1])
        {
            return 0;
        }

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                return i;
            }
        }

        if (nums[nums.Length - 1] > nums[nums.Length - 2])
        {
            return nums.Length - 1;
        }

        return 0;
    }
}

//it is not mine
public partial class Solution
{
    public int FindPeakElement2(int[] nums)
    {
        int l = 0, r = nums.Length - 1;

        while (l <= r)
        {
            int m = l + ((r - l) / 2);
            if (m > 0 && nums[m] < nums[m - 1])
            {
                r = m - 1;
            }
            else if (m < nums.Length - 1 && nums[m] < nums[m + 1])
            {
                l = m + 1;
            }
            else
            {
                return m;
            }
        }

        return -1;
    }
}