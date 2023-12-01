using System;
using System.Linq;

namespace LeetCode.ValidSudoku
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            int[,] multidimensionalArrayExample = new int[5, 2]
            {
                { 1, 2 },
                { 1, 2 },
                { 1, 2 },
                { 1, 2 },
                { 1, 2 },
            };
            //jagged array
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
        }
    }
    
    public class Solution {
        public bool IsValidSudoku(char[][] board)
        {
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i].Any(p => p == board[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
            
            
            
            
            
        }
        
        
        
        
        
        
        
        
    }
}
