Solution solution = new();
solution.NumSquares2(12);
solution.NumSquares2(13);
solution.NumSquaresBruteForce(37);
solution.NumSquaresBruteForce(55);



Console.WriteLine("Hello, World!");

//NeedCode solution
 public partial class Solution {
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



 public partial class Solution {
     public int NumSquaresBruteForce(int n)
     {
         int min = 10000;
         void Backtrack(int total,int val)
         {
             if (total == n)
             {
                 min = Math.Min(min, val);
                 return;
             }
             if (total > n)
             {
                 return;
             }
             for (int i = 1; i*i <= n; i++)
             {
                 if ((n-total) - i*i < 0)
                 {
                     break;
                 }
                 Backtrack(total + (i*i) ,val+1);
             }
         } 
         Backtrack(0,0);
         return min;
     }
 }

//Dynamic Programming memoization
 public partial class Solution {
     public int NumSquares2(int n)
     {
         Dictionary<int, int> dp = new();
         int Backtrack(int total)
         {
             if (total == 0)
             {
                 return 0;
             }

             if (dp.ContainsKey(total))
             {
                 return dp[total];
             }
             int tempMin = 100000;
             for (int i = 1; i*i <= total; i++)
             {
                 tempMin = Math.Min(tempMin,1+Backtrack(total - (i*i)));
             }

             dp[total] = tempMin;
             return tempMin;
         } 
         return Backtrack(n);
     }
 }

 public partial class Solution {
     public int NumSquares3(int n)
     {
         int[] arr = new int[n+1];
         List<int> list = new();
         for (int i = 1; i*i<= n; i++)
         {
             list.Add(i*i);
         }
         for (int i = 1; i < n+1; i++)
         {
             arr[i] = 100000;
             foreach (var val in list)
             {
                 if (i - val >= 0)
                 {
                     arr[i] = Math.Min(arr[i], arr[i - val] + 1);
                 }
                 else
                 {
                     break;
                 }
             }
         }
         return arr[n];
     }
 }
 
 public partial class Solution {
     public int NumSquares4(int n)
     {
         int[] arr = new int[n+1];
         for (int i = 1; i < n+1; i++)
         {
             arr[i] = 100000;
             for (int j = 1; j*j<= n; j++)
             {
                 int sq = j * j;
                 if (i - sq >= 0)
                 {
                     arr[i] = Math.Min(arr[i], arr[i - sq] + 1);
                 }
                 else
                 {
                     break;
                 }
             }
         }
         return arr[n];
     }
 }
 
