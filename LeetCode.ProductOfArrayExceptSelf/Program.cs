Solution solution = new();
solution.ProductExceptSelf3(new[] { 1, 2, 3, 4 });
solution.ProductExceptSelf3(new[] { -1, 1, 0, -3, 3 });

Console.WriteLine("Hello, World!");

//Time limit exceeded
public partial class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int val = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }

                val *= nums[j];
            }
            res[i] = val;
        }

        return res;
    }
}

public partial class Solution
{
    public int[] ProductExceptSelf2(int[] nums)
    {
        List<int> res = new List<int>(nums.Length);
        res.Add(1);
        for (int i = 0; i < nums.Length-1; i++)
        {
            res.Add(nums[i]*res[i]);
        }
        int postFix = nums[^1];
        for (int i = nums.Length-2; i >= 0; i--)
        {
            res[i] *= postFix;
            postFix *= nums[i];
        }
        return res.ToArray();
    }
}
public partial class Solution
{
    public int[] ProductExceptSelf3(int[] nums)
    {
        int[] res = new int[nums.Length];
        res[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            res[i] = res[i - 1] * nums[i - 1];
        }
        int suffix = 1;
        for (int i = nums.Length-2; i >= 0; i--)
        {
            suffix *= nums[i + 1];
            res[i] *= suffix;
        }
        return res;
    }
}