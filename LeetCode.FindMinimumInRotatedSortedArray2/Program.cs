Solution solution = new();
solution.FindMin2(new[]
{
    4, 4, 0, 1, 2, 3
});


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int FindMin(int[] nums)
    {
        Array.Sort(nums);
        return nums[0];
    }
}

//it is not mine solution
public partial class Solution
{
    public int FindMin2(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int mid = (l + r) / 2;
            if (nums[mid] > nums[r])
            {
                l = mid + 1;
            }
            else if (nums[mid] < nums[l])
            {
                r = mid;
            }
            else
            {
                r--;
            }
        }

        return nums[l];
    }
}