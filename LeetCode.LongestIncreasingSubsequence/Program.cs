Solution solution = new();
solution.LengthOfLIS(new[] { 10, 9, 2, 5, 3, 7, 101, 18 });


Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution {
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