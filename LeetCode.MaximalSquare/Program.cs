Solution solution = new();
solution.MaximalSquare4(new[]
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
    public int MaximalSquare2(char[][] matrix)
    {
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
        int Dfs(int row, int col)
        {
            if (row == matrix.Length || col == matrix[0].Length)
            {
                return 0;
            }

            if (cache.ContainsKey((row,col)))
            {
                return cache[(row, col)];
            }
            int down = Dfs(row + 1, col);
            int right = Dfs(row, col + 1);
            int diag = Dfs(row + 1, col + 1);
            cache[(row, col)] = 0;
            if (matrix[row][col] == '1')
            {
                cache[(row,col)]= 1 + Math.Min(down, Math.Min(right, diag));
            }

            return cache[(row,col)];
        }

        Dfs(0, 0);
        return 0;
    }
}



public partial class Solution
{
    public int MaximalSquare3(char[][] matrix)
    {
        int max = 0;
        int[,] dp = new int[matrix.Length,matrix[0].Length];
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                dp[i, j] = matrix[i][j] - 48;
            }
        }
        for (int i = matrix.Length -1; i >= 0; i--)
        {
            for (int j = matrix[0].Length-1; j >= 0; j--)
            {
                if (i < matrix.Length -1 && j < matrix[0].Length-1)
                {
                    if (dp[i,j] == 1)
                    {
                        int right = dp[i,j + 1];
                        int down = dp[i + 1,j];
                        int diag = dp[i + 1,j + 1];
                        if (right >= 1 && down >= 1 && diag >= 1)
                        {
                            dp[i,j] = Math.Min(right, Math.Min(down, diag)) + 1;
                        }
                    }
                }
                max = Math.Max(max, dp[i, j]);
            }
        }
        return max * max;
    }
}

public partial class Solution
{
    public int MaximalSquare4(char[][] matrix)
    {
        int max = 0;
        int tempMax = 0;
        for (int i = matrix.Length -1; i >= 0; i--)
        {
            for (int j = matrix[0].Length-1; j >= 0; j--)
            {
                tempMax = matrix[i][j] - 48;
                if (i < matrix.Length -1 && j < matrix[0].Length-1)
                {
                    if (matrix[i][j] == '1')
                    {
                        int right = matrix[i][j + 1] - 48;
                        int down = matrix[i + 1][j] - 48;
                        int diag = matrix[i + 1][j + 1] - 48;
                        if (right >= 1 && down >= 1 && diag >= 1)
                        {
                            tempMax = Math.Min(right, Math.Min(down, diag)) + 1;
                            matrix[i][j] = (char)(tempMax + 48);
                        }
                    }
                }
                max = Math.Max(max, tempMax);
            }
        }
        return max * max;
    }
}