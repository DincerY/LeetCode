using System;
using System.Collections;
using System.Collections.Generic;

Solution solution = new Solution();
solution.TwoSum2( new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
solution.TwoSum2( new int[] { 3,3 }, 6);

Console.WriteLine("Hello World!");

public partial class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("");
    }
}

public partial class Solution
{
    public int[] TwoSum2(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (dic.ContainsKey(difference))
            {
                return new int[] { dic[difference], i };
            }

            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        return new[] { -1, -1 };
    }
}
