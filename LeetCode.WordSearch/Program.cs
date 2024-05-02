Solution solution = new();
solution.Exist(new[]
{
    new[] { 'A', 'B', 'C', 'E' },
    new[] { 'S', 'F', 'C', 'S' },
    new[] { 'A', 'D', 'E', 'E' },
}, "ABCCED");

// solution.Exist(new[]
// {
//     new[] { 'A', 'B', 'C', 'E' },
//     new[] { 'S', 'F', 'C', 'S' },
//     new[] { 'A', 'D', 'E', 'E' },
// }, "SEE");


Console.WriteLine("Hello, World!");


public class Solution
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
