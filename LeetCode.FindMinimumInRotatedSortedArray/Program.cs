Solution solution = new();
// solution.FindMin3(new[]
// {
//     3,4,5,1,2
// });

solution.FindMin3(new[]
{
    2,3,4,5,1
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

public partial class Solution
{
    public int FindMin2(int[] nums)
    {
        if (nums[0] <= nums[^1])
        {
            return nums[0];
        }
        else
        {
            int index = nums.Length - 1;
            while (nums[index] > nums[index - 1])
            {
                index--;
            }
            return nums[index];
        }
    }
}


public partial class Solution {
    public int FindMin3(int[] nums) {
        int res = nums[0];
        int l = 0, r = nums.Length - 1;

        while (l <= r) {
            if (nums[l] < nums[r]) {
                res = Math.Min(res, nums[l]);
                break;
            }
            int m = (l + r) / 2;
            res = Math.Min(res, nums[m]);
            if (nums[m] >= nums[l]) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        return res;
    }
}
