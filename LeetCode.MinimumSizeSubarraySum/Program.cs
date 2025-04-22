Solution solution = new();
//solution.MinSubArrayLen2(7, new[] { 2, 3, 1, 2, 4, 3 });
solution.MinSubArrayLen2(4, new[] { 1, 4, 4 });
solution.MinSubArrayLen2(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 });
solution.MinSubArrayLen2(15, new[] { 1,2,3,4,5 });

Console.WriteLine("Hello, World!");

public partial class Solution
{
    // Bu çözüm bir greedy yaklaşım ondan dolayı soruyu çözemez
    public int MinSubArrayLen(int target, int[] nums)
    {
        int temp = 0;
        int min = 10000000;
        for (int i = 0; i < nums.Length; i++)
        {
            temp = nums[i];
            int totalOp = 1;
            int left = i - 1;
            int right = i + 1;
            
            while (left >= 0 && right < nums.Length && temp < target)
            {
                if (nums[left] > nums[right])
                {
                    temp += nums[left];
                    left--;
                }
                else
                {
                    temp += nums[right];
                    right++;
                }

                totalOp++;
            }
           
            while (left >= 0 && temp < target)
            {
                temp += nums[left];
                left--;
                totalOp++;
            }
            while (right < nums.Length && temp < target)
            {
                temp += nums[right];
                right++;
                totalOp++;
            }

            if (temp >= target)
            {
                min = Math.Min(min,totalOp);
            }
            else
            {
                min = 0;
            }
          
        }
        return 0;

    }
}

public partial class Solution
{
    // Sliding window yaklaşımı
    public int MinSubArrayLen2(int target, int[] nums)
    {
        int total = 0;
        int l = 0;
        int len = int.MaxValue;
        for (int r = 0; r < nums.Length; r++)
        {
            total += nums[r];
            while (target <= total)
            {
                len = Math.Min(len, r - l+1);
                total -= nums[l];
                l++;
            }
        }
        return len != int.MaxValue ? len : 0;
    }
}