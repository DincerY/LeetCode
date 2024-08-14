Solution solution = new Solution();
solution.GetRow2(3);


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        return Generate(rowIndex);
    }
    private IList<int> Generate(int rowIndex)
    {
        int rowCount = rowIndex + 1;
        int[] res = new int[rowCount];
        res = [1];
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
                    row[j] = res[j - 1] + res[j];
                }
            }
            res = row;
        }
        return res;
    }
}

//It is not mine solution
public partial class Solution {
    public IList<int> GetRow2(int rowIndex) {
        List<int> res = new List<int> { 1 };
        
        for (int i = 0; i < rowIndex; i++) {
            List<int> nextRow = new List<int>(new int[res.Count + 1]);
            for (int j = 0; j < res.Count; j++) {
                nextRow[j] += res[j];
                nextRow[j + 1] += res[j];
            }
            res = nextRow;
        }
        return res;
    }
}