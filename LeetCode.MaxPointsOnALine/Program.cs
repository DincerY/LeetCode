Solution solution = new();
// solution.MaxPoints(new[]
// {
//     new[] { 1, 1 },
//     new[] { 2, 2 },
//     new[] { 3, 3 },
// });
solution.MaxPoints(new[]
{
    new[] { 1, 1 },
    new[] { 3, 2 },
    new[] { 5, 3 },
    new[] { 4, 1 },
    new[] { 2, 3 },
    new[] { 1, 4 }
});

Console.WriteLine("Hello, World!");


//It is not mine solution (so hard)
public class Solution
{
    public int MaxPoints(int[][] points)
    {
        int res = 1;

        for (int i = 0; i < points.Length; i++)
        {
            var p1 = points[i];
            var count = new Dictionary<double, int>();

            for (int j = i + 1; j < points.Length; j++)
            {
                var p2 = points[j];
                double slope;

                if (p2[0] == p1[0])
                {
                    slope = double.PositiveInfinity;
                }
                else
                {
                    slope = (double)(p2[1] - p1[1]) / (p2[0] - p1[0]);
                }

                if (!count.ContainsKey(slope))
                {
                    count[slope] = 0;
                }
                count[slope] += 1;
                res = Math.Max(res, count[slope] + 1);
            }
        }
        return res;
    }
}
