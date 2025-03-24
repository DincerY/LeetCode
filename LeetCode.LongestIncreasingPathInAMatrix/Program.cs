Solution solution = new();
solution.LongestIncreasingPath(new[]
{
    new[] { 9, 9, 4 },
    new[] { 6, 6, 8 },
    new[] { 2, 1, 1 },
});

solution.LongestIncreasingPath(new[]
{
    new[] { 3, 4, 5 },
    new[] { 3, 2, 6 },
    new[] { 2, 2, 1 },
});

Console.WriteLine("Hello, World!");


public class Solution
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        int max = 0;

        void Backtrack(int i, int j, int val)
        {
            if (i >= matrix.Length || j >= matrix[0].Length || i < 0 || j < 0)
            {
                max = Math.Max(max, val);
                return;
            }

            if (matrix[i][j-1] > matrix[i][j])
            {
                Backtrack(i, j - 1, val + 1); //Left          
            }
            if (matrix[i-1][j] > matrix[i][j])
            {
                Backtrack(i - 1, j, val + 1);
            }
            if (matrix[i][j+1] > matrix[i][j])
            {
                Backtrack(i, j + 1, val + 1);
            }
            if (matrix[i+1][j] > matrix[i][j])
            {
                Backtrack(i + 1, j, val + 1);
            }
        }

        Backtrack(0, 0, 0);
        return max;
    }
}