Solution solution = new();
solution.MaximalSquare2(new[]
{
    new[] { '1', '0', '1', '0', '0' },
    new[] { '1', '0', '1', '1', '1' },
    new[] { '1', '1', '1', '1', '1' },
    new[] { '1', '0', '0', '1', '0' },
});


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
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
                if (matrix[r][c] == '1')
                {
                    cache[(r, c)] = 1 + Math.Min(down, Math.Min(right, diag));
                }
            }

            return cache[(r, c)];
        }

        Helper(0, 0);
        return (int)Math.Pow(cache.Values.Max(), 2);
    }
}

public partial class Solution
{
    //Bunu dp ye nasıl çeviricez
    public int MaximalSquare2(char[][] matrix)
    {
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
        int Dfs(int row, int col)
        {
            if (row == matrix.Length || col == matrix[0].Length)
            {
                return 0;
            }

            int down = Dfs(row + 1, col);
            int right = Dfs(row, col + 1);
            int diag = Dfs(row + 1, col + 1);
            cache[(row, col)] = 0;
            if (matrix[row][col] == '1')
            {
                cache[(row,col)]= 1 + Math.Max(down, Math.Max(right, diag));
            }

            return cache[(row,col)];
        }

        Dfs(0, 0);
        return 0;
    }
}