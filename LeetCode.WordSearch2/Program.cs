Solution solution = new();
solution.FindWords(new[]
{
    new[] { 'o', 'a', 'a', 'n' },
    new[] { 'e', 't', 'a', 'e' },
    new[] { 'i', 'h', 'k', 'r' },
    new[] { 'i', 'f', 'l', 'v' },
}, new[] { "oath", "pea", "eat", "rain" });

Console.WriteLine("Hello, World!");


public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        foreach (var word in words)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        Backtrack(board,word,i,j,new List<(int, int)>());
                    }
                }
            }
        }

        return null;
    }

    private void Backtrack(char[][] board, string search, int i, int j,List<(int,int)> list)
    {
        
    }
}