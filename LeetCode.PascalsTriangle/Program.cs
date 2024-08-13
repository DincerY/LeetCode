Solution solution = new Solution();
solution.Generate2(5);


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> list = new();
        List<int> arr = new();
        if (numRows == 1)
        {
            arr.Add(numRows);
            list.Add(arr);
            return list;
        }

        arr.Add(1);
        list.Add(arr.ToList());
        arr.Clear();
        int i = 0;

        for (int j = 1; j < numRows; j++)
        {
            var tempArr = list[^1];
            arr.Add(1);
            while (i <= tempArr.Count - 1)
            {
                if (i + 1 <= tempArr.Count - 1)
                {
                    arr.Add(tempArr[i] + tempArr[i + 1]);
                }
                else
                {
                    arr.Add(1);
                }

                i++;
            }

            i = 0;
            list.Add(arr.ToList());
            arr.Clear();
        }

        return list;
    }
}

//it is not mine solution
public partial class Solution
{
    public IList<IList<int>> Generate2(int numRows)
    {
        int[][] ans = new int[numRows][];
        ans[0] = new[] { 1 };
        for (int i = 1; i < numRows; i++)
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
                    row[j] = ans[i - 1][j - 1] + ans[i - 1][j];
                }
            }

            ans[i] = row;
        }

        return ans;
    }
}