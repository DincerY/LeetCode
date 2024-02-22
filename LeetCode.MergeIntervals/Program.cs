Solution solution = new();
solution.Merge(new[]
{
    new[] { 1, 3 },
    new[] { 2, 6 },
    new[] { 8, 10 },
    new[] { 10, 12 },
    new[] { 15, 18 }
});


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        int currArr = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[currArr][1] >= intervals[i][0])
            {
                intervals[currArr][1] = intervals[i][1];
                intervals[i] = null;
            }
            else
            {
                currArr = i;
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
    
}