using System.Data.Common;

Solution solution = new();
solution.LengthOfLISDp(new[] { 10, 9, 2, 5, 3, 7, 101, 18 });
solution.LengthOfLISDp(new[] { 0,1,0,3,2,3 });


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] LIS = new int[nums.Length];
        Array.Fill(LIS, 1);
        
        for (int i = nums.Length - 1; i >= 0; i--) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] < nums[j]) {
                    LIS[i] = Math.Max(LIS[i], 1 + LIS[j]);
                }
            }
        }
        return Max(LIS);
    }

    private int Max(int[] array) {
        int max = array[0];
        foreach (int num in array) {
            if (num > max) {
                max = num;
            }
        }
        return max;
    }
}


//Time limit exceeded
public partial class Solution {
    public int LengthOfLIS2(int[] nums)
    {
        int max = 0;
        void Dfs(int index, int lastVal,int len)
        {
            max = Math.Max(max, len);
            if (index < nums.Length)
            {
                if (lastVal < nums[index])
                {
                    Dfs(index+1,nums[index],len+1);
                }
                Dfs(index+1,lastVal,len);
            }
        }
        Dfs(0,int.MinValue,0);
        return max;
    }
}


//Very efficient
public partial class Solution {
    public int LengthOfLISDp(int[] nums)
    {
        int max = 0;
        int[] arr = new int[nums.Length];
        for (int i = nums.Length-1; i >= 0; i--)
        {
            arr[i] = 1;
            int val = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    arr[i] = Math.Max(arr[i], arr[j] + 1);
                }
            }
            max = Math.Max(max, arr[i]);
        }
        return max;
    }
}