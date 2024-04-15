﻿using System.Runtime.InteropServices;

Solution solution = new();
// solution.SetZeroes(new[]
// {
//     new[] { 1, 1, 1 },
//     new[] { 1, 0, 1 },
//     new[] { 1, 1, 1 },
//     new[] { 1, 0, 0 },
//     new[] { 0, 1, 1 },
// });
// solution.SetZeroes2(new[]
// {
//     new[] { 0,1,2,0 },
//     new[] { 3,4,5,2 },
//     new[] { 1,3,1,5 },
// });

solution.SetZeroes3(new[]
{
    new[] { 0,1,2,0 },
    new[] { 3,4,5,2 },
    new[] { 1,3,1,5 },
});


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        Dictionary<int, List<int>> dictionary = new();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    List<int> sutun;
                    if (!dictionary.TryGetValue(i, out sutun))
                    {
                        sutun = new List<int>();
                        dictionary.Add(i, sutun);
                    }
                    sutun.Add(j);
                }
            }
        }
        foreach (var key in dictionary.Keys)
        {
            for (int i = 0; i < matrix[key].Length; i++)
            {
                matrix[key][i] = 0;
            }
        }
        List<int> column = new List<int>();
        foreach (var list in dictionary.Values)
        {
            foreach (var i in list)
            {
                if (!column.Contains(i))
                {   
                    column.Add(i);
                }
            }
        }
        foreach (var i in column)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[j][i] = 0;
            }
        }
    }
}


public partial class Solution
{
    public void SetZeroes2(int[][] matrix)
    {
        int[] column = new int[matrix[0].Length];
        int[] row = new int[matrix.Length];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    column[j] = 1;
                    row[i] = 1;
                }
            }
        }
        for (int i = 0; i < column.Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                if (column[i] == 1) 
                    matrix[j][i] = 0;
            }
        }
        for (int i = 0; i < row.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (row[i] == 1) 
                    matrix[i][j] = 0;
            }
        }
    }
}



public partial class Solution
{
    public void SetZeroes3(int[][] matrix)
    {
        int firstElementColumn = matrix[0][0];
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    //row
                    matrix[0][j] = 0;
                    //column
                    if (j == 0)
                        firstElementColumn = 0;
                    else
                        matrix[i][0] = 0;
                }
            }
        }

        for (int i = 0; i < matrix[0].Length; i++)
        {
            if (matrix[0][i] == 0)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[j][i] = 0;
                }
            }
        }
        
        for (int i = 0; i < matrix.Length; i++)
        {
            if (i == 0)
            {
                if (firstElementColumn == 0)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            else
            {
                if (matrix[i][0] == 0)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
           
        }

        Console.WriteLine();


    }
}