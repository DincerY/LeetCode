Solution solution = new();
solution.LongestIncreasingPath2(new[]
{
    new[] { 9, 9, 4 },
    new[] { 6, 6, 8 },
    new[] { 2, 1, 1 },
});

solution.LongestIncreasingPath(new[]
{
    new[] { 3, 4, 5 },
    new[] { 3, 2, 6 },
    new[] { 2, 2, 1 },
});

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        int[,] dp = new int[matrix.Length,matrix[0].Length];
        int max = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                Backtrack(i,j);
            }
        }

        int Backtrack(int i, int j)
        {
            if (dp[i,j] != 0)
                return dp[i, j];
            int l = 0;
            int r = 0;
            int u = 0;
            int d = 0;
            if (i > 0 && matrix[i-1][j] > matrix[i][j]) 
                u = Backtrack(i - 1, j);
            
            if (i < matrix.Length-1 && matrix[i+1][j] > matrix[i][j]) 
                d = Backtrack(i + 1, j);
            
            if (j > 0 && matrix[i][j-1] > matrix[i][j]) 
                l = Backtrack(i , j - 1);
            
            if (j < matrix[0].Length-1 && matrix[i][j+1] > matrix[i][j]) 
                r = Backtrack(i , j + 1);

            dp[i, j] = Math.Max(l,Math.Max(r,Math.Max(u,d))) + 1;
            max = Math.Max(max, dp[i, j]);
            return dp[i, j];
        }
        Backtrack(0, 0);
        return max;
    }
}

public partial class Solution
{
    public int LongestIncreasingPath2(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        Dictionary<(int, int), int> dp = new();
        
        int Backtrack(int i, int j, int prevVal)
        {
            if (i < 0 || i == rows || j < 0 || j == cols || matrix[i][j] <= prevVal)
            {
                return 0;
            }

            if (dp.ContainsKey((i,j)))
            {
                return dp[(i,j)];
            }

            int res = 1;
            res = Math.Max(res, 1 + Backtrack(i + 1, j, matrix[i][j]));
            res = Math.Max(res, 1 + Backtrack(i - 1, j, matrix[i][j]));
            res = Math.Max(res, 1 + Backtrack(i, j+1, matrix[i][j]));
            res = Math.Max(res, 1 + Backtrack(i, j-1, matrix[i][j]));
            dp.Add((i,j),res);
            return res;
        }
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Backtrack(i,j,-1);
            }
        }
        return dp.Values.Max();
    }
}