Solution solution = new();
solution.UniquePathsWithObstacles2(new[]
{
    new[] { 0, 0, 0 },
    new[] { 0, 1, 0 },
    new[] { 0, 0, 0 }
});
// solution.UniquePathsWithObstacles2(new[]
// {
//     new[] { 0, 1},
//     new[] { 0, 0}
// });


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int M = obstacleGrid.Length;
        int N = obstacleGrid[0].Length;

        int[,] grid = new int[M,N];

        int Recursion(int r, int c)
        {
            if (r >= M || c >= N || obstacleGrid[r][c] == 1)
                return 0;

            if (r == M - 1 && c == N - 1)
                return 1;

            if (grid[r,c] != 0)
            {
                return grid[r, c];
            }
            grid[r, c] = Recursion(r + 1, c) + Recursion(r , c + 1);

            return grid[r, c];
        }

        return Recursion(0, 0);
    }
}

public partial class Solution
{
    public int UniquePathsWithObstacles2(int[][] grid)
    {
        int M = grid.Length;
        int N = grid[0].Length;

        int[] dp = new int[N];
        dp[N - 1] = 1;

        for (int r = M - 1; r >= 0; r--)
        {
            for (int c = N - 1; c >= 0; c--)
            {
                if (grid[r][c] == 1)
                {
                    dp[c] = 0;
                }
                else if (c + 1 < N)
                {
                    dp[c] += dp[c + 1];
                }
            }
        }

        return dp[0];
    }
}

