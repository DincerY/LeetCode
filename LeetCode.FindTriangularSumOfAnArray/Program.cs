Solution solution = new();
solution.TriangularSum(new[] { 1, 2, 3, 4, 5 });


Console.WriteLine("Hello, World!");


public class Solution
{
    public int TriangularSum(int[] nums)
    {
        int bound = nums.Length;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < bound-1; j++)
            {
                nums[j] = (nums[j] + nums[j + 1]) % 10;
            }
            bound--;
        }
        return nums[0];
    }
}