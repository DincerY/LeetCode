Solution solution = new();
solution.LongestOnes(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2);

Console.WriteLine("Hello, World!");

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        //I should compare curRes and maxRes
        int res = 0;
        int l = 0;
        int r = 0;
        int temp = k;
        while (l <= r)
        {
            if (nums[r] == 0)
            {
                if (temp > 0)
                {
                    temp--;
                    res++;
                    r++;
                }
                else
                {
                    if (nums[l] == 1)
                    {
                        res--;
                        l++;
                    }
                    else
                    {
                        res--;
                        l++;
                        temp++;
                    }
                }
            }
            else
            {
                res++;
                r++;
            }
            
        }


        return 0;
    }
}