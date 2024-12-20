Solution solution = new();
// solution.SlidingPuzzle(new[]
// {
//     new[] { 1, 2, 3 },
//     new[] { 4, 0, 5 }
// });

/*solution.SlidingPuzzle(new[]
{
    new[] { 1, 2, 3 },
    new[] { 5, 4, 0 }
});*/

solution.SlidingPuzzle(new[]
{
    new[] { 4, 1, 2 },
    new[] { 5, 0, 3 }
});


Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
{
    public int SlidingPuzzle(int[][] board)
    {
        var adj = new Dictionary<int, List<int>>
        {
            { 0, new List<int> { 1, 3 } },
            { 1, new List<int> { 0, 2, 4 } },
            { 2, new List<int> { 1, 5 } },
            { 3, new List<int> { 0, 4 } },
            { 4, new List<int> { 1, 3, 5 } },
            { 5, new List<int> { 2, 4 } }
        };

        var b = string.Join("", board.SelectMany(row => row).Select(c => c.ToString()));
        var q = new Queue<(int, string, int)>();
        q.Enqueue((b.IndexOf("0"), b, 0));
        var visit = new HashSet<string> { b };

        while (q.Count > 0)
        {
            var (i, bStr, length)  = q.Dequeue();

            if (bStr == "123450")
            {
                return length;
            }

            var bArr = bStr.ToCharArray();
            foreach (var j in adj[i])
            {
                var newBArr = (char[])bArr.Clone();
                (newBArr[i], newBArr[j]) = (bArr[j], bArr[i]);
                var newB = new string(newBArr);
                if (!visit.Contains(newB))
                {
                    q.Enqueue((j, newB, length + 1));
                    visit.Add(newB);
                }
            }
        }

        return -1;
    }
}