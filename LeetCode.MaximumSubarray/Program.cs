using System.Threading.Channels;

Solution solution = new Solution();
var result = solution.MaxSubArray3(new[] {5,4,-1,7,8});
Console.WriteLine(result);

Console.WriteLine("Hello, World!");



public partial class Solution {
    public int MaxSubArray(int[] nums)
    {
        List<List<int>> list = new();
        for (int i = 0; i < nums.Length; i++)
        {
            var value = new List<int>(){nums[i]};
            list.Add(new List<int>(value));
            for (int j = i + 1; j < nums.Length; j++)
            {
                value.Add(nums[j]);
                list.Add(new List<int>(value));
            }
        }
        var total = Int32.MinValue;

        foreach (var lis in list)
        {
            var newTotal = Sum(lis);
            if (newTotal > total)
            {
                total = newTotal;
            }
        }
        return total;
    }

    private int Sum(List<int> arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
}


public partial class Solution
{
    public int MaxSubArray2(int[] nums)
    {
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum < 0)
            {
                sum = 0;
                continue;
            }
            maxSum = Math.Max(sum, maxSum);
        }
        if (maxSum == 0)
        {
            return nums.Max();
        }
        return maxSum;
    }
}


public partial class Solution
{
    public int MaxSubArray3(int[] nums)
    {
        int sum = nums[0];
        int maxSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (sum < 0) sum = 0;
            sum += nums[i];
            maxSum = Math.Max(sum, maxSum);
        }
        return maxSum;
    }
}












