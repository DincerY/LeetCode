Solution solution = new();
int[][] input = new[]
{
    new[] { 1, 2, 3 },
    new[] { 4, 5, 6 },
    new[] { 7, 8, 9 }
};
solution.Rotate(input);




Console.WriteLine("Hello, World!");



public class Solution {
    public void Rotate(int[][] matrix)
    {
        int[][] result = new int[matrix.Length][];
        Fill(result);
        List<int> deneme = new();
        int b = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            int a = 2;
            for (int j = 0; j < matrix.Length; j++)
            {
                result[i][j] = matrix[a][b];
                Console.WriteLine(matrix[a][b]);
                a--;
                //deneme.Add(matrix[i][j]);
            }
            b++;
        }
    }

    private void Fill(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[i] = new []{0,0,0};
            }
        }
    }
}