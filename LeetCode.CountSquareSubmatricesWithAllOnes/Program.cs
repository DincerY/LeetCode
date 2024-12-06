Solution solution = new();
solution.CountSquares2(new[]
{
    new[] { 0, 1, 1, 1 },
    new[] { 1, 1, 1, 1 },
    new[] { 0, 1, 1, 1 },
});

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int CountSquares(int[][] matrix)
    {
        int count = 0;
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();

        int Helper(int r, int c)
        {
            if (r >= rows || c >= cols)
            {
                return 0;
            }

            if (!cache.ContainsKey((r, c)))
            {
                int down = Helper(r + 1, c);
                int right = Helper(r, c + 1);
                int diag = Helper(r + 1, c + 1);

                cache[(r, c)] = 0;
                if (matrix[r][c] == 1)
                {
                    cache[(r, c)] = 1 + Math.Min(down, Math.Min(right, diag));
                }
            }

            return cache[(r, c)];
        }

        Helper(0, 0);

        foreach (var i in cache)
        {
            if (i.Value > 1)
            {
                count += i.Value - 1;
                count++;
            }
            else if (i.Value == 1)
            {
                count++;
            }
        }

        return count;
    }
}

//NeedCode solution
public partial class Solution
{
    public int CountSquares2(int[][] matrix)
    {
        int rows = matrix.Length, cols = matrix[0].Length;
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
        int Dfs(int r, int c)
        {
            if (r == rows || c == cols || matrix[r][c] == 0)
            {
                return 0;
            }
            if (cache.ContainsKey((r, c)))
            {
                return cache[(r, c)];
            }
            cache[(r, c)] = 1 + Math.Min(
                Dfs(r + 1, c),
                Math.Min(Dfs(r, c + 1), Dfs(r + 1, c + 1))
            );
            return cache[(r, c)];
        }
        int res = 0;
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                res += Dfs(r, c);
            }
        }
        return res;
    }
}