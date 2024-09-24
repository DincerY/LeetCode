Solution solution = new();
solution.CountBits(16);


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[] CountBits(int n)
    {
        int[] cache = new int[n + 1];
        int prev = 1;
        for (int i = 1; i <= n; i++)
        {
            if (int.IsPow2(i))
            {
                prev = i;
            }
            cache[i] = cache[i - prev] + 1;
        }
        return cache;
    }
}

