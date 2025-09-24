Solution solution = new();
solution.FindMaxAverage(new[] { 1, 12, -5, -6, 50, 3 }, 4);

Console.WriteLine("Hello, World!");

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int count = 0;
        for (int i = 0; i < k; i++)
        {
            count += nums[i];
        }

        double res = (double)count / k;
        int l = 0;
        int r = k - 1;
        while (r + 1 < nums.Length)
        {
            count -= nums[l];
            l++;
            r++;
            count += nums[r];
            res = Math.Max(res, (double)count / k);
        }
        return res;
    }
}