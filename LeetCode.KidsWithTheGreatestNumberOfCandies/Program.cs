Solution solution = new();
solution.KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3);
solution.KidsWithCandies(new[] { 4, 2, 1, 1, 2 }, 1);

Console.WriteLine("Hello, World!");


public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> res = new();
        int max = candies.Max();

        foreach (var candy in candies)
        {
            if (candy + extraCandies >= max)
            {
                res.Add(true);
            }
            else
            {
                res.Add(false);
            }
        }
        return res;
    }
}