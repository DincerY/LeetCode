Solution solution = new();
solution.GenerateMatrix(3);



Console.WriteLine("Hello, World!");



public class Solution {
    public int[][] GenerateMatrix(int n)
    {
        int addValue = 1;
        int left = 0;
        int right = n - 1;
        int top = 0;
        int bottom = n - 1;
        
        int[][] matrix = new int[n][];
        for (int i = 0; i < n ; i++)
        {
            matrix[i] = new int[n];
        }
        
        while (bottom >= top || left <= right)
        {
            for (int j = left; j <= right ; j++)
            {
                matrix[top][j] = addValue;
                addValue++;
            }
            top++;

            for (int j = top; j <= bottom; j++)
            {
                matrix[j][right] = addValue;
                addValue++;
            }
            right--;

            for (int j = right; j >= left; j--)
            {
                matrix[bottom][j] = addValue;
                addValue++;
            }
            bottom--;

            for (int j = bottom; j >= top; j--)
            {
                matrix[j][left] = addValue;
                addValue++;
            }

            left++;
        }

        return matrix;
    }
}   