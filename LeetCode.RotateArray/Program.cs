Solution solution = new();
solution.Rotate2(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3);

Console.WriteLine("Hello, World!");

public partial class Solution
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

//NeedCode solution
public partial class Solution
{
    public void Rotate2(int[] nums, int k)
    {
        k %= nums.Length;
        int l = 0;
        int r = nums.Length - 1;
        while (l < r)
        {
            (nums[l],nums[r]) = (nums[r], nums[l]);
            l = l + 1;
            r = r - 1;
        }

        l = 0;
        r = k - 1;
        while (l < r)
        {
            (nums[l],nums[r]) = (nums[r], nums[l]);
            l = l + 1;
            r = r - 1;
        }
        
        l = k;
        r = nums.Length - 1;
        while (l < r)
        {
            (nums[l],nums[r]) = (nums[r], nums[l]);
            l = l + 1;
            r = r - 1;
        }

    }
}