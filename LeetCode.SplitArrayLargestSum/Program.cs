Solution solution = new();
solution.SplitArray2(new[] { 7, 2, 5, 10, 8 }, 3);

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        int max = 0;
        for (int i = 0; i < nums.Length-k+1; i++)
        {
            int temp = 0;
            for (int j = i; j < k+i; j++)
            {
                temp += nums[j];
            }
            max = Math.Max(max, temp);
        }
        return max;
    }
}

public partial class Solution
{
    public int SplitArray2(int[] nums, int k)
    {
        void Backtrack(int index, int m)
        {
            for (int i = index; i < nums.Length; i++)
            {
                if (m - 1 > 1)
                {
                    Backtrack(i+1,m-1);
                }
            }
        }

        Backtrack(0,k);
        return 0;
    }
}