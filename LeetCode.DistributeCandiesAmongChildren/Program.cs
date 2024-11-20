Solution solution = new();
solution.DistributeCandies(5, 2);
solution.DistributeCandies(3, 3);


Console.WriteLine("Hello, World!");


public class Solution
{
    public int DistributeCandies(int n, int limit)
    {
        int res = 0;
        for (int i = 0; i <= limit; i++)
        {
            for (int j = 0; j <= limit; j++)
            {
                for (int k = 0; k <= limit; k++)
                {
                    if (i+k+j == n)
                    {
                        res++;
                    }
                }
            }
        }
        return res;
    }
}