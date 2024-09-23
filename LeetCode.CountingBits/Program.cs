Solution solution = new();
solution.CountBits(5);


Console.WriteLine("Hello, World!");

public partial class Solution
{
    public int[] CountBits(int n)
    {
        int[] cache = new int[n + 1];
        cache[0] = 0;
        for (int i = 1; i <= n; i++)
        {
            int j = i;
            int count = 0;
            while (j != 0)
            {
                if (j % 2 == 1)
                {
                    count++;
                }

                j /= 2;
            }

            cache[i] = count;
        }

        return cache;
    }
}

