Solution solution = new Solution();
solution.GetRow(3);


Console.WriteLine("Hello, World!");


public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        return Generate(rowIndex);
    }

    private IList<int> Generate(int rowIndex)
    {
        int rowCount = rowIndex + 1;
        int[][] res = new int[rowCount][];
        res[0] = [1];
        for (int i = 1; i < rowCount; i++)
        {
            int[] row = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row[j] = 1;
                }
                else
                {
                    row[j] = res[i - 1][j - 1] + res[i - 1][j];
                }
            }

            res[i] = row;
        }

        return res[^1];
    }
}