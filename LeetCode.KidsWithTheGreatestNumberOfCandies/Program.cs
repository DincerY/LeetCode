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
    
    public IList<bool> KidsWithCandies2(int[] candies, int extraCandies)
    {
        bool[] arr = new bool[candies.Length];
        int max = candies.Max();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                arr[i] = true;
            }
        }
        return arr;
    }
}