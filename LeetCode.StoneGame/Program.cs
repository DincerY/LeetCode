Solution solution = new();
solution.StoneGame(new[] { 5, 3, 4, 5 });

Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public bool StoneGame(int[] piles)
    {
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();

        int Dfs(int l, int r)
        {
            if (l > r)
            {
                return 0;
            }

            if (dp.ContainsKey((l, r)))
            {
                return dp[(l, r)];
            }

            bool even = (r - 1) % 2 == 0;
            int left = even ? piles[l] : 0;
            int right = even ? piles[r] : 0;

            dp[(l, r)] = Math.Max(Dfs(l + 1, r) + 
                                  left, Dfs(l, r - 1) + right);
            return dp[(l, r)];
        }

        return Dfs(0, piles.Length - 1) > (Sum(piles) / 2);
    }

    private int Sum(int[] piles)
    {
        int sum = 0;
        foreach (var pile in piles)
        {
            sum += pile;
        }

        return sum;
    }
}