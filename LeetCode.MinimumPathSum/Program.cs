Solution solution = new();
// solution.MinPathSum3(new[]
// {
//     new[] { 1, 3, 1 },
//     new[] { 1, 5, 1 },
//     new[] { 4, 2, 1 },
// });

solution.MinPathSum3(new[]
{
    new[] { 1, 2, 3 },
    new[] { 4, 5, 6 }
});

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int MinPathSum(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[,] memoization = new int[m, n];
        int Recursion(int r, int c)
        {
            if (r >= m  || c >= n)
            {
                return int.MaxValue;
            }
            if (r == m -1 && c == n -1)
            {
                return grid[r][c];
            }
            if (memoization[r,c] != 0)
            {
                return memoization[r, c];
            }
            var down = Recursion(r + 1, c); 
            var right = Recursion(r , c+1);
            memoization[r, c] = Math.Min(down,right) + grid[r][c];
            return memoization[r,c];
        }
        return Recursion(0,0);
    }
}


public partial class Solution
{
    public int MinPathSum2(int[][] grid)
    {
        List<int> list = new();
        void Recursion(int row,int col,int sum) 
        {
            if (row > grid.Length-1 || col > grid[0].Length-1)
            {
                return;
            }
            sum += grid[row][col];
            if (row == grid.Length-1 && col == grid[0].Length-1)
            {
                list.Add(sum);
            }
            
            Recursion(row+1,col, sum);
            Recursion(row,col+1, sum);
        }
        Recursion(0,0,0);

        return list.Min();
    }
}

public partial class Solution
{
    public int MinPathSum3(int[][] grid)
    {
        int[,] dp = new int[grid.Length+1,grid[0].Length+1];
        for (int i = 0; i < grid.Length+1; i++)
        {
            for (int j = 0; j < grid[0].Length+1; j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }
        for (int i = grid.Length-1; i >= 0; i--)
        {
            for (int j = grid[0].Length-1; j >= 0; j--)
            {
                dp[i, j] = grid[i][j];
                if (i+1 == grid.Length && j+1 == grid[0].Length)
                {
                    continue;
                }

                dp[i, j] += Math.Min(dp[i+1,j], dp[i,j+1]);
            }
        }
        return dp[0, 0];
    }
}

