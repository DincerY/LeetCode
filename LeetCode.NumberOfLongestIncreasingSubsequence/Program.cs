Solution solution = new();
//solution.FindNumberOfLIS(new[] { 1, 3, 5, 4, 7 });
solution.FindNumberOfLIS(new[] { 1, 2, 4, 3, 5, 4, 7, 2 });
solution.FindNumberOfLIS(new[] { 2, 2, 2, 2, 2 });


Console.WriteLine("Hello, World!");


//NeedCode solution
public partial class Solution
{
    public int FindNumberOfLIS(int[] nums)
    {
        Dictionary<int, int[]> dp = new Dictionary<int, int[]>();
        int lenLIS = 0, res = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            int maxLen = 1, maxCnt = 1;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    int length = dp[j][0];
                    int count = dp[j][1];
                    if (length + 1 > maxLen)
                    {
                        maxLen = length + 1;
                        maxCnt = count;
                    }
                    else if (length + 1 == maxLen)
                    {
                        maxCnt += count;
                    }
                }
            }

            if (maxLen > lenLIS)
            {
                lenLIS = maxLen;
                res = maxCnt;
            }
            else if (maxLen == lenLIS)
            {
                res += maxCnt;
            }

            dp[i] = new int[] { maxLen, maxCnt };
        }

        return res;
    }
}