Solution solution = new();
solution.Insert2(new[]
{
    new[] { 1, 2 },
    new[] { 3, 5 },
    new[] { 6, 7 },
    new[] { 8, 10 },
    new[] { 12, 16 }
}, new[]
{
    4, 8
});

// solution.Insert(new[]
// {
//     new[] { 1, 3 },
//     new[] { 6, 9 }
// }, new[]
// {
//     2, 5
// });



Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return new[] { newInterval };
        }

        List<int[]> result = new();
        int i = 0;
        for (i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                continue;
            }
            else
            {
                intervals[i][1] = Math.Max(intervals[i][1], newInterval[1]);
                intervals[i][0] = Math.Min(intervals[i][0], newInterval[0]);
                break;
            }
        }

        for (int j = i + 1; j < intervals.Length; j++)
        {
            if (intervals[i][1] >= intervals[j][0])
            {
                intervals[i][1] = Math.Max(intervals[i][1], intervals[j][1]);
            }
            else
            {
                result.Add(intervals[i]);
                i = j;
            }
        }

        if (i >= intervals.Length)
        {
            result.Add(newInterval);
            return result.ToArray();
        }
        result.Add(intervals[i]);

        return result.ToArray();
    }
}

public partial class Solution
{
    public int[][] Insert2(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new();
        foreach (var interval in intervals)
        {
            if (interval[0] > newInterval[1])
            {
                result.Add(newInterval);
                newInterval = interval;
            }
            else if (interval[1] < newInterval[0])
            {
                result.Add(interval);
            }
            else
            {
                newInterval[0] = Math.Min(interval[0], newInterval[0]);
                newInterval[1] = Math.Max(interval[1], newInterval[1]);
            }
        }
        result.Add(newInterval);
        return result.ToArray();
    }
}
















