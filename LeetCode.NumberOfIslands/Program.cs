Solution solution = new();
solution.NumIslands2(new[]
{
    new[] { '1', '1', '1', '1', '0' },
    new[] { '1', '1', '0', '1', '0' },
    new[] { '1', '1', '0', '0', '0' },
    new[] { '0', '0', '0', '0', '0' },
});
solution.NumIslands2(new[]
{
    new[] { '1', '1', '0', '0', '0' },
    new[] { '1', '1', '0', '0', '0' },
    new[] { '0', '0', '1', '0', '0' },
    new[] { '0', '0', '0', '1', '1' },
});

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    Dfs(i, j);
                    count++;
                }
            }
        }
        void Dfs(int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] != '1')
            {
                return;
            }
            grid[i][j] = '0';
            Dfs(i - 1, j);
            Dfs(i + 1, j);
            Dfs(i, j - 1);
            Dfs(i, j + 1);
        }
        return count;
    }
}

//NeedCode solution
public partial class Solution
{
    public int NumIslands2(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }

        int rows = grid.Length, cols = grid[0].Length;
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        int islands = 0;

        void Bfs(int r, int c)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            visited.Add((r, c));
            q.Enqueue((r, c));

            while (q.Count > 0)
            {
                var (row, col) = q.Dequeue();
                int[][] directions = new int[][]
                {
                    new int[] { 1, 0 },
                    new int[] { -1, 0 },
                    new int[] { 0, 1 },
                    new int[] { 0, -1 }
                };

                foreach (var direction in directions)
                {
                    int dr = direction[0], dc = direction[1];
                    int newRow = row + dr, newCol = col + dc;
                    if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && grid[newRow][newCol] == '1' &&
                        !visited.Contains((newRow, newCol)))
                    {
                        q.Enqueue((newRow, newCol));
                        visited.Add((newRow, newCol));
                    }
                }
            }
        }
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1' && !visited.Contains((r, c)))
                {
                    Bfs(r, c);
                    islands++;
                }
            }
        }
        return islands;
    }
}