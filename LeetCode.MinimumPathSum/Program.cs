Solution solution = new();
solution.MinPathSum(new[]
{
    new[] { 1, 3, 1 },
    new[] { 1, 5, 1 },
    new[] { 4, 2, 1 },
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

