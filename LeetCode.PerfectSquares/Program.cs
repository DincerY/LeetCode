Solution solution = new();
solution.NumSquares(37);
solution.NumSquares(12);
solution.NumSquares(13);


Console.WriteLine("Hello, World!");

//NeedCode solution
 public class Solution {
     public int NumSquares(int n) {
         int[] dp = new int[n + 1];
         for (int i = 1; i <= n; i++) {
             dp[i] = n;
         }
         dp[0] = 0;

         for (int target = 1; target <= n; target++) {
             for (int s = 1; s * s <= target; s++) {
                 int square = s * s;
                 dp[target] = Math.Min(dp[target], 1 + dp[target - square]);
             }
         }
         return dp[n];
     }
 }
 