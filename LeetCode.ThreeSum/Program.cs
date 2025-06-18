using System;
using System.Collections.Generic;

Solution solution = new();
solution.ThreeSum2(new[] { -1, 0, 1, 2, -1, 4 });

solution.ThreeSum2(new[] { -1, -2, 0, 7, 1, 2, 3, 3 });


public partial class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length <= 2)
            return result;

        Array.Sort(nums);
        int start = 0;
        int left;
        int right;
        int target;

        while (start < nums.Length - 2)
        {
            target = nums[start] * -1;
            left = start + 1;
            right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] > target)
                {
                    --right;
                }
                else if (nums[left] + nums[right] < target)
                {
                    ++left;
                }
                else
                {
                    List<int> OneArray = new List<int>() { nums[start], nums[left], nums[right] };
                    result.Add(OneArray);

                    while (left < right && nums[left] == OneArray[1])
                        ++left;

                    while (left < right && nums[right] == OneArray[2])
                        --right;
                }
            }
            int currentStart = nums[start];
            while (start < nums.Length - 2 && nums[start] == currentStart)
            {
                ++start;
            }
        }

        return result;
    }
}

public partial class Solution
{
    public IList<IList<int>> ThreeSum2(int[] nums)
    {
        List<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int l = i + 1, r = nums.Length - 1;
            while (l < r)
            {
                int threeSum = nums[i] + nums[l] + nums[r];
                if (threeSum > 0)
                {
                    r--;
                }
                else if (threeSum < 0)
                {
                    l++;
                }
                else
                {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
            }
        }
        return res;
    }
}