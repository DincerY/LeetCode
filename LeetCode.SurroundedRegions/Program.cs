Solution solution = new();
solution.Solve(new[]
{
    new[] { 'X', 'X', 'X', 'X' },
    new[] { 'X', 'O', 'O', 'X' },
    new[] { 'X', 'X', 'O', 'X' },
    new[] { 'X', 'O', 'X', 'X' }
});


Console.WriteLine("Hello, World!");



//it is not mine solution
public class Solution {
    public void Solve(char[][] board) {
        int ROWS = board.Length, COLS = board[0].Length;

        void Capture(int r, int c) {
            if (r < 0 || c < 0 || r == ROWS || c == COLS || board[r][c] != 'O') {
                return;
            }

            board[r][c] = 'T';
            Capture(r + 1, c);
            Capture(r - 1, c);
            Capture(r, c + 1);
            Capture(r, c - 1);
        }

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                if (board[r][c] == 'O' && (r == 0 || r == ROWS - 1 || c == 0 || c == COLS - 1)) {
                    Capture(r, c);
                }
            }
        }

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                if (board[r][c] == 'O') {
                    board[r][c] = 'X';
                }
            }
        }

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                if (board[r][c] == 'T') {
                    board[r][c] = 'O';
                }
            }
        }
    }
}