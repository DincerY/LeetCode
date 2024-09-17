using System.Numerics;

Solution solution = new();

solution.TrailingZeroes2(25);

Console.WriteLine("Hello, World!");

//time limit excited
public partial class Solution
{
    public int TrailingZeroes(int n)
    {
        int res = 0;
        BigInteger fac = Factorial(n);
        while (fac % 10 == 0)
        {
            res++;
            fac /= 10;
        }

        BigInteger Factorial(int step)
        {
            if (step > 1)
            {
                return step * Factorial(step - 1);
            }

            return 1;
        }

        return res;
    }
}

public partial class Solution
{
    public int TrailingZeroes2(int n)
    {
        int res = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            res = res + n / i;
        }
        return res;
    }
}