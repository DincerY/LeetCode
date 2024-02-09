Solution solution = new();

// solution.SpiralOrder(new []
// {
//     new []{1,2,3,4,5,6},
//     new []{7,8,9,10,11,12},
//     new []{13,14,15,16,17,18},
//     new []{19,20,21,22,23,24},
//     new []{25,26,27,28,29,30},
//     new []{31,32,33,34,35,36},
// });

// solution.SpiralOrder(new []
// {
//     new []{1,2,3,4},
//     new []{5,6,7,8},
//     new []{9,10,11,12}
//
// });

var result = solution.SpiralOrder2(new[]
{
    new[] { 1, 2, 3, 4 },
    new[] { 5, 6, 7, 8 },
    new[] { 9, 10, 11, 12 }
});


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new();
        var columnAndRow = FindColumnAndRow(matrix);
        int left = 0;
        int right = 0;
        int top = 0;
        int bottom = 0;
        int d = 0;
        if (columnAndRow.column == 1)
        {
            for (int i = 0; i < columnAndRow.row; i++)
            {
                result.Add(matrix[i][0]);
            }

            return result;
        }

        if (columnAndRow.row == 1)
        {
            for (int i = 0; i < columnAndRow.column; i++)
            {
                result.Add(matrix[0][i]);
            }

            return result;
        }

        while (d < columnAndRow.row)
        {
            for (int i = left; i < columnAndRow.column - right; i++)
            {
                result.Add(matrix[top][i]);
            }

            top++;


            for (int i = top; i < columnAndRow.row - bottom; i++)
            {
                result.Add(matrix[i][columnAndRow.column - 1 - bottom]);
            }

            right++;


            for (int i = columnAndRow.column - 1 - right; i >= left; i--)
            {
                if (top + bottom != columnAndRow.row)
                {
                    result.Add(matrix[columnAndRow.row - 1 - bottom][i]);
                }
            }

            bottom++;

            for (int i = columnAndRow.row - 1 - bottom; i >= top; i--)
            {
                result.Add(matrix[i][left]);
            }

            left++;
            d++;
        }

        return result;
    }

    private (int row, int column) FindColumnAndRow(int[][] matrix)
    {
        int row = matrix.Length;
        int column = matrix[0].Length;

        return (row, column);
    }
}

public partial class Solution
{
    public IList<int> SpiralOrder2(int[][] matrix)
    {
        List<int> result = new List<int>();
        int left = 0;
        int right = matrix[0].Length - 1;
        int top = 0;
        int bottom = matrix.Length - 1;

        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }

            top++;

            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
        
            right--;
            
            if (top > bottom || left > right)
            {
                break;
            }
            for (int i = right; i >= left; i--)
            {
                result.Add(matrix[bottom][i]);
            }

            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                result.Add(matrix[i][left]);
            }

            left++;
        }


        return result;
    }
}