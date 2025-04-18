Solution solution = new();
solution.MinSubArrayLen2(7, new[] { 2, 3, 1, 2, 4, 3 });
solution.MinSubArrayLen2(4, new[] { 1, 4, 4 });
solution.MinSubArrayLen2(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 });
solution.MinSubArrayLen2(11, new[] { 1,2,3,4,5 });

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int max = -1;
        int maxIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
        }
        int temp = 0;
        int totalOp = 1;
        temp += nums[maxIndex];
        int left = maxIndex - 1;
        int right = maxIndex + 1;

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

        if (temp < target)
        {
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
        }

        if (temp >= target)
        {
            return totalOp;
        }
        else
        {
            return 0;
        }
    }
}

public partial class Solution
{
    // Üst fonksiyonda yaptığımız işlemi her eleman için yapmalıyız
    //Daha sonra bunlardan en az operasyon içereni dönmeliyiz
    public int MinSubArrayLen2(int target, int[] nums)
    {
        int temp = 0;
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

            if (temp < target)
            {
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
            }

            if (temp >= target)
            {
                return totalOp;
            }
            else
            {
                return 0;
            }
          
        }
        return 0;

    }
}