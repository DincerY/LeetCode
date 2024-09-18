Solution solution = new();
solution.Rotate(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3);

Console.WriteLine("Hello, World!");

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        if (k == nums.Length || k == 0 || nums.Length == 1)
        {
            return;
        }

        int[] arr = new int[k];
        int startIndex = nums.Length - k;
        int lastIndex = startIndex - 1;
        for (int i = startIndex; i < nums.Length; i++)
        {
            arr[i - startIndex] = nums[i];
        }

        for (int i = lastIndex; i >= 0; i--)
        {
            nums[i + k] = nums[i];
        }

        for (int i = 0; i < k; i++)
        {
            nums[i] = arr[i];
        }
    }
}