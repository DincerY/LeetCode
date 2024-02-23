Solution solution = new();
solution.Merge(new[]
{
    new[] { 1, 3 },
    new[] { 2, 6 },
    new[] { 8, 10 },
    new[] { 15, 18 }
});
// solution.Merge(new[]
// {
//     new[] { 1, 4 },
//     new[] { 0, 1 }
// });

solution.SortMatrix(new[]
{
    new[] { 1, 3 },
    new[] { 4, 5 },
    new[] { 3, 6 },
    new[] { 2, 10 },
    new[] { 15, 18 }
});



Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        int currArray = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i] == null)
            {
                continue;
            }
            //Eger ki sort işlmei olusa 0 elemanların kontrolüne gerek kalmaz
            if (intervals[i][0] <= intervals[currArray][0] || intervals[i][0] <= intervals[currArray][1])
            {
                intervals[currArray][0] = Math.Min(intervals[currArray][0], intervals[i][0]);
                intervals[currArray][1] = Math.Max(intervals[currArray][1], intervals[i][1]);
                intervals[i] = null;
            }
        }
        int[][] result = new int[NotNullValueCount(intervals)][];

        return NotNullMatrix(intervals,result);
        
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

    public void SortMatrix(int[][] matrix)
    {
        Dictionary<int, int> dictionary = new();
        for (int i = 0; i < matrix.Length; i++)
        {
            dictionary.Add(matrix[i][0],i);
        }
    }

    //Bu methodu başka zaman doldurucam
    public void InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            while (true)
            {
                    
            }
        }
    }

    
    
}