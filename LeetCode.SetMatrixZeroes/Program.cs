Solution solution = new();
solution.SetZeroes(new[]
{
    new[] { 1, 1, 1 },
    new[] { 1, 0, 1 },
    new[] { 1, 1, 1 },
    new[] { 1, 0, 0 },
    new[] { 0, 1, 1 },
});


Console.WriteLine("Hello, World!");

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        Dictionary<int, int> dictionary = new();
        int[][] arr = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                arr[i] = new int[matrix[0].Length];
                if (matrix[i][j] == 0)
                {
                    //dictionary.Add(i,j);
                    arr[i][j] = 1;
                }
            }
        }
    }
}