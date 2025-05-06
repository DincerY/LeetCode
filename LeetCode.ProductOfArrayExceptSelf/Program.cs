Solution solution = new();
solution.ProductExceptSelf(new[] { 1, 2, 3, 4 });

Console.WriteLine("Hello, World!");

//Time limit exceeded
public class Solution
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