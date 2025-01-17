Solution solution = new();
solution.LengthOfLIS2(new[] { 10, 9, 2, 5, 3, 7, 101, 18 });


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

public partial class Solution {
    public int LengthOfLIS2(int[] nums) {
        void Dfs(int index, int num)
        {
            if (index < nums.Length && num < nums[index])
            {
                Dfs(index+1,num);
                Dfs(index+2,num);

            }
            
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Dfs(i + 1, nums[i]);
        }

        
        return 0;
    }

    
}