Solution solution = new();
// solution.EraseOverlapIntervals(new[]
// {
//     new[] { 1, 2 },
//     new[] { 2, 3 },
//     new[] { 3, 4 },
//     new[] { 1, 3 },
// });

solution.EraseOverlapIntervals(new[]
{
    new[] { 1, 3 },
    new[] { 2, 3 },
    new[] { 3, 4 },
    new[] { 1, 2 },
});

Console.WriteLine("Hello, World!");
//Needcode solution
public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        var sortedIntervals = intervals.Clone() as int[][];
        Array.Sort(sortedIntervals, (a, b) => a[0] - b[0]);
        
        var result = 0;
        var prevEnd = sortedIntervals[0][1];
        for (var i = 1; i < sortedIntervals.Length; i++)
        {
            var curr = sortedIntervals[i];
            if (prevEnd > curr[0])
            {
                result++;
                prevEnd = Math.Min(prevEnd, curr[1]);
            }
            else
            {
                prevEnd = curr[1];
            }
        }
        return result;
    }
}