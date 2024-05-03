﻿Solution solution = new();
// var a =solution.RemoveDuplicates(new[]
// {
//     0, 0, 1, 1, 1, 1, 2, 3, 3
// });


var a = solution.RemoveDuplicates(new[]
{
    1, 1, 1, 2, 2, 3
});

Console.WriteLine(a);


public class Solution
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