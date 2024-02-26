Solution solution = new();
solution.Merge2(new[]
{
    new[] { 1, 3 },
    new[] { 2, 6 },
    new[] { 8, 10 },
    new[] { 15, 18 }
});
// solution.Merge2(new[]
// {
//     new[] { 2, 3 },
//     new[] { 2, 2 },
//     new[] { 3, 3 },
//     new[] { 1, 3 },
//     new[] { 5, 7 },
//     new[] { 2, 2 },
//     new[] { 4, 6 },
// });

Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        int currArray = 0;
        List<int[]> output = new List<int[]>();
        SortMatrix(intervals);
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= intervals[currArray][1])
            {
                intervals[currArray][1] = Math.Max(intervals[currArray][1], intervals[i][1]);
                intervals[i] = null;
            }
            else
            {
                output.Add(intervals[currArray]);
                currArray = i;
            }
        }
        output.Add(intervals[currArray]);

        int[][] result = new int[NotNullValueCount(intervals)][];

        return NotNullMatrix(intervals, result);
    }

    private int NotNullValueCount(int[][] arr)
    {
        int loop = 0;
        foreach (var interval in arr)
        {
            if (interval != null)
            {
                loop++;
            }
        }

        return loop;
    }

    private int[][] NotNullMatrix(int[][] arr, int[][] result)
    {
        int loop = 0;
        foreach (var interval in arr)
        {
            if (interval != null)
            {
                result[loop] = interval;
                loop++;
            }
        }

        return result;
    }

    /// <summary>
    /// Insertion sort işlemi yaptım.
    /// </summary>
    /// <param name="matrix"></param>
    public void SortMatrix(int[][] matrix)
    {
        for (int i = 1; i < matrix.Length; i++)
        {
            int[] value = matrix[i];
            int j = i - 1;
            while (j >= 0 && matrix[j][0] > value[0])
            {
                matrix[j + 1] = matrix[j];
                j--;
            }

            matrix[j + 1] = value;
        }
    }
}


public partial class Solution
{
    public int[][] Merge2(int[][] intervals)
    {
        int currArray = 0;
        List<int[]> output = new List<int[]>();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= intervals[currArray][1])
            {
                intervals[currArray][1] = Math.Max(intervals[currArray][1], intervals[i][1]);
                intervals[i] = null;
            }
            else
            {
                output.Add(intervals[currArray]);
                currArray = i;
            }
        }
        output.Add(intervals[currArray]);
        return output.ToArray();
    }
}