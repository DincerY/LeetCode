Solution solution = new();
solution.LongestOnes(new[] {0,0,1,1,1,0,0 }, 0);
solution.LongestOnes2(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2);
solution.LongestOnes(new[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3);


Console.WriteLine("Hello, World!");

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int l = 0;
        int maxLen = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            if (nums[r] == 0) 
                k--;

            if (k < 0)
            {
                if (nums[l] == 0) 
                    k++;
                l++;
            }
            maxLen = Math.Max(maxLen, r - l + 1);
        }
        return maxLen;
    }
    public int LongestOnes2(int[] nums, int k)
    {
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == 0) {
                k--;
            }
            if (k < 0) {
                if (nums[left] == 0) {
                    k++;
                }
                left++;
            }
        }

        return nums.Length - left;
    }
}