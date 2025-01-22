Solution solution = new();
solution.MaxProduct4(new[]
{
    2, 3, -2, 4
});
solution.MaxProduct4(new[]
{
    2, 3, -5, 4, -2
});

solution.SubArray(new[]
{
    2, 3, -2, 4
});


Console.WriteLine("Hello, World!");


//it worked but time limit exceeded
public partial class Solution
{
    public int MaxProduct(int[] nums)
    {
        int max = int.MinValue;
        for (int i = 1; i < nums.Length + 1; i++)
        {
            for (int j = 0; j <= nums.Length - i; j++)
            {
                var arr = nums.Skip(j).Take(i).ToArray();
                int temp = 1;
                foreach (var val in arr)
                {
                    temp *= val;
                }
                max = Math.Max(max, temp);
            }
        }
        return max;
    }
}

//Needcode solution
public partial class Solution
{
    public int MaxProduct2(int[] nums)
    {
        int res = nums.Max();
        int curMin = 1, curMax = 1;

        foreach (int n in nums)
        {
            if (n == 0)
            {
                curMin = 1;
                curMax = 1;
                continue;
            }
            int tmp = curMax * n;
            curMax = Math.Max(n * curMax, Math.Max(n * curMin, n));
            curMin = Math.Min(tmp, Math.Min(n * curMin, n));
            res = Math.Max(res, curMax);
        }
        return res;
    }
}

public partial class Solution
{
    public int MaxProduct3(int[] nums)
    {
        Dictionary<int, (int min, int max)> dp = new();
        dp[0] = (nums[0], nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = (Math.Min(nums[i], Math.Min(dp[i - 1].min * nums[i], dp[i - 1].max * nums[i])),
                Math.Max(nums[i], Math.Max(dp[i - 1].min * nums[i], dp[i - 1].max * nums[i])));
        }
        var max = dp.Select(kv => kv.Value).Select(a => a.max).Max();
        return max;
    }
}

//Subarrays of any array
public partial class Solution
{
    public void SubArray(int[] nums)
    {
        List<List<int>> list = new();
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j <= nums.Length - i; j++)
            {
                list.Add(nums.Skip(j).Take(i).ToList());
            }
        }
        list.Add(nums.ToList());
    }
}



public partial class Solution
{
    public int MaxProduct4(int[] nums)
    {
        int min = 1;
        int max = 1;
        int res = int.MinValue;
        for (int i = nums.Length-1; i >= 0; i--)
        {
            
            int tempMin = min;
            min = Math.Min(nums[i], Math.Min(nums[i] * min, nums[i] * max));
            max = Math.Max(nums[i], Math.Max(nums[i] * tempMin, nums[i] * max));
            res = Math.Max(res, max);
        }
        return res;
    }
}


    

