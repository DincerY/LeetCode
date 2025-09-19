using System;

Solution solution = new();
solution.MaxArea4(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

public partial class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0, j = height.Length-1;
        int result = 0;
        while (i < j)
        {
            int minHeight = Math.Min(height[i], height[j]);
            int maxArea = minHeight * (j - i);
            result = Math.Max(result, maxArea);
            if (height[i] == minHeight)
            {
                i++;
            }
            else
            {
                j--;
            }

        }
        return result;
    }
}
//Time limit exceeded
public partial class Solution
{
    public int MaxArea2(int[] height)
    {
        int result = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i+1; j < height.Length; j++)
            {
                int area = Math.Min(height[i], height[j]) * (j - i);
                result = Math.Max(area, result);
            }
        }
        return result;
    }
}

public partial class Solution
{
    public int MaxArea3(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;
        int maxHeight = 0;
        while (l < r)
        {
            int min = Math.Min(height[l], height[r]);
            maxHeight = Math.Max(maxHeight,min * (r -l));
            if (height[l] < height[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return maxHeight;
    }
}

public partial class Solution
{
    public int MaxArea4(int[] height)
    {
        int left = 0;
        int right = height.Length-1;
        int max = 0;
        while (left < right)
        {
            var minVal = Math.Min(height[left], height[right]);
            if (max < (right - left) * minVal)
            {
                max = (right - left) * minVal;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return max;
    }
}
