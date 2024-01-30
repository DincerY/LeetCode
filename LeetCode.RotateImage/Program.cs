Solution solution = new();
int[][] input = new[]
{
    new[] { 5,1,9,11 },
    new[] { 2,4,8,10 },
    new[] { 13,3,6,7 },
    new[] { 15,14,12,16 },
};
solution.Rotate(input);


Console.WriteLine("Hello, World!");


public class Solution
{
    public void Rotate(int[][] matrix)
    {
        List<int> deneme = new();
        int b = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            int a = matrix.Length-1;
            for (int j = 0; j < matrix.Length; j++)
            {
                deneme.Add(matrix[a][b]);
                a--;
            }
            b++;
        }

        int k = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[i][j] = deneme[k];
                k++;
            }
        }
    }
}