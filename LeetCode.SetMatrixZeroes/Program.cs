Solution solution = new();
// solution.SetZeroes(new[]
// {
//     new[] { 1, 1, 1 },
//     new[] { 1, 0, 1 },
//     new[] { 1, 1, 1 },
//     new[] { 1, 0, 0 },
//     new[] { 0, 1, 1 },
// });
solution.SetZeroes(new[]
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
       //soldan sağa yukarıdan ağaşı tarama yaparken 0 gördüğümüzde bastan sonra sıfır yapıcaz
    }
}