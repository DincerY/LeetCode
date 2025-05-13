Solution solution = new();
solution.PacificAtlantic(new[]
{
    new[] { 1, 2, 2, 3, 5 },
    new[] { 3, 2, 3, 4, 4 },
    new[] { 2, 4, 5, 3, 1 },
    new[] { 6, 7, 1, 4, 5 },
    new[] { 5, 1, 1, 2, 4 },
});

Console.WriteLine("Hello, World!");


public class Solution
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        int ROWS = heights.Length, COLS = heights[0].Length;
        HashSet<(int, int)> pac = new HashSet<(int, int)>();
        HashSet<(int, int)> atl = new HashSet<(int, int)>();

        void Dfs(int r, int c, HashSet<(int, int)> visit, int prevHeight)
        {
            if (r < 0 || c < 0 || r == ROWS || c == COLS || visit.Contains((r, c)) || heights[r][c] < prevHeight)
            {
                return;
            }

            visit.Add((r, c));
            Dfs(r + 1, c, visit, heights[r][c]);
            Dfs(r - 1, c, visit, heights[r][c]);
            Dfs(r, c + 1, visit, heights[r][c]);
            Dfs(r, c - 1, visit, heights[r][c]);
        }

        for (int c = 0; c < COLS; c++)
        {
            Dfs(0, c, pac, heights[0][c]);
            Dfs(ROWS - 1, c, atl, heights[ROWS - 1][c]);
        }

        for (int r = 0; r < ROWS; r++)
        {
            Dfs(r, 0, pac, heights[r][0]);
            Dfs(r, COLS - 1, atl, heights[r][COLS - 1]);
        }

        IList<IList<int>> res = new List<IList<int>>();
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                if (pac.Contains((r, c)) && atl.Contains((r, c)))
                {
                    res.Add(new List<int> { r, c });
                }
            }
        }

        return res;
    }
}