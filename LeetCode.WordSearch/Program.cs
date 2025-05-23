Solution solution = new();
solution.Exist(new[]
{
    new[] { 'A', 'B', 'C', 'E' },
    new[] { 'S', 'F', 'C', 'S' },
    new[] { 'A', 'D', 'E', 'E' },
}, "ABCCED");

// solution.Exist(new[]
// {
//     new[] { 'A', 'B', 'C', 'C' },
//     new[] { 'S', 'C', 'A', 'E' },
//     new[] { 'A', 'C', 'D', 'D' },
// }, "ABCCED");



// solution.Exist(new[]
// {
//     new[] { 'A', 'B', 'C', 'E' },
//     new[] { 'S', 'F', 'C', 'S' },
//     new[] { 'A', 'D', 'E', 'E' },
// }, "SEE");


Console.WriteLine("Hello, World!");


public partial class Solution
{
    /// <summary>
    /// It is not mine
    /// Very hard problem
    /// </summary>
    /// <param name="board"></param>
    /// <param name="word"></param>
    /// <returns></returns>
    public bool Exist(char[][] board, string word)
    {
        int ROWS = board.Length;
        int COLS = board[0].Length;
        HashSet<string> path = new HashSet<string>();

        bool DFS(int r, int c, int i)
        {
            if (i == word.Length)
                return true;

            if (r < 0 || r >= ROWS || c < 0 || c >= COLS || word[i] != board[r][c] || path.Contains(r.ToString() + c.ToString()))
                return false;

            path.Add(r.ToString() + c.ToString());

            bool res = DFS(r + 1, c, i + 1) || DFS(r - 1, c, i + 1) || DFS(r, c + 1, i + 1) || DFS(r, c - 1, i + 1);

            path.Remove(r.ToString() + c.ToString());

            return res;
        }

        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                if (DFS(r, c, 0))
                    return true;
            }
        }

        return false;
    }
}

public partial class Solution
{
    public bool Exist2(char[][] board, string word)
    {
        HashSet<(int, int)> hash = new();
        int row = board.Length;
        int col = board[0].Length;
        for (int r = 0; r < row; r++)
        {
            for (int c = 0; c < col; c++)
            {
                if (Dfs(r,c,0))
                {
                    return true;
                }
            }
        }
        return false;
        bool Dfs(int r, int c, int i)
        {
            if (i == word.Length)
            {
                return true;
            }
            if (r < 0 || r >= row || c < 0 || c >= col || word[i] != board[r][c] || hash.Contains((r,c)))
            {
                return false;
            }
            hash.Add((r,c));
            bool res = Dfs(r + 1, c, i + 1) || Dfs(r - 1, c, i + 1) || Dfs(r, c + 1, i + 1) || Dfs(r, c - 1, i + 1);
            hash.Remove((r, c));
            return res;
        }
    }
}
