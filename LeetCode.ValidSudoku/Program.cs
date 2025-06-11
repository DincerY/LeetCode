using System;
using System.Collections.Generic;
using System.Linq;

Solution solution = new();
solution.IsValidSudoku(new char[9][]
{
    new []{'5','3','.','.','7','.','.','.','.'},
    new []{'6','.','.','1','9','5','.','.','.'},
    new []{'.','9','8','.','.','.','.','6','.'},
    new []{'8','.','.','.','6','.','.','.','3'},
    new []{'4','.','.','8','.','3','.','.','1'},
    new []{'7','.','.','.','2','.','.','.','6'},
    new []{'.','6','.','.','.','.','2','8','.'},
    new []{'.','.','.','4','1','9','.','.','5'},
    new []{'.','.','.','.','8','.','.','7','9'}
        
});
solution.IsValidSudoku(new char[9][]
{
    new []{'8','3','.','.','7','.','.','.','.'},
    new []{'6','.','.','1','9','5','.','.','.'},
    new []{'.','9','8','.','.','.','.','6','.'},
    new []{'8','.','.','.','6','.','.','.','3'},
    new []{'4','.','.','8','.','3','.','.','1'},
    new []{'7','.','.','.','2','.','.','.','6'},
    new []{'.','6','.','.','.','.','2','8','.'},
    new []{'.','.','.','4','1','9','.','.','5'},
    new []{'.','.','.','.','8','.','.','7','9'}
        
});
solution.IsValidSudoku(new char[9][]
{
    new []{'.','.','.','.','5','.','.','1','.'},
    new []{'.','4','.','3','.','.','.','.','.'},
    new []{'.','.','.','.','.','3','.','.','1'},
    new []{'8','.','.','.','.','.','.','2','.'},
    new []{'.','.','2','.','7','.','.','.','.'},
    new []{'.','1','5','.','.','.','.','.','.'},
    new []{'.','.','.','.','.','2','.','.','.'},
    new []{'.','2','.','9','.','.','.','.','.'},
    new []{'.','.','4','.','.','.','.','.','.'}
        
});

Console.WriteLine("Hello World!");

public partial class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<(int row, int col), char> dic = new();
        Dictionary<(int row, int col), List<char>> subBox = new();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                var rowCol = dic.Where(kv => kv.Value == board[i][j]).Select(kv => kv.Key);
                foreach (var tuple in rowCol)
                {
                    if (tuple.row == i || tuple.col == j)
                    {
                        return false;
                    }
                }
                dic.Add((i,j),board[i][j]);
                int r = i / 3;
                int c = j / 3;
                if (!subBox.ContainsKey((r,c)))
                {
                    subBox.Add((r,c), new List<char>());
                }
                if (subBox[(r,c)].Contains(board[i][j]))
                {
                    return false;
                }
                subBox[(r,c)].Add(board[i][j]);
            }
        }
        return true;
    }
}

public partial class Solution {
    public bool IsValidSudoku2(char[][] board)
    {
        Dictionary<int, HashSet<char>> row = new();
        Dictionary<int, HashSet<char>> col = new();
        Dictionary<(int row, int col), HashSet<char>> subBox = new();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                if (!col.ContainsKey(j)) 
                    col.Add(j, new HashSet<char>());

                if (!row.ContainsKey(i)) 
                    row.Add(i, new HashSet<char>());

                if (!subBox.ContainsKey((i/3,j/3))) 
                    subBox.Add((i/3,j/3), new HashSet<char>());
                if (row[i].Contains(board[i][j]) || col[j].Contains(board[i][j]) || subBox[(i/3,j/3)].Contains(board[i][j]))
                {
                    return false;
                }

                col[j].Add(board[i][j]);
                row[i].Add(board[i][j]);
                subBox[(i/3,j/3)].Add(board[i][j]);
            }
        }
        return true;
    }
}


