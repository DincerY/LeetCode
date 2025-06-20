using System;

Solution solution = new();

solution.Trap3(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
solution.Trap3(new[] { 4, 2, 0, 3, 2, 5 });


public partial class Solution
{
    public int Trap(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        int leftValue = height[leftPointer];
        int rightValue = height[rightPointer];
        int sum = 0;
        while (leftPointer != rightPointer)
        {
            if (leftValue <= rightValue)
            {
                if (leftValue < height[leftPointer + 1])
                {
                    leftPointer++;
                    leftValue = height[leftPointer];
                }
                else
                {
                    leftPointer++;
                    int value = leftValue - height[leftPointer];
                    if (value > 0)
                    {
                        sum += value;
                    }
                }
            }
            else
            {
                if (rightValue < height[rightPointer - 1])
                {
                    rightPointer--;
                    rightValue = height[rightPointer];
                }
                else
                {
                    rightPointer--;
                    int value = rightValue - height[rightPointer];
                    if (value > 0)
                    {
                        sum += value;
                    }
                }
            }
        }
        return sum;
    }
}

public partial class Solution
{
    public int TrapWithOneSpace(int[] height)
    {
        int[] minLeftRight = new int[height.Length];
        int maxValue = height[0];
        int maxRightValue = height[height.Length - 1];
        int sum = 0;

        //Find Max Value For Every Left Of Number And Add minLeftRight Array
        for (int i = 1; i < height.Length; i++)
        {
            if (maxValue < height[i - 1])
            {
                maxValue = height[i - 1];
            }

            minLeftRight[i] = maxValue;
        }

        //Find Max Value For Every Right Of Number And Compare minLeftRight Array And Again Add Min Value minLeftRight Array
        for (int i = height.Length - 1; i >= 0; i--)
        {
            minLeftRight[i] = Math.Min(minLeftRight[i], maxRightValue);
            if (height[i] > maxRightValue)
            {
                maxRightValue = height[i];
            }
        }

        for (int i = 0; i < height.Length; i++)
        {
            int a = minLeftRight[i] - height[i];
            if (a < 0)
            {
                sum += 0;
            }
            else
            {
                sum += a;
            }
        }
        return sum;
    }
}

public partial class Solution
{
    public int ShortTrap(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        int leftValue = height[leftPointer];
        int rightValue = height[rightPointer];
        int sum = 0;
        while (leftPointer != rightPointer)
        {
            if (leftValue <= rightValue)
            {
                leftPointer++;
                leftValue = Math.Max(leftValue, height[leftPointer]);
                sum += leftValue - height[leftPointer];
            }
            else
            {
                rightPointer--;
                rightValue = Math.Max(rightValue, height[rightPointer]);
                sum += rightValue - height[rightPointer];
            }
        }
        return sum;
    }
}

public partial class Solution
{
    public int Trap2(int[] height)
    {
        int[] arr = new int[height.Length];
        int temp = 0;
        for (int i = 0; i < height.Length; i++)
        {
            arr[i] = temp;
            if (height[i] > temp)
            {
                temp = height[i];
            }
        }

        temp = 0;
        for (int i = height.Length - 1; i >= 0; i--)
        {
            arr[i] = Math.Min(arr[i], temp);
            if (height[i] > temp)
            {
                temp = height[i];
            }
        }

        int res = 0;
        for (int i = 0; i < height.Length; i++)
        {
            res += arr[i] - height[i] > 0 ? arr[i] - height[i] : 0;
        }
        return res;
    }
}

public partial class Solution
{
    public int Trap3(int[] height)
    {
        //maxL ve maxR sol ve sağın en büyük elemanını içerirler fakat aralarından hangisi daha küçükse o kararı verir
        int l = 0;
        int r = height.Length - 1;
        int maxL = height[l];
        int maxR = height[r];
        int res = 0;
        while (l < r)
        {
            if (maxL > maxR)
            {
                r--;
                maxR = Math.Max(maxR, height[r]);
                res += maxR - height[r];
            }
            else
            {
                l++;
                maxL = Math.Max(maxL, height[l]);
                res += maxL - height[l];
            }
        }
        return res;
    }
}