Solution solution = new();

solution.SpiralOrder(new []
{
    new []{1,2,3,4},
    new []{5,6,7,8},
    new []{9,10,11,12},
});


Console.WriteLine("Hello, World!");


public class Solution {
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new();
        var columnAndRow = FindColumnAndRow(matrix);

        for (int i = 0; i < columnAndRow.column; i++)
        {
            result.Add(matrix[0][i]);
        }


        for (int i = 1; i < columnAndRow.row; i++)
        {
            result.Add(matrix[i][columnAndRow.column-1]);
        }

        for (int i = columnAndRow.column - 2; i >= 0; i--)
        {
            result.Add(matrix[columnAndRow.row-1][i]);
        }

        //Bu method parametleri değiştirerek sonucu belki değiştirebilir.
        //Üzerine eklemeler yapılacak
        void Recursive()
        {
            for (int i = 0; i < columnAndRow.column; i++)
            {
                result.Add(matrix[0][i]);
            }


            for (int i = 1; i < columnAndRow.row; i++)
            {
                result.Add(matrix[i][columnAndRow.column-1]);
            }

            for (int i = columnAndRow.column - 2; i >= 0; i--)
            {
                result.Add(matrix[columnAndRow.row-1][i]);
            }
        }


        return result;
    }

    private (int row,int column) FindColumnAndRow(int[][] matrix)
    {
        int row = matrix.Length;
        int column = matrix[0].Length;

        return (row, column);
    }
}

