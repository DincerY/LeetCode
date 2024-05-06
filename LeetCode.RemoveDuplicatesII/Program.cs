Solution solution = new();
// var a =solution.RemoveDuplicates(new[]
// {
//     0, 0, 1, 1, 1, 1, 2, 3, 3
// });


var a = solution.RemoveDuplicates2(new[]
{
    1, 1, 1, 2, 2, 3
});

Console.WriteLine(a);


public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int sum = 0;
        int[] arr = new int[nums[^1] + 1];
        for (int r = 0; r < nums.Length; r++)
        {
            if (arr[nums[r]] < 2)
            {
                arr[nums[r]]++;
            }
        }
        foreach (var a in arr)
        {
            sum += a;
        }

        return sum;
    }


    public int Remove1Duplicates(int[] nums)
    {
        int l = 1;
        for (int r = 1; r < nums.Length; r++)
        {
            if (nums[r] != nums[r - 1])
            {
                nums[l] = nums[r];
                l++;
            }
        }

        return l;
    }
}


public partial class Solution
{
    public int RemoveDuplicates2(int[] nums)
    {
        int left = 0;
        int right = 0;

        while (right < nums.Length)
        {
            int count = 1;
            while (right +1 < nums.Length && nums[right] == nums[right+1])
            {
                right++;
                count++;
            }

            for (int i = 0; i < Math.Min(2, count); i++)
            {
                nums[left] = nums[right];
                left++;
            }

            right++;
        }

        return left;

    }
}